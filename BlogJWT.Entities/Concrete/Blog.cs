using BlogJWT.Core.Entity.Abstract;
using System;
using System.Collections.Generic;

namespace BlogJWT.Entities.Concrete
{
    public class Blog: IBaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;

        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual List<CategoryBlog> CategoryBlogs { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
