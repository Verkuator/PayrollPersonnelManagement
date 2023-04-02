using DevExpress.XtraBars;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using PayrollPersonnelManagement.Infasrtucture.Model;
using System;
using AutoMapper;
using System.Collections.Generic;
using PayrollPersonnelManagement.Aplication.Dto;
using PayrollPersonnelManagement.Common;

namespace PayrollPersonnelManagement.View
{
    public class BaseFormAdapter<M, D> : BaseForm 
        where M : class, IModel, new()
        where D : class, new()
    {
        
        private IController<M, D> Controller { get; set; }
        public BaseFormAdapter(IController<M, D> controller) : base()
        {
            Name = controller.Name;
            FormMenuCaption = controller.Name;
            Controller = controller;
            Edit.ItemClick += new ItemClickEventHandler(Edit_ItemClick);
            Delete.ItemClick += new ItemClickEventHandler(Delete_ItemClick);
            Add.ItemClick += new ItemClickEventHandler(Add_ItemClick);
            Load += new EventHandler(this.BaseForm_Load);
        }

        private void Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.OpenForm();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            var model = Controller.Get();
            if(model.Count == 0)
            {
                BaseDataGrid.DataSource = new D();
            }
            else
            {
                var dto = Controller.MapToDto(model);
                BaseDataGrid.DataSource = dto;
            }
            
        }

        private void Edit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Delete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

    }
}
