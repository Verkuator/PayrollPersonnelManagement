using DevExpress.XtraBars;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using PayrollPersonnelManagement.Infasrtucture.Model;
using System;

namespace PayrollPersonnelManagement.View
{
    public class BaseFormAdapter<M, D> : BaseForm 
        where M : class, IModel
        where D : class
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
            var dto = Controller.MapToDto(model);
            BaseDataGrid.DataSource = dto;
        }

        private void Edit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Delete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

    }
}
