using BlogJWT.Core.DAL;
using BlogJWT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogJWT.DAL.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId);
    }
}
