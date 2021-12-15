using BlogJWT.DAL.Abstract;
using BlogJWT.DAL.Concrete.EntityFrameworkCore.Context;
using BlogJWT.Entities.Concrete;

namespace BlogJWT.DAL.Concrete.EntityFrameworkCore.Repository
{
    public class EfCommentRepostitory : EfGenericRepository<Comment, BlogJWTContext>, ICommentDal
    {
        private readonly BlogJWTContext context;
        public EfCommentRepostitory(BlogJWTContext context) : base(context)
        {
            this.context = context;
        }
    }
}