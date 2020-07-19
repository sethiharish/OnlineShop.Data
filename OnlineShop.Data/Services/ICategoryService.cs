using OnlineShop.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Data.Services
{
    public interface ICategoryService
    {
        Task<Category> GetCategoryAsync(int categoryId);

        Task<IEnumerable<Category>> GetCategoriesAsync();
    }
}
