using Monitoring.App.Interfaces;
using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.Services
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;

        public NotificationService(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public async Task SendNotificationAsync(Guid userId, string message)
        {
            var notification = new Notification
            {
                Message = message,
                UserId = userId,
                CreatedAt = DateTime.UtcNow,
                IsRead = false
            };

            await _notificationRepository.AddAsync(notification);
        }

        public async Task<List<Notification>> GetNotificationsByUserIdAsync(Guid userId)
        {
            return await _notificationRepository.GetAllAsync();
        }

        public async Task MarkAsReadAsync(Guid id)
        {
            var notification = await _notificationRepository.GetByIdAsync(id);
            if (notification != null)
            {
                notification.IsRead = true;
                await _notificationRepository.UpdateAsync(notification);
            }
        }

        public async Task DeleteNotificationAsync(Guid id)
        {
            await _notificationRepository.DeleteAsync(id);
        }
    }
}
