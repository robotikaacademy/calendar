using Microsoft.EntityFrameworkCore;
using calendar.Model.Models;

namespace calendar.Model{

    public class Context : DbContext
    {
        public Context():base(){}
 
        public DbSet<tab_course> tab_course { get; set; }
        public DbSet<tab_teacher> tab_teacher { get; set; }
        public DbSet<tab_user> tab_user { get; set; }
        public DbSet<tab_user> tab_event { get; set; }
        public DbSet<tab_event_teacher> tab_event_teacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=Calendar; Integrated Security=true;");
        }

    }

}