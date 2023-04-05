using System.Windows.Forms;

namespace PayrollPersonnelManagement.View.FormSave
{
    public class FormAdapter<D> : Form
        where D : class
    {
        public virtual D Dto { get; set; }

        public virtual void SetDto(D dto)
        {
            Dto = dto;
        }

    }
}
