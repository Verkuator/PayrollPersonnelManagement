using DevExpress.Data.ODataLinq.Helpers;
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
            var model = FormMapToModel();
            ModelActions.Save(model);
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
                PhisicalFaceEdit.EditValue = Dto.PhisicalFaceDto;
                PostEdit.EditValue = Dto.PostDto;
                SubdivisionEdit.EditValue = Dto.SubdivisionDto;
            }
        }
    }
}