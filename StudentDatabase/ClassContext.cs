using Microsoft.EntityFrameworkCore;
using System;

namespace StudentDatabase
{
    class ClassContext : DbContext
    {
        public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ClassroomLab;Integrated Security=SSPI;");
        }
        public void DisplayAIIDB()
        {
            foreach (Student s in students)
            {
                Console.WriteLine($"{s.StudentId}: {s.Name}");
            }
        }
    }
}
