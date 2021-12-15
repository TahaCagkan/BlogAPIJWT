using BlogJWT.DAL.Concrete.EntityFrameworkCore.Mapping;
using BlogJWT.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogJWT.DAL.Concrete.EntityFrameworkCore.Context
{
    public class BlogJWTContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0TJT8G1; Database = BlogJWTDb; Integrated Security = True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new BlogMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CategoryBlogMap());
            modelBuilder.ApplyConfiguration(new CommentMap());

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryBlog> CategoryBlogs { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
