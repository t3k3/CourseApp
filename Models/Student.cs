namespace CourseApp.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //bool? ile kullanıldığında ? nullable kullanılabilir anlamındadır.
        public bool? Confirm { get; set; } //true, false , null
    }
}