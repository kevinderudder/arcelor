using Microsoft.Extensions.DependencyInjection;
using MyFirstProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class StartupExtensions
    {
        public static void RegisterServices(this IServiceCollection services) {
            services.AddTransient<ICalculatorService, CalculatorService>();
            services.AddTransient<IWageService, WageService>();
        }
    }
}
