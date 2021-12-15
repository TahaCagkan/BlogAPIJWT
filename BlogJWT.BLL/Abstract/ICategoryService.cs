using BlogJWT.DAL.Concrete.EntityFrameworkCore.Context;
using BlogJWT.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogJWT.BLL.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<List<Category>> GetAllSortedByIdAsync();
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}
