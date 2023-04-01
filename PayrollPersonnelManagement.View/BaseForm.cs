namespace PayrollPersonnelManagement.View
{
    public partial class BaseForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string TabName { get; set; }
        private bool UseTab { get; set; }
        public BaseForm()
        {
            InitializeComponent();
            ControlBox = false;
            UseTab = true;
        }

        public bool IsUseTab()
        {
            return UseTab;
        }


    }
}