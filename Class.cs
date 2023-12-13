using System.ComponentModel.DataAnnotations;
namespace ClassTask.Model

{
    public class Class
    {
        [Key]
        public int cid { get; set; }
        [Required]
        public string cname { get; set; }
        [Required]
        public int room_number { get; set; }

        public int NumberOfStudents { get; set; }

        public int TeacherDepartment { get; set; }

        public int Studentsid { get; set; }
        public Student Student { get; set; }

        public int Facultyfid { get; set; }
        public Faculty Faculty { get; set; }


        public IList<Enrollment> Enrollments { get; set; }


    }
}
