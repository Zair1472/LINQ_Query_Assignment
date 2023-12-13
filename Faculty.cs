using System.ComponentModel.DataAnnotations;
namespace ClassTask.Model
{
    public class Faculty
    {
        [Key]
        public int fid { get; set; }
        [Required]
        public string fname { get; set; }
        [Required]
        public int deptid { get; set; }
        public string Department { get; set; }
        [Required]
        public string standing { get; set; }
        public int Classcid { get; set; }
        public Class Class { get; set; }

        public IList<Enrollment> Enrollments { get; set; }
    }
}
