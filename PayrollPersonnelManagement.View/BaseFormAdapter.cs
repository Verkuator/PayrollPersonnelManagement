using DevExpress.XtraBars;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using PayrollPersonnelManagement.Infasrtucture.Model;
using System;
using AutoMapper;
using System.Collections.Generic;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.View
{
    public class BaseFormAdapter<M, D> : BaseForm 
        where M : class, IModel, new()
        where D : class, new()
    {
        
        private ModelActions<M, D> ModelActions { get; set; }
        private Form _form;
        public BaseFormAdapter(ModelActions<M, D> modelActions, Form form) : base()
        {
            Name = modelActions.Name;
            FormMenuCaption = modelActions.Name;
            ModelActions = modelActions;
            Edit.ItemClick += new ItemClickEventHandler(Edit_ItemClick);
            Delete.ItemClick += new ItemClickEventHandler(Delete_ItemClick);
            Add.ItemClick += new ItemClickEventHandler(Add_ItemClick);
            Load += new EventHandler(this.BaseForm_Load);
            _form = form;
        }

        private void Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            _form.ShowDialog();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            var model = ModelActions.Get();
            if(model.Count == 0)
            {
                BaseDataGrid.DataSource = new D();
            }
            else
            {
                var dto = ModelActions.MapToDto(model);
                BaseDataGrid.DataSource = dto;
            }
            
        }

        private void Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            _form.ShowDialog();
        }

        private void Delete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

    }
}
