using System.Collections.Generic;
using ITUniversity.Task.Entities;

namespace ITUniversity.Task.Managers
{
    public interface ITaskManager
    {
        TaskBase Create(TaskBase task);

        TaskBase Create(string subjects);

        ICollection<TaskBase> GetAll();

        TaskBase Get(long id);
        void Delete(long id);

    }
}
