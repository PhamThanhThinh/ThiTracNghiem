using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ThiTracNghiem.Api.Data.Entities;
using ThiTracNghiem.Shared;

namespace ThiTracNghiem.Api.Data
{
  public class ThiTracNghiemDbContext : DbContext
  {
    private readonly IPasswordHasher<User> _passwordHasher;

    public ThiTracNghiemDbContext(DbContextOptions<ThiTracNghiemDbContext> options, IPasswordHasher<User> passwordHasher) : base(options)
    {
      // khai báo construct
      _passwordHasher = passwordHasher;
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Option> Options { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<StudentQuiz> StudentQuizzes { get; set; }
    public DbSet<User> Users { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);


      var adminUser = new User
      {
        Id = 1,
        Name = "Thinh Pham",
        Email = "codingwiththinh@gmail.com",
        Phone = "0866439504",
        Role = nameof(UserRole.Admin)
      };

      adminUser.PasswordHash = _passwordHasher.HashPassword(adminUser, "123456");

      modelBuilder.Entity<User>()
        .HasData(adminUser);

    }



  }
}
