using PayrollPersonnelManagement.Infasrtucture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.View.FormSave
{
    public interface IFormSave<M>
        where M : class, IModel
    {
        M FormMapToModel();
        void DtoMapToForm();
    }
}
