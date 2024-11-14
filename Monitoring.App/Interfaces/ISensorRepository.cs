using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.Interfaces
{
    public interface ISensorRepository
    {
        Task AddAsync(Sensor sensor);
        Task<List<Sensor>> GetAllAsync();
        Task<Sensor> GetByIdAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Sensor sensor);
    }

}
