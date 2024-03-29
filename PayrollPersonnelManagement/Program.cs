﻿using PayrollPersonnelManagement.Aplication.AutotMapper;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.CreateSQLite;
using PayrollPersonnelManagement.Infasrtucture.Controll;
using PayrollPersonnelManagement.View;
using System;
using System.Windows.Forms;

namespace PayrollPersonnelManagement
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLiteCreateDb.CreateSQLite();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ControllHelper.Initialize(new PayrollPersonnelManagementContext(), MappConfiguration.GetMapper());
            Application.Run(new Main());
        }
    }
}
