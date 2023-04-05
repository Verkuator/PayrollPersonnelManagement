namespace PayrollPersonnelManagement.View
{
    public partial class BaseForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string FormMenuCaption
        {
            get
            {
                return this.BasePage.Text;
            }
            set
            {
                this.BasePage.Text = value;
                this.Text = value;
            }
        }
        public BaseForm()
        {
            InitializeComponent();
            ControlBox = false;
        }

        
    }
}