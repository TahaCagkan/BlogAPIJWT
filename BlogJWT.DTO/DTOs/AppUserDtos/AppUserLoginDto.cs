using BlogJWT.DTO.Abstract;

namespace BlogJWT.DTO.DTOs.AppUserDtos
{
    public class AppUserLoginDto:IDtos
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
