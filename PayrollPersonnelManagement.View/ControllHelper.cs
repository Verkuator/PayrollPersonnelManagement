using AutoMapper;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Controlls;
using PayrollPersonnelManagement.View.FormSave;

namespace PayrollPersonnelManagement.Infasrtucture.Controll
{
    public static class ControllHelper
    {
        public static PhisicalFaceControll PhisicalFaceControll { get; set; }
        public static EmployeeControll EmployeeControll { get; set; }
        public static OneAccrualControll OneAccrualControll { get; set; }
        public static PostControll PostControll { get; set; }
        public static SubdivisionControll SubdivisionControll { get; set; }

        public static EmploeeFormSave EmploeeFormSave { get; set; }
        public static PhisicalFaceFormSave PhisicalFaceFormSave { get; set; }
        public static OneAccrualFormSave OneAccrualFormSave { get; set; }
        public static PostFormSave PostFormSave { get; set; }
        public static SubdivisionFormSave SubdivisionFormSave { get; set; }

        public static void Initialize(PayrollPersonnelManagementContext dbContext, IMapper mapper)
        {      
            EmployeeControll = new EmployeeControll(dbContext, dbContext.Employees, mapper);
            PhisicalFaceControll = new PhisicalFaceControll(dbContext, dbContext.PhisicalFaces, mapper);
            OneAccrualControll = new OneAccrualControll(dbContext, dbContext.OneAccrual, mapper);
            PostControll = new PostControll(dbContext, dbContext.Posts, mapper);
            SubdivisionControll = new SubdivisionControll(dbContext, dbContext.Subdivisions, mapper);

            EmploeeFormSave = new EmploeeFormSave(EmployeeControll);
            PhisicalFaceFormSave = new PhisicalFaceFormSave(PhisicalFaceControll);
            OneAccrualFormSave = new OneAccrualFormSave(OneAccrualControll);
            PostFormSave = new PostFormSave(PostControll);
            SubdivisionFormSave = new SubdivisionFormSave(SubdivisionControll);

        }

    }
}
