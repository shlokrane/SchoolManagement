//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Core.Entities;
//using Core.Interfaces;
//using Microsoft.EntityFrameworkCore;

//namespace Core.Services
//{
//    public class AttendanceService
//    {
//        private readonly IAttendanceRepository _attendanceRepository;

//        public AttendanceService(IAttendnaceRepository attendnaceRepository)
//        {
//            _attendnaceRepository = marksRepository;
//        }

//        public async Task<Attendance?> GetMarksByIdAsync(int id)
//        {
//            return await _marksRepository.GetByIdAsync(id);
//        }

//        public async Task<IEnumerable<Marks>> GetMarksByTeacherIdAsync(int id)
//        {
//            return await _marksRepository.GetMarksByTeacherIdAsync(id);
//        }

//        public async Task<IEnumerable<Marks>> GetAllMarksAsync()
//        {
//            return await _marksRepository.GetAllAsync();
//        }

//        public async Task AddMarksAsync(Marks marks)
//        {
//            await _marksRepository.AddAsync(marks);
//        }

//        public async Task UpdateMarksAsync(Marks marks)
//        {
//            await _marksRepository.UpdateAsync(marks);
//        }

//        public async Task DeleteMarksAsync(int id)
//        {
//            await _marksRepository.DeleteAsync(id);
//        }

//        public async Task<bool> MarksExistsAsync(int id)
//        {
//            return await _marksRepository.GetByIdAsync(id) != null;
//        }
//        public async Task AddMultipleMarksAsync(IEnumerable<Marks> marksList)
//        {
//            foreach (var marks in marksList)
//            {
//                await _marksRepository.AddAsync(marks);
//            }
//        }
//        public async Task<IEnumerable<Marks>> GetMarksByStudentIdAsync(int studentid)
//        {
//            return await _marksRepository.GetMarksByStudentIdAsync(studentid);
//        }
//    }
//}
