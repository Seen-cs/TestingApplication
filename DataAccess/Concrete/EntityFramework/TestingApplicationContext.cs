using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DataAccess
{
    public class TestingApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-TOT4JFM;Database=TestingApplication;Trusted_Connection=true");
            
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StudentAnswer> StudentsAnswers { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<QuestionToAdd> QuestionToAdds { get; set; }

    }
}
