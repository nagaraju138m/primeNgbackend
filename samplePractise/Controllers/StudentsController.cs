using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using samplePractise.Modals;

namespace samplePractise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentDbContext studentDbContext;

        public StudentsController(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }

        [HttpGet]
        [Route("GetStudents")]
        public List<Student> GetStudents()
        {
            return studentDbContext.Students.ToList();
        }

        [HttpGet]
        [Route("GetStudent")]
        public Student GetStudent(int id)
        {
            return studentDbContext.Students.Where( a => a.Id == id).FirstOrDefault();
        }

        [HttpPost] // Change the attribute to HttpPost
        [Route("AddStudent")]
        public string AddStudent([FromBody] Student student)
        {
            string response = string.Empty;
            studentDbContext.Students.Add(student);
            studentDbContext.SaveChanges();
            return "Student Added";
        }

        [HttpPut]
        [Route("UpdateStudent")]
        public string UpdateStudent(Student student)
        {
            studentDbContext.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            studentDbContext.SaveChanges();
            return "Student Modified";
        }

        [HttpDelete]
        [Route("DeleteStudent")]
        public string DeleteStudent(int id)
        {
            Student student = studentDbContext.Students.Where( a=>  a.Id == id).FirstOrDefault();
            studentDbContext.Students.Remove(student);
            studentDbContext.SaveChanges();
            return "Student Deleted";
        }
    }
}
