using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{

    public class UserService
    {
        private readonly IUserRepository _UserRepository;

        public UserService(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _UserRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _UserRepository.GetAllAsync();
        }

        public async Task AddUserAsync(User User)
        {
            await _UserRepository.AddAsync(User);
        }

        public async Task UpdateUserAsync(User User)
        {
            await _UserRepository.UpdateAsync(User);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _UserRepository.DeleteAsync(id);
        }
        public async Task<bool> UserExistsAsync(int id)
        {
            return await _UserRepository.GetByIdAsync(id) != null;
        }

        public async Task<User?> AuthenticateUserAsync(string email, string password)
        {
            return await _UserRepository.FirstOrDefaultAsync(u => u.EmailID == email && u.PasswordHash == password);
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _UserRepository.AnyAsync(u => u.EmailID == email);
        }

        public async Task<IEnumerable<User>> GetAllStudentsAsync()
        {
            return await _UserRepository.GetAllStudentsAsync();
        }


    }

}
