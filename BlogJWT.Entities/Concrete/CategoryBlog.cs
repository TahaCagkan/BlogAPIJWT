using BlogJWT.Core.Entity.Abstract;

namespace BlogJWT.Entities.Concrete
{
    public class CategoryBlog: IBaseEntity
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
