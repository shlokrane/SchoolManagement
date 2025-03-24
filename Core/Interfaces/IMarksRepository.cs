using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IMarksRepository: IRepository<Marks>
    {
        Task<Marks?> GetByIdAsync(int id);
        Task<IEnumerable<Marks>> GetAllAsync();
        Task<IEnumerable<Marks>> GetMarksByTeacherIdAsync(int teacherId);  // Renamed for consistency
        Task<IEnumerable<Marks>> GetMarksByStudentIdAsync(int studentid);
        Task AddAsync(Marks marks);
        Task UpdateAsync(Marks marks);
        Task DeleteAsync(int id);
    }
}