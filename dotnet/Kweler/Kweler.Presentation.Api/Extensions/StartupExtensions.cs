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
            services.AddTransient<ISongsService, SongsService>();
        }
    }
}
