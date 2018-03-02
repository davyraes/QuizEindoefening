using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuizEindoefening.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuizEindoefening.Models.Quiz
{
    [Table("Quizzen")]
    public class Quiz
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titel { get; set; }
        [Column(TypeName ="date")]
        public DateTime Datum { get; set; }
        [Required]
        public virtual ICollection<Ronde> Rondes { get; set; }
        [Required]
        public virtual ApplicationUser Beheerder{ get; set; }
        [Required]
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Categorie> Categoriën { get; set; }
        public int? AantalPauzes { get; set; }
        public TimeSpan DuurPauze { get; set; }
    }
}