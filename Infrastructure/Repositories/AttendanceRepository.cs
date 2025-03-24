using Core.Entities;
using Core.Interfaces;
using Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AttendanceRepository : Repository<Attendance>, IAttendanceRepository
    {
        private new readonly SchoolDBContext _context;

        public AttendanceRepository(SchoolDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Attendance>> GetAllAttendanceAsync()
        {
            return await _context.Attendance.ToListAsync();
        }

        public async Task<IEnumerable<Attendance>> GetAttendanceByStudentIdAsync(int studentId)
        {
            return await _context.Attendance
                .Where(a => a.StudentID == studentId)
                .ToListAsync();
        }

        public async Task AddAttendanceAsync(Attendance attendance)
        {
            _context.Attendance.Add(attendance);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAttendanceAsync(Attendance attendance)
        {
            _context.Attendance.Update(attendance);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAttendanceAsync(int attendanceId)
        {
            var attendance = await _context.Attendance.FindAsync(attendanceId);
            if (attendance != null)
            {
                _context.Attendance.Remove(attendance);
                await _context.SaveChangesAsync();
            }
        }

    }
}
