using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuizEindoefening.Models.Quiz
{
    [Table("Rondes")]
    public class Ronde
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titel { get; set; }
        public virtual ICollection<Vraag> Vragen { get; set; }
        public virtual ICollection<Categorie> Categoriën { get; set; }
        public virtual ICollection<Quiz> Quizzen { get; set; }
    }
}