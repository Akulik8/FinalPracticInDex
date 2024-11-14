using Monitoring.App.Interfaces;
using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IBuildingRepository _buildingRepository;

        public BuildingService(IBuildingRepository buildingRepository)
        {
            _buildingRepository = buildingRepository;
        }

        public async Task AddBuildingAsync(Building building)
        {
            await _buildingRepository.AddAsync(building);
        }

        public async Task<List<Building>> GetBuildingsAsync()
        {
            return await _buildingRepository.GetAllAsync();
        }

        public async Task<Building> GetBuildingByIdAsync(Guid id)
        {
            return await _buildingRepository.GetByIdAsync(id);
        }
    }
}
