using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITUniversity.Task.Managers;
using ITUniversity.Task.Stores;
using ITUniversity.Tasks.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace ITUniversity.Task.Web
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTaskCoreServices(this IServiceCollection services)
        {
            services.AddSingleton<ITaskStore, TaskMemoryStore>();
            services.AddTransient<ITaskManager, TaskManager>();

            return services;
        }
    }
}
