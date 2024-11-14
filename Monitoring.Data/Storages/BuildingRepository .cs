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
    public class BuildingRepository : IBuildingRepository
    {
        private readonly ApplicationDbContext _context;

        public BuildingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Building building)
        {
            await _context.Buildings.AddAsync(building);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Building>> GetAllAsync()
        {
            return await _context.Buildings.Include(b => b.Sensors).ToListAsync();
        }

        public async Task<Building> GetByIdAsync(Guid id)
        {
            return await _context.Buildings.Include(b => b.Sensors)
                                            .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task DeleteAsync(Guid id)
        {
            var building = await _context.Buildings.FindAsync(id);
            if (building != null)
            {
                _context.Buildings.Remove(building);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Building building)
        {
            _context.Buildings.Update(building);
            await _context.SaveChangesAsync();
        }
    }
}
