using System.Security.Claims;
using System.Text;
using Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Utils;

public static class Authentications {
    public static void ConfigAuthentication(this WebApplicationBuilder builder) {
        var configuration = builder.Configuration;
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = configuration["Jwt:ValidIssuer"],
                ValidAudience = configuration["Jwt:ValidAudience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Secret"]))
            };
        });
    }
    public static UserEntity CheckCurrentuser(this ControllerBase controllerBase) {
        try
        {
            var identity = controllerBase.HttpContext.User.Identities.First();
            if(identity == null) return null;
            var userClaims = identity.Claims;
            var user = new UserEntity() {
                Name = userClaims.First(x => x.Type == ClaimTypes.Name)?.Value,
                Email = userClaims.First(x => x.Type == ClaimTypes.Email)?.Value,
                PassWord = userClaims.First(x => x.Type == ClaimTypes.Upn)?.Value,
            };
            return user;
        }
        catch (System.Exception)
        {
            return null;
        }
    }
}