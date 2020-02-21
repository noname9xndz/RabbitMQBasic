using Micro.GlobalConfig.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Micro.GlobalConfig.Domain.Interfaces
{
    public interface IGlobalConfigRepository
    {
        IQueryable<GlobalConfigModel> GetAllGlobalConfig();

        Task AddGlobalConfig(GlobalConfigModel globalConfig);

        Task UpdateGlobalConfig(GlobalConfigModel globalConfig);

        Task<GlobalConfigModel> GetGlobalConfigByName(string nameConfig);
    }
}