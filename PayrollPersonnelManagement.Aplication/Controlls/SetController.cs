using PayrollPersonnelManagement.Infasrtucture.Controlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Aplication.Controlls
{
    public class SetController
    {
        //private IController<T> Controller { get; set; }

        //public SetController(IController controller)
        //{
        //    Controller = controller;
        //}

        public IController<T> Get<T>()
        {
            var res = this.Get<T>();
            return res;
        }
    }
}
