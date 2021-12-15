using BlogJWT.DAL.Concrete.EntityFrameworkCore.Context;
using BlogJWT.DTO.DTOs.AppUserDtos;
using BlogJWT.Entities.Concrete;
using System.Threading.Tasks;

namespace BlogJWT.BLL.Abstract
{
    public interface IAppUserService:IGenericService<AppUser>
    {
        Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto);
        Task<AppUser> FindByNameAsync(string username);
    }
}
