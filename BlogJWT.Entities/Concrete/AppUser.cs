using BlogJWT.Core.Entity.Abstract;
using System.Collections.Generic;

namespace BlogJWT.Entities.Concrete
{
    public class AppUser : IBaseEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public virtual List<Blog> Blogs { get; set; }


    }
}
