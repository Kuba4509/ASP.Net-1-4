using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab_3___app.Models
{

    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [HiddenInput]
        [Display(Name = "Data utworzenia")]
        public DateTime Created { get; set; }

        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength:50, ErrorMessage = "Zbyt długie imię, max 50 znaków!")]
        [Display(Name = "Imię:")]
        public string Name { get; set; }
        [EmailAddress]
        [Display(Name = "Email:")]
        public string Email { get; set; }
        [Display(Name = "Telefon:")]
        public string? Phone { get; set; }  //pola opcjonalne
        [Display(Name = "Data urodzenia:")]
        public DateTime? Birth { get; set; } //pola opcjonalne "?"
        [Display(Name = "Priorytet")] 
        public string Priority { get; set; }


    }
}
