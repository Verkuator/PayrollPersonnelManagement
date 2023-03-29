using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public interface IController<T>
    {
        string Name { get; set; }
        ICollection<T> Get();
        T Save(T obj);
        void Delete(T obj);
        void OpenForm();
    }
}
