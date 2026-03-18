using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {

            Student s1 = new Student()
            {
                RollNo = 1,
                Name = "Student_Name_1",
                ClassName=1
            };
            Student s2 = new Student()
            {
                RollNo = 2,
                Name = "Student_Name_2",
                ClassName=1
            };
            Student s3 = new Student()
            {
                RollNo = 3,
                Name = "Student_Name_3",
                ClassName=2
            };
            Student s4 = new Student()
            {
                RollNo = 4,
                Name = "Student_Name_4",
                ClassName=3
            };
            Student s5 = new Student()
            {
                RollNo = 5,
                Name = "Student_Name_5",
                ClassName=4
            };

            List<Student> students = new List<Student>()
            {
                s1,s2,s3,s4,s5
            };

            return View(students);
        }
    }
}
