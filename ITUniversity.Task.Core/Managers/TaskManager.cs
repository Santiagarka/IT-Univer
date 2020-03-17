
using ITUniversity.Task.Core.Entities;

namespace ITUniversity.Task.Core.Managers
{
    public class TaskManager: ITaskManager
    {
        public TaskBase Create(TaskBase task)
        {
            return task;
        }

        public TaskBase Create(string subjects)
        {
            return new TaskBase();
        }
    }
}
