using OnlineShop.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Data.Services
{
    public interface IBannerService
    {
        Task<Banner> GetBannerAsync(int bannerId);

        Task<IEnumerable<Banner>> GetBannersAsync();
    }
}
