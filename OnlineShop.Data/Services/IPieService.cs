using OnlineShop.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Data.Services
{
    public interface IPieService
    {
        Task<Pie> GetPieAsync(int pieId);

        Task<IEnumerable<Pie>> GetPiesAsync();

        Task<IEnumerable<Pie>> GetPiesOfTheWeekAsync();
    }
}
