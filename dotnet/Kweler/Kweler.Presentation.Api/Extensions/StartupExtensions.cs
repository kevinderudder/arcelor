using Kweler.Data.Repositories;
using Kweler.Data.Repositories.Songs;
using Kweler.Domain.Models.Songs;
using Kweler.Domain.Services.Songs;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kweler.Presentation.Api
{
    public static class StartupExtensions
    {
        public static void RegisterServices(this IServiceCollection services) {
            services.AddTransient<IRepository<Song>, SongsRepository>();
            services.AddTransient<ISongsService, SongsService>();
        }

        public static void ConfigureCors(this IServiceCollection services) {
            services.AddCors(options => {
                options.AddPolicy("CorsPolicy", bobTheCorsBuilder =>
                {
                    bobTheCorsBuilder.AllowAnyOrigin()
                                     .AllowAnyMethod()
                                     .AllowAnyHeader()
                                     .AllowCredentials();
                });
            });
        }
    }
}
