using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.Aplication.Controlls;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public abstract class IController<T> where T: class, IModel
    {
        public abstract string Name { get; set; }
        public abstract FormAdapter FormAdapter { get; set; }
        protected abstract DbSet<T> DbSet { get; set; }
        protected abstract PayrollPersonnelManagementContext DbContext { get; set; }
        public virtual ICollection<T> Get()
        {
            var obj = DbSet.ToList();
            return obj;
        }
        public virtual T Save(T obj)
        {
            if (obj.Id == 0)
            {
                DbSet.Add(obj);
            }
            else
            {
                DbSet.Update(obj);
            }
            DbContext.SaveChanges();
            return obj;
        }
        public virtual void Delete(T obj)
        {
            DbSet.Remove(obj);
            DbContext.SaveChanges();
        }
        public virtual void OpenForm()
        {
            FormAdapter.ShowDialog();
        }
    }
}
