using BlogJWT.BLL.Abstract;
using BlogJWT.Core.DAL;
using BlogJWT.DAL.Concrete.EntityFrameworkCore.Context;
using BlogJWT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogJWT.BLL.Concrete
{
    public class CommentManager : GenericManager<Comment>, ICommonService
    {
        private readonly IGenericDal<Comment> _genericDal;
        public CommentManager(IGenericDal<Comment> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}