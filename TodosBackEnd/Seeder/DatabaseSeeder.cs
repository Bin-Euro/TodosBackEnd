using Microsoft.EntityFrameworkCore;
using TodosBackEnd.Models;

namespace TodosBackEnd.Seeder
{
    public static class DatabaseSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(
                new Todo() { Id = 1, Name = "Nhiệm vụ 1", Iscomplete = false },
                new Todo() { Id = 2, Name = "Nhiệm vụ 2", Iscomplete = false }
                );
        }
    }
}
