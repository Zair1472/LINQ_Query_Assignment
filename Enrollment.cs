using System.ComponentModel.DataAnnotations;
namespace ClassTask.Model
{
    public class Enrollment
    {
        [Required]
        public int Studentsid { get; set; }
        public Student Student { get; set; }

        public int Classcid { get; set; }
        public Class Class { get; set; }

        public int Facultyfid { get; set; }
        public Faculty Faculty{ get; set; }
    }
}
