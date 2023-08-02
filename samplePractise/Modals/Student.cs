using System.ComponentModel.DataAnnotations;

namespace samplePractise.Modals
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Age { get; set; }
        public string City { get; set; }

        public virtual Group Group { get; set; }
    }
}
