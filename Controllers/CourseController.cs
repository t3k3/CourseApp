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

        // localhost:5000/course/apply => course/apply.cshtml

        /* [HttpGet] ile aşağıdaki Apply fonksiyonun GET metoduyla
        çalışacağını gösterir. Eğer method GET ise bu fonksiyon
        çalışacaktır. 
        Eğer fonksiyonların başına [HttpGet] veya [HttpPost]
        yazılmazsa default [HttpGet] olur.*/
        [HttpGet]
        public IActionResult Apply()
        {
          return View();
        }

        // localhost:5000/course/apply method : POST
        /*Aynı metoddan tekrar yazıyoruz ve bunu da POST metodu için
        ayarlıyoruz. Artık veri POST edildiğinde bu method çalışacak.
        Overloading yaparak metodu üzerineyükleme yapacağız.
        (Detay için "Polymorphism")
        Bu alana yapılan Request ile gelen bilgiler şu şekildedir;
        Name?value&Email=value&Phone=value&Confirm=value
        bilgileri methoda parametre olarak alalım*/
        //public IActionResult Apply(string Name, string Email, string Phone, bool Confirm)
        //Bu yapı yerine Apply methoduna(fonksiyon) Student sınıfından bir student isimli
        //obje de gönderebiliriz.
        [HttpPost]
        public IActionResult Apply(Student student)
        {
          //Model Binding
          Repository.AddStudent(student);
          return View("Thanks", student);
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