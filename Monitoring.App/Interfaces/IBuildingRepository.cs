using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.App.Interfaces
{
    public interface IBuildingRepository
    {
        Task AddAsync(Building building);
        Task<List<Building>> GetAllAsync();
        Task<Building> GetByIdAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Building building);
    }

}
