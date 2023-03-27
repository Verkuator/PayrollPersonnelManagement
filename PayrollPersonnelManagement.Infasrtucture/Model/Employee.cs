namespace PayrollPersonnelManagement.Common
{
    public class Employee
    {
        public int Id { get; set; }
        public int PhisicalFaceId { get; set; }
        public PhisicalFace PhisicalFace { get; set; }
        public Subdivision Subdivision { get; set; }
        public Post Post { get; set; }
    }
}
