using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuizEindoefening.Models.Quiz
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        public int Id { get; set; } 
        [Required]    
        public string Naam { get; set; }
        [Required]
        public virtual ApplicationUser Beheerder { get; set; }
        [Required]
        public virtual ICollection<ApplicationUser> Teamleden { get; set; }
        public virtual ICollection<Quiz> Quizzen { get; set; }
    }
}