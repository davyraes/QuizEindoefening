using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuizEindoefening.Models.Quiz
{
    [Table("Vragen")]
    public class Vraag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titel { get; set; }
        [Required]
        public bool MeerkeuzeVraag { get; set; }
        [Required]
        public string Antwoord { get; set; }
        public string Meerkeuze1 { get; set; }
        public string Meerkeuze2 { get; set; }
        public string Meerkeuze3 { get; set; }
        public virtual ICollection<Categorie> Categoriën { get; set; }
        public virtual ICollection<Ronde> Rondes { get; set; }
        public int Moeilijkheidsgraad { get; set; }
    }
}