using Core.Entities;
using Core.Interfaces;
using Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MarksRepository : Repository<Marks>, IMarksRepository
    {
        private readonly SchoolDBContext _context;

        public MarksRepository(SchoolDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Marks?> GetByIdAsync(int id)
        {
            return await _context.Marks.FindAsync(id);
        }

        public async Task<IEnumerable<Marks>> GetAllAsync()
        {
            return await _context.Marks.ToListAsync();
        }

        public async Task<IEnumerable<Marks>> GetMarksByTeacherIdAsync(int teacherId)
        {
            return await _context.Marks
                .Where(m => m.TeacherID == teacherId)
                .ToListAsync();
        }
        public async Task<IEnumerable<Marks>> GetMarksByStudentIdAsync(int studentid)
        {
            return await _context.Marks
                .Where(m => m.StudentID == studentid)
                .ToListAsync();
        }

        public async Task AddAsync(Marks marks)
        {
            await _context.Marks.AddAsync(marks);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Marks marks)
        {
            _context.Marks.Update(marks);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var marks = await _context.Marks.FindAsync(id);
            if (marks != null)
            {
                _context.Marks.Remove(marks);
                await _context.SaveChangesAsync();
            }
        }
    }
}
