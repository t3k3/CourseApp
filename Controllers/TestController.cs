using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{

    // localhost:5000/test
    public class TestController:Controller
    {
        // localhost:5000/test/index
        public string Index()
            {
                return "Test Controller";
            }
        
        //localhost:5000/test/test
        public string Test()
            {
                return "test/test";
            }
    }
}