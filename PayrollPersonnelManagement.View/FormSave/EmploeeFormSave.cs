﻿using DevExpress.Data.ODataLinq.Helpers;
using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Controll;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View.FormSave
{
    public partial class EmploeeFormSave : FormAdapter<EmployeeDto>, IFormSave<Employee>
    {
        public EmployeeControll ModelActions { get; set; }

        public EmploeeFormSave(EmployeeControll modelActions)
        {
            ModelActions = modelActions;
            InitializeComponent();
        }

        public void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            if (PhisicalFaceEdit.EditValue != null && PostEdit.EditValue != null && SubdivisionEdit.EditValue != null)
            {
                var model = FormMapToModel();
                ModelActions.Save(model);
                Close();
            }
                    
        }

        public void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmploeeFormSave_Load(object sender, EventArgs e)
        {          
            var phisicals = ModelActions.GetPhisicalFaceDtos();
            var posts = ModelActions.GetPostsDtos();
            var subdivisions = ModelActions.GetSubdivisionsDtos();

            PhisicalFaceEdit.Properties.DataSource = phisicals;            
            PostEdit.Properties.DataSource = posts;
            SubdivisionEdit.Properties.DataSource = subdivisions;
            DtoMapToForm();
        }

        public Employee FormMapToModel()
        {
            var res = new Employee();
            if(Dto != null)
            {
                res.Id = Dto.Id;
            }
            res.PhisicalFaceId = ((PhisicalFaceDto) PhisicalFaceEdit.EditValue).Id;
            res.PostId = ((PostDto)PostEdit.EditValue).Id;
            res.SubdivisionId = ((SubdivisionDto)SubdivisionEdit.EditValue).Id;
            return res;
        }

        public void DtoMapToForm()
        {
            if(Dto != null)
            {
                var PhisicalFaceEditData = (ICollection<PhisicalFaceDto>)PhisicalFaceEdit.Properties.DataSource;
                if (!PhisicalFaceEditData.Select(c => c.Id).Contains(Dto.PhisicalFaceId))
                    PhisicalFaceEditData.Add(Dto.PhisicalFace);
                PhisicalFaceEdit.EditValue = PhisicalFaceEditData.Select((elem, index) => new { elem, index })
                        .First(p => p.elem.Id == Dto.PhisicalFaceId)
                        .elem;

                var PostEditData = (ICollection<PostDto>)PostEdit.Properties.DataSource;
                if (!PostEditData.Select(c => c.Id).Contains(Dto.PostId))
                    PostEditData.Add(Dto.Post);
                PostEdit.EditValue = PostEditData.Select((elem, index) => new { elem, index })
                        .First(p => p.elem.Id == Dto.PostId)
                        .elem;

                var SubdivisionEditData = (ICollection<SubdivisionDto>)SubdivisionEdit.Properties.DataSource;
                if (!SubdivisionEditData.Select(c => c.Id).Contains(Dto.SubdivisionId))
                    SubdivisionEditData.Add(Dto.Subdivision);
                SubdivisionEdit.EditValue = SubdivisionEditData.Select((elem, index) => new { elem, index })
                        .First(p => p.elem.Id == Dto.SubdivisionId)
                        .elem;

                PhisicalFaceEdit.RefreshEditValue();
                PostEdit.RefreshEditValue();
                SubdivisionEdit.RefreshEditValue();
            }
        }

        public void NewAdd()
        {
            PhisicalFaceEdit.EditValue = null;
            PostEdit.EditValue = null;
            SubdivisionEdit.EditValue = null;
        }

    }
}