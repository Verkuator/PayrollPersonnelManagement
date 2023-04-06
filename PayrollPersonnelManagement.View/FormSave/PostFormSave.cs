﻿using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View.FormSave
{
    public partial class PostFormSave : FormAdapter<PostDto>, IFormSave<Post>
    {
        public PostControll ModelActions { get; set; }
        public PostFormSave(PostControll modelActions)
        {
            ModelActions = modelActions;
            InitializeComponent();
        }

        public void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            //ControllHelper.PhisicalFaceControll.Save(new PhisicalFace());
        }

        public void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void DtoMapToForm()
        {
            throw new NotImplementedException();
        }

        public Post FormMapToModel()
        {
            throw new NotImplementedException();
        }

        public void NewAdd()
        {
            throw new NotImplementedException();
        }
    }
}
