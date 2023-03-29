using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using PayrollPersonnelManagement.View.UI.FormSave;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public static class ControllHelper
    {
        public static PhisicalFaceControll PhisicalFaceControll { get; set; }
        public static EmployeeControll EmployeeControll { get; set; }
        public static OneAccrualControll OneAccrualControll { get; set; }
        public static PostControll PostControll { get; set; }
        public static SubdivisionControll SubdivisionControll { get; set; }

        public static void Initialize(PayrollPersonnelManagementContext dbContext)
        {
            PhisicalFaceControll = new PhisicalFaceControll(dbContext, new PhisicalFaceFormSave());
            EmployeeControll = new EmployeeControll(dbContext);
            OneAccrualControll = new OneAccrualControll(dbContext);
            PostControll = new PostControll(dbContext);
            SubdivisionControll = new SubdivisionControll(dbContext);
        }       

    }
}
