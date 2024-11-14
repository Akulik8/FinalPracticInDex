using Monitoring.App.Interfaces;
using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.Services
{
    public class SensorService : ISensorService
    {
        private readonly ISensorRepository _sensorRepository;

        public SensorService(ISensorRepository sensorRepository)
        {
            _sensorRepository = sensorRepository;
        }

        public async Task AddSensorAsync(Sensor sensor)
        {
            await _sensorRepository.AddAsync(sensor);
        }

        public async Task<List<Sensor>> GetSensorsAsync()
        {
            return await _sensorRepository.GetAllAsync();
        }

        public async Task<Sensor> GetSensorByIdAsync(Guid id)
        {
            return await _sensorRepository.GetByIdAsync(id);
        }
    }
}
