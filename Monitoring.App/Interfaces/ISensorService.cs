using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.Interfaces
{
    public interface ISensorService
    {
        Task AddSensorAsync(Sensor sensor);
        Task<List<Sensor>> GetSensorsAsync();
        Task<Sensor> GetSensorByIdAsync(Guid id);
    }
}
