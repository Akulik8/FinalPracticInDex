using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.Interfaces
{
    public interface INotificationRepository
    {
        Task AddAsync(Notification notification);
        Task<List<Notification>> GetAllAsync();
        Task<Notification> GetByIdAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Notification notification);
    }
}
