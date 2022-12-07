using System.ComponentModel.DataAnnotations.Schema;

namespace MVCContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; } = String.Empty;   
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
