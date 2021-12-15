using BlogJWT.BLL.Abstract;
using BlogJWT.Core.DAL;
using BlogJWT.DAL.Concrete.EntityFrameworkCore.Context;
using BlogJWT.DTO.DTOs.AppUserDtos;
using BlogJWT.Entities.Concrete;
using System.Threading.Tasks;

namespace BlogJWT.BLL.Concrete
{
    public  class AppUserManager:GenericManager<AppUser>, IAppUserService
    {
        private readonly IGenericDal<AppUser> _genericDal;
        public AppUserManager(IGenericDal<AppUser> genericDal):base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto)
        {
            return await _genericDal.GetAsync(x => x.UserName == appUserLoginDto.UserName && x.Password == appUserLoginDto.Password);
        }

        public async Task<AppUser> FindByNameAsync(string username)
        {
            return await _genericDal.GetAsync(x => x.UserName == username);
        }
    }
}
