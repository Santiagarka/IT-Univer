using Microsoft.AspNetCore.Mvc;

using ITUniversity.Task.Managers;
using ITUniversity.Task.Entities;

namespace ITUniversity.Task.Web.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskManager taskManager;

        public TaskController(ITaskManager taskManager)
        {
            this.taskManager = taskManager;
        }
        public IActionResult Index()
        {
            var tasks = taskManager.GetAll();
            return View(tasks);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new TaskBase());
        }
    }
}