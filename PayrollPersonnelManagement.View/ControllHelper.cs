﻿using AutoMapper;
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

        public static void Initialize(PayrollPersonnelManagementContext dbContext, IMapper mapper)
        {
            PhisicalFaceControll = new PhisicalFaceControll(dbContext, new PhisicalFaceFormSave(), mapper);
            EmployeeControll = new EmployeeControll(dbContext, new EmploeeFormSave(), mapper);
            OneAccrualControll = new OneAccrualControll(dbContext, new OneAccrualFormSave(), mapper);
            PostControll = new PostControll(dbContext, new PostFormSave(), mapper);
            SubdivisionControll = new SubdivisionControll(dbContext, new SubdivisionFormSave(), mapper);
        }

    }
}
