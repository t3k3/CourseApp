using System.Collections.Generic;

namespace CourseApp.Models
{
    //Bir örnek(nesne) oluşturmayacağımız Repository sınıfını tanımlıyoruz.
    //static anahtar kelimesiyle tanımlamamızın nedeni Classın sadece bilgi
    //bilgi tutması, örnek oluşturmayacak olmamızdır.
    public static class Repository
    {
        //Sadece bu classa özgü(private) "_student" adında "Student" classının
        //bilgilerini içerecek bir List<> listesi oluşturuyoruz.  
        private static List<Student> _students = new List<Student>();

        //Repository.Students komutu ile statik Student bilgilerini
        //döndürecek.

        public static List<Student> Students
        {
            //Classın Students metodu çağırıldığında
            //"Repository.Students" bize "_students"
            //bilgilerini return edecek.
            get
            {
                return _students;
            }
        }

        /*Listeye eleman eklemek için "public" erişim belirleyicisinde 
        "statik", geri değer döndürmeyeceği için "void" türünde bir
        "AddStudent" fonksiyou tanımlıyoruz. Parametre olarak "Student"
        türünde "student" nesnesini alıyor.*/
        public static void AddStudent(Student student)
        {
            _students.Add(student);
        }

    }
}