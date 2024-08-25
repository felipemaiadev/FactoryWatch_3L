
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MaiaIO.FactoryWatch.API.Extensions
{
    public static class IdentityConfig
    {

        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services,
                                                                      IConfiguration configuration)
        {

            #region JWT_AppSettings

            var appSettingSession = configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingSession);

            var appSettings = appSettingSession.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.SecrectKey);


            services.AddAuthentication(x =>
            {

                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(opt =>
            {
                opt.RequireHttpsMetadata = true;
                opt.SaveToken = true;
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience =  appSettings.Audience,
                    ValidIssuer = appSettings.Issuer
                };
            });


            #endregion





            return services;

        }

    }
}
