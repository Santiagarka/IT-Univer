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

        public TaskBase Save(TaskBase task)
        {
            var savedTask = tasks.FirstOrDefault(item => item.Id == task.Id);
            if(savedTask != null)
            {
                return savedTask;
            }

            task.Id = counter++;
            task.CreationDate = DateTime.Now;
            tasks.Add(task);
            return task;
        }

        public TaskBase Get(long taskId)
        {
            var task = tasks.FirstOrDefault(item => item.Id == taskId);
            return task;
        }

        public TaskBase Update(TaskBase task)
        {
            var updatedTask = tasks.FirstOrDefault(item => item.Id == task.Id);
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
