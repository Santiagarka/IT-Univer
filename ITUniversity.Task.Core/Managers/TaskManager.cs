using System.Collections.Generic;
using ITUniversity.Task.Entities;
using ITUniversity.Task.Managers;
using ITUniversity.Task.Stores;

namespace ITUniversity.Tasks.Managers
{
    /// <inheritdoc/>
    public class TaskManager : ITaskManager
    {
        private readonly ITaskStore taskStore;

        public TaskManager(ITaskStore taskStore)
        {
            this.taskStore = taskStore;
        }

        /// <inheritdoc/>
        public TaskBase Create(TaskBase task)
        {
            return taskStore.Save(task);
        }

        /// <inheritdoc/>
        public TaskBase Create(string subject)
        {
            var task = new TaskBase { Subject = subject };
            return taskStore.Save(task);
        }

        public void Delete(long id)
        {
            taskStore.Delete(id);
        }

        public TaskBase Get(long id)
        {
            return taskStore.Get(id);
        }

        /// <inheritdoc/>
        public ICollection<TaskBase> GetAll()
        {
            return taskStore.GetAll();
        }

        public TaskBase Update(TaskBase task)
        {
            return taskStore.Update(task);
        }
    }
}