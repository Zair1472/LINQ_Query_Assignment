using System.ComponentModel.DataAnnotations;

namespace ClassTask.Model
{
    public class Student
    {
        [Key]
        public int sid { get; set; }
        [Required]
        public string sname { get; set; }
        [Required]
        public string major { get; set; }
        [Required]

        public string standing { get; set; }
        [Required]
        public int Age { get; set; }

        public int Classcid { get; set; }
        public Class Class { get; set; }


        public IList<Enrollment> Enrollments { get; set; }

    }


}
