using BlogJWT.BLL.Abstract;
using BlogJWT.Core.DAL;
using BlogJWT.DAL.Abstract;
using BlogJWT.DAL.Concrete.EntityFrameworkCore.Context;
using BlogJWT.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogJWT.BLL.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        private readonly IGenericDal<Category> _genericDal;
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(IGenericDal<Category> genericDal, ICategoryDal categoryDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _categoryDal = categoryDal;
        }

        public async Task<List<Category>> GetAllSortedByIdAsync()
        {
            return await _genericDal.GetAllAsync(x => x.Id);
        }

        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            return await _categoryDal.GetAllWithCategoryBlogsAsync();
        }
    }
}