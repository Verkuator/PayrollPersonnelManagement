using PayrollPersonnelManagement.Infasrtucture.Model;
using System.Collections.Generic;

namespace PayrollPersonnelManagement.Common
{
    public class Employee : IModel
    {
        public int Id { get; set; }
        public int PhisicalFaceId { get; set; }
        public PhisicalFace PhisicalFace { get; set; }
        public int SubdivisionId { get; set; }
        public Subdivision Subdivision { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public ICollection<OneAccrual> OneAccrual { get; set; }
    }
}
