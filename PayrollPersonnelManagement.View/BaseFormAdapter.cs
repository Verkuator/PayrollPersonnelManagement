using DevExpress.XtraBars;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using PayrollPersonnelManagement.Infasrtucture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.View
{
    public class BaseFormAdapter<T> : BaseForm where T : class, IModel
    {
        private IController<T> Controller { get; set; }
        public BaseFormAdapter(IController<T> controller) :base()
        {
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
            BaseDataGrid.DataSource = Controller.Get();
        }

        private void Edit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Delete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

    }
}
