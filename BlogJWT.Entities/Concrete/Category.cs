using BlogJWT.Core.Entity.Abstract;
using System.Collections.Generic;

namespace BlogJWT.Entities.Concrete
{
    public class Category: IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<CategoryBlog> CategoryBlogs { get; set; }

    }
}
