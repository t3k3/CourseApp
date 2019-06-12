using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    // localhost:5000 = home/index.cshtml
    // localhost:5000/home = home/index.cshtml
    public class HomeController:Controller
    {
        // localhost:5000/home/index = home/index.cshtml
        public IActionResult Index() 
        {
            int saat = DateTime.Now.Hour;
            int dakika = DateTime.Now.Minute; 

            // if else Uzun Kullanım
            /* 
            if (saat > 12) 
            {
                ViewBag.Greeting = "İyi Günler";
            }
            else 
            {
                ViewBag.Greeting = "Günaydın";
            }
            */

            // if else Kısa Kullanım
            // Greeting isimi değişken oluşturduk saat değerine göre 
            // değişkenimize değer atadık.
            ViewBag.Greeting = saat > 12 ? "İyi günler" : "Günaydın";
           
            // Viewbag Controller'dan View'a değişken gönderir.
            // Viewbah classından UserName değişkeni oluşturup view'da görüntüledik.
            ViewBag.UserName = "Ahmet";

            ViewBag.Zaman = saat + " : " + dakika;
            

            return View();
        }

        // localhost:5000/home/about => home/about.cshtml
        public IActionResult About() 
        {
            return View();
        }
    }
}