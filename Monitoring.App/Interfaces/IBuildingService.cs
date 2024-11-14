using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.Interfaces
{
    public interface IBuildingService
    {
        Task AddBuildingAsync(Building building);
        Task<List<Building>> GetBuildingsAsync();
        Task<Building> GetBuildingByIdAsync(Guid id);
    }
}
