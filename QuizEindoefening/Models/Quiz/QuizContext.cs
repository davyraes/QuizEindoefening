using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace QuizEindoefening.Models.Quiz
{
    public class QuizContext:DbContext
    {
        public DbSet<Quiz> Quizzen { get; set; }
        public DbSet<Ronde> Rondes { get; set; }
        public DbSet<Vraag> Vragen { get; set; }
        public DbSet<Categorie> Categoriën { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}