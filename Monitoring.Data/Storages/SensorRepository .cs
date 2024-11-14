using Microsoft.EntityFrameworkCore;
using Monitoring.App.Interfaces;
using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.Data.Storages
{
    public class SensorRepository : ISensorRepository
    {
        private readonly ApplicationDbContext _context;

        public SensorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Sensor sensor)
        {
            await _context.Sensors.AddAsync(sensor);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Sensor>> GetAllAsync()
        {
            return await _context.Sensors.ToListAsync();
        }

        public async Task<Sensor> GetByIdAsync(Guid id)
        {
            return await _context.Sensors.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task DeleteAsync(Guid id)
        {
            var sensor = await _context.Sensors.FindAsync(id);
            if (sensor != null)
            {
                _context.Sensors.Remove(sensor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Sensor sensor)
        {
            _context.Sensors.Update(sensor);
            await _context.SaveChangesAsync();
        }
    }
}
