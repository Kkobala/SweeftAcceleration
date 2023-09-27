using SweeftEntityFramoworkApp.Db;
using SweeftEntityFramoworkApp.Models;
using SweeftEntityFramoworkApp.Repositories;

namespace SweeftEntityFramoworkApp.Repository
{
    public class TeacherRepository
    {
        private readonly AppDbContext _db;

        public TeacherRepository(AppDbContext db)
        {
            _db = db;
        }

        public Teachers[] GetAllTeachersByStudent(string studentName)
        {
            var teachers = _db.Teachers
                   .Where(t => t.Pupils.Any(p => p.FirstName == studentName))
                   .ToArray();

            return teachers;
        }
    }
}
