using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.Interfaces
{
    public interface IUserService
    {
        Task AddUserAsync(User user);
        Task<User> GetUserByIdAsync(Guid id);
        Task<List<User>> GetUsersAsync();
    }
}
