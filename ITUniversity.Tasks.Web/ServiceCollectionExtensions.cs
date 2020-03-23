using ITUniversity.AspNetCore;
using ITUniversity.Tasks.API;
using ITUniversity.Tasks.API.Services;
using ITUniversity.Tasks.API.Services.Imps;
using ITUniversity.Tasks.Managers;
using ITUniversity.Tasks.Stores;
using ITUniversity.Tasks.NHibernate;

using Microsoft.Extensions.DependencyInjection;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;
using NHibernate.Dialect;
using ITUniversity.Tasks.Repositories;
using ITUniversity.Tasks.NHibernate.Repositories;

namespace ITUniversity.Tasks.Web
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTaskCoreServices(this IServiceCollection services)
        {
            //services.AddSingleton<ITaskStore, TaskMemoryStore>();
            services.AddScoped<ITaskStore, TaskDbStore>();
            services.AddTransient<ITaskManager, TaskManager>();

            return services;
        }

        public static IServiceCollection AddTaskApplicationServices(this IServiceCollection services)
        {
            services.CreateControllersForAppServices(typeof(TaskAPIModule).Assembly);
            services.AddTransient<ITaskAppService, TaskAppService>();

            return services;
        }

        public static IServiceCollection AddTaskNHibernate(this IServiceCollection services, string connectionString)
        {
            var mapper = new ModelMapper();
            mapper.AddMappings(typeof(TaskNHibernateModule).Assembly.ExportedTypes);
            var mappings = mapper.CompileMappingForAllExplicitlyAddedEntities();

            var configuration = new Configuration();
            configuration.DataBaseIntegration(c =>
            {
                c.Dialect<MsSql2012Dialect>();
                c.ConnectionString = connectionString;
                //c.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                //c.SchemaAction = SchemaAutoAction.Validate;
                //c.LogFormattedSql = true;
                //c.LogSqlInConsole = true;
            });
            configuration.AddMapping(mappings);

            var sessionFactory = configuration.BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());

            //services.AddScoped<IMapperSession, NHibernateMapperSession>();

            services.AddScoped<ITaskRepository, TaskRepository>();
            //services.AddTransient<ITaskRepository, TaskRepository>();

            return services;
        }
    }
}