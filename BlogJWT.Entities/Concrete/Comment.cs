using BlogJWT.Core.Entity.Abstract;
using System;
using System.Collections.Generic;


namespace BlogJWT.Entities.Concrete
{
    public class Comment: IBaseEntity
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Description { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;

        public int? ParentCommentId { get; set; }
        public virtual Comment ParentComment { get; set; }
        public virtual List<Comment> SubComments { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
