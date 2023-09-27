using Microsoft.EntityFrameworkCore;
using SweeftEntityFramoworkApp.Db;
using SweeftEntityFramoworkApp.Repository;

internal class Program
{

    private static void Main(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>()
        .UseSqlServer("Server=LocalHost;Database=School_db;Trusted_Connection=true;MultipleActiveResultSets=True;Encrypt=False;")
        .Options;

        using var db = new AppDbContext(optionsBuilder);

        var teacherRepository = new TeacherRepository(db);

        var teachers = teacherRepository.GetAllTeachersByStudent("Giorgi");

        Console.WriteLine("Teachers who teach Giorgi:");

        foreach (var teacher in teachers)
        {
            Console.WriteLine($"Teacher: {teacher.FirstName} {teacher.LastName}, Subject: {teacher.Subject}");
        }
    }
}