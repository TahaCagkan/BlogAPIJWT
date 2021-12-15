using BlogJWT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogJWT.BLL.Tools.JWTTool
{
    public interface IJwtService
    {
        JwtToken GenerateJwt(AppUser appUser);
    }
}
