using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    // localhost:5000/course => course/index.cshtml
    public class CourseController:Controller
    {
        // action method
        // localhost:5000/course/index => course/index.cshtml
        public IActionResult Index() 
        {
            return View();
        }

        // localhost: 5000/course/list => course/apply.cshtml
        public IActionResult Apply()
        {
          return View();
        }

        // localhost: 5000/course/list => course/list.cshtml
        public IActionResult List() 
        {
            return View();
        }

        public IActionResult Details()
        {
            var course = new Course();
            course.Name = "Core Mvc Kursu";
            course.description = "güzel bir kurs";
            course.isPublished = true;
            
            return View(course);
        }
    }
}