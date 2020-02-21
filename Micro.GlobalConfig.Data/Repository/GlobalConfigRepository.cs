using Micro.GlobalConfig.Data.Context;
using Micro.GlobalConfig.Domain.Interfaces;
using Micro.GlobalConfig.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Micro.GlobalConfig.Data.Repository
{
    public class GlobalConfigRepository : IGlobalConfigRepository
    {
        private readonly GlobalConfigDbContext _globalConfigDbContextDbContext;

        public GlobalConfigRepository(GlobalConfigDbContext globalConfigDbContextDbContext)
        {
            _globalConfigDbContextDbContext = globalConfigDbContextDbContext;
        }

        public IQueryable<GlobalConfigModel> GetAllGlobalConfig()
        {
            return _globalConfigDbContextDbContext.GlobalConfig;
        }

        public async Task AddGlobalConfig(GlobalConfigModel globalConfig)
        {
            await _globalConfigDbContextDbContext.GlobalConfig.AddAsync(globalConfig);
            await _globalConfigDbContextDbContext.SaveChangesAsync();
        }

        public async Task UpdateGlobalConfig(GlobalConfigModel globalConfig)
        {
            _globalConfigDbContextDbContext.GlobalConfig.Update(globalConfig);
            await _globalConfigDbContextDbContext.SaveChangesAsync();
        }

        public async Task<GlobalConfigModel> GetGlobalConfigByName(string nameConfig)
        {
            var config = await _globalConfigDbContextDbContext.GlobalConfig.FirstAsync(x => x.Name == nameConfig);
            await _globalConfigDbContextDbContext.DisposeAsync();
            return config;
        }
    }
}