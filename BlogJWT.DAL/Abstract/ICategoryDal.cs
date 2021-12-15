using BlogJWT.Core.DAL;
using BlogJWT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogJWT.DAL.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}
