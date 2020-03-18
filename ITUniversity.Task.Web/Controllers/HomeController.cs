using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ITUniversity.Task.Web.Models;
using ITUniversity.Task.Stores;
using ITUniversity.Task.Entities;

namespace ITUniversity.Task.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        private readonly ITaskStore taskStore;

        public HomeController(ILogger<HomeController> logger, ITaskStore taskStore)
        {
            
            this.logger = logger;
            this.taskStore = taskStore;
        }

        public IActionResult Index()
        {
            var a = taskStore.Save(new TaskBase { Subject = "Hello", Description = "Hello world!"}); 
            return View();
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
