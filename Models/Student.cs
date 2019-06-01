using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        //Adding Validation
        [Required(ErrorMessage="İsminizi Giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage="Mail Giriniz.")]
        [EmailAddress(ErrorMessage="Mail adresi formatı yanlış.")]
        public string Email { get; set; }

        [Required(ErrorMessage="Telefon Giriniz.")]
        public string Phone { get; set; }

        //bool? ile kullanıldığında ? nullable kullanılabilir anlamındadır.
        [Required(ErrorMessage="Kursa Katılım Alanı Zorunludur.")]
        public bool? Confirm { get; set; } //true, false , null
    }
}