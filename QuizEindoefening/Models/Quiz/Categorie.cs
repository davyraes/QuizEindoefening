using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuizEindoefening.Models.Quiz
{
    [Table("Categoriën")]
     public class Categorie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }
    }
}