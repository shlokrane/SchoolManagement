using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByEmailAndPasswordAsync(string email, string password);

        Task<IEnumerable<User>> GetAllStudentsAsync();

    }
}
