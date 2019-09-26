using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage="isminizi giriniz!")]
        public string Name { get; set; }

        [Required(ErrorMessage="Email adresiniz giriniz!")]
        [EmailAddress(ErrorMessage="Email adresinizi yanlış girdiniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage="Telefonunuzu giriniz!")]
        public string Phone { get; set; }

        [Required(ErrorMessage="Katılma durumunuzu giriniz!")]
        public bool? Confirm { get; set; } //true,false,null
    }

}