using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User> GetByIdAsync(Guid id);
        Task<List<User>> GetAllAsync();
        Task DeleteAsync(Guid id);
        Task UpdateAsync(User user);
    }
}
