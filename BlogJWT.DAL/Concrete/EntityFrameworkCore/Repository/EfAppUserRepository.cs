using BlogJWT.DAL.Abstract;
using BlogJWT.DAL.Concrete.EntityFrameworkCore.Context;
using BlogJWT.Entities.Concrete;


namespace BlogJWT.DAL.Concrete.EntityFrameworkCore.Repository
{
    public class EfAppUserRepository : EfGenericRepository<AppUser, BlogJWTContext>, IAppUserDal
    {
        private readonly BlogJWTContext context;
        public EfAppUserRepository(BlogJWTContext context) : base(context)
        {
            this.context = context;
        }
    }
}
