using System;
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

        /// <summary>
        /// Сохрание
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public TaskBase Save(TaskBase task)
        {
            if (task == null)
            {
                throw new Exception("Task cannot be empty");
            }

            var savedTask = tasks.FirstOrDefault(item => item == task);
            if(savedTask != null)
            {
                return savedTask;
            }

            task.Id = counter++;
            task.CreationDate = DateTime.Now;
            tasks.Add(task);
            return task;
        }

        /// <summary>
        /// Получить задачу по Id
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public TaskBase Get(long taskId)
        {
            var task = tasks.FirstOrDefault(item => item.Id == taskId);
            return task;
        }

        /// <summary>
        /// Обновить задачу
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public TaskBase Update(TaskBase task)
        {
            if(task == null)
            {
                throw new Exception("Task cannot be empty");
            }

            var updatedTask = tasks.FirstOrDefault(item => item == task);
            if(updatedTask != null)
            {
                updatedTask.Subject = task.Subject;
                updatedTask.Description = task.Description;
                updatedTask.CreationDate = task.CreationDate;
                updatedTask.Status = task.Status;
                return updatedTask;
            }
            else
            {
                return task;
            }
        }

        /// <summary>
        /// Удалить задачу по Id
        /// </summary>
        /// <param name="taskId"></param>
        public void Delete(long taskId)
        {
            var deletedTask = tasks.FirstOrDefault(item => item.Id == taskId);
            if(deletedTask != null)
            {
                tasks.Remove(deletedTask);
            }
        }
    }
}
