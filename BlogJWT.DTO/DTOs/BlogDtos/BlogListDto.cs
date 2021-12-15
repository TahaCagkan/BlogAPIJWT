using BlogJWT.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogJWT.DTO.DTOs.BlogDtos
{
   public  class BlogListDto: IDtos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime PostedTime { get; set; }

    }
}
