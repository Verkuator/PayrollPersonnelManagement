using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.Infasrtucture.Controll;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View.FormSave
{
    public partial class EmploeeFormSave : FormAdapter<EmployeeDto>
    {
        public EmployeeControll ModelActions { get; set; }
        public ICollection<EmployeeDto> _employeeDtos;

        public EmploeeFormSave(EmployeeControll modelActions)
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

        private void EmploeeFormSave_Load(object sender, EventArgs e)
        {
            var phisicals = ModelActions.GetPhisicalFaceDtos();
            var posts = ModelActions.GetPostsDtos();
            var subdivisions = ModelActions.GetSubdivisionsDtos();

            PhisicalFaceEdit.Properties.DataSource = phisicals;            
            PostEdit.Properties.DataSource = posts;
            SubdivisionEdit.Properties.DataSource = subdivisions;
        }
    }
}