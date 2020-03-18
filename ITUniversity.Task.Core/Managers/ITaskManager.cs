using ITUniversity.Task.Core.Entities;

namespace ITUniversity.Task.Core.Managers
{
    public interface ITaskManager
    {
        TaskBase Create(TaskBase task);

        TaskBase Create(string subjects);

    }
}
