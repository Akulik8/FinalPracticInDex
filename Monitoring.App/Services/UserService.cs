using Monitoring.App.Interfaces;
using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddUserAsync(User user)
        {
            await _userRepository.AddAsync(user);
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }
    }

}
