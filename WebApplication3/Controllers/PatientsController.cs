using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PatientsController : Controller
    {
        public IActionResult Index()
        {

            
            Patient p1 = new Patient()
            {
                PatientId = 1,
                name = "test_name_1"
            };
            Patient p2 = new Patient()
            {
                PatientId = 2,
                name = "test_name_2"
            };
            Patient p3 = new Patient()
            {
                PatientId = 3,
                name = "test_name_3"
            };
            Patient p4 = new Patient()
            {
                PatientId = 4,
                name = "test_name_4"
            };
            Patient p5 = new Patient()
            {
                PatientId = 5,
                name = "test_name_5"
            };
            List<Patient> patients = new List<Patient>()
            {
                p1,p2,p3,p4,p5
            };

            return View(patients);
        }

        public IActionResult CreatePatient()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreatePatient(Patient p)
        {
            return RedirectToAction("Index");
        }
    }
}
