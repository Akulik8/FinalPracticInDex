using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.Interfaces
{
    public interface INotificationService
    {
        Task SendNotificationAsync(Guid userId, string message);
        Task<List<Notification>> GetNotificationsByUserIdAsync(Guid userId);
        Task MarkAsReadAsync(Guid id);
        Task DeleteNotificationAsync(Guid id);
    }
}
