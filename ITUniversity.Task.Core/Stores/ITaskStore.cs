using ITUniversity.Task.Core.Entities;

namespace ITUniversity.Task.Core.Stores
{
    public interface ITaskStore
    {
        TaskBase Save(TaskBase task);

        TaskBase Get(long taskId);

        TaskBase Update(TaskBase task);

        void Delete(long taskId);
    }

}
