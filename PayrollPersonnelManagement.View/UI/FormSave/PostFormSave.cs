﻿using PayrollPersonnelManagement.Aplication.Controlls;
using System;

namespace PayrollPersonnelManagement.View.UI.FormSave
{
    public partial class PostFormSave : FormAdapter
    {
        public PostFormSave()
        {
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

        public override void MapForm(object obj)
        {

        }
    }
}
