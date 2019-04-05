using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kweler.Presentation.Api.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Kweler.Presentation.Api.Config;

namespace Kweler.Presentation.Api.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _config;
        private IOptions<ArcelorSettings> _arcelorSettings;

        public HomeController(IConfiguration conf, IOptions<ArcelorSettings> options)
        {
            this._config = conf;
            this._arcelorSettings = options;
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel();
            vm.Version = this._arcelorSettings.Value.Version;
            vm.Url = this._arcelorSettings.Value.Url;
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
