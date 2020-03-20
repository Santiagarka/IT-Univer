

using AutoMapper;
using ITUniversity.Task.Entities;
using ITUniversity.Task.Web.Models;

namespace ITUniversity.Task.Web
{
    public class Mappings: Profile
    {
        public Mappings()
        {
            CreateMap<TaskCreateModel, TaskBase>();
        }
    }
}
