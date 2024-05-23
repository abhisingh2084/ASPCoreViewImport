using ASPCoreViewImport.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreViewImport.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1,Name = "Abhishek", Gender = "male"},
                new Student { Id = 2,Name = "Ayush", Gender = "male"},
                new Student { Id = 3,Name = "Aryan", Gender = "male"},
            };

            return View(students);
        }
        public IActionResult About()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1,Name = "Abhishek", Gender = "male"},
                new Student { Id = 2,Name = "Ayush", Gender = "male"},
                new Student { Id = 3,Name = "Aryan", Gender = "male"},
            };
            return View(students);
        }
        public IActionResult Contact()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1,Name = "Abhishek", Gender = "male"},
                new Student { Id = 2,Name = "Ayush", Gender = "male"},
                new Student { Id = 3,Name = "Aryan", Gender = "male"},
            };
            return View(students);
        }
    }
}
