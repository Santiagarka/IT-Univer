using System.Collections.Generic;
using System.Linq;

using ITUniversity.Task.Core.Entities;

namespace ITUniversity.Task.Core.Stores
{
    public class TaskMemoryStore : ITaskStore
    {
        private List<TaskBase> tasks;
        private long counter;

        public TaskMemoryStore()
        {
            this.tasks = new List<TaskBase>();
        }

        public TaskBase Save(TaskBase task)
        {
            var saved = tasks.FirstOrDefault(item => item == task);
            if(saved != null)
            {
                return saved;
            }

            task.Id = counter++;
            tasks.Add(task);
            return task;
        }
    }
}
