using ITUniversity.Task.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Task.Helpers
{
    public static class TaskHelpers
    {
        public static bool Equals(TaskBase firstTask, TaskBase secondTask)
        {
            if (firstTask.Id == secondTask.Id && firstTask.Subject == secondTask.Subject && firstTask.Description == secondTask.Description 
                && firstTask.CreationDate == secondTask.CreationDate && firstTask.Status == secondTask.Status)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static TaskBase Copy(this TaskBase task)
        {
            return new TaskBase()
            {
                Id = task.Id,
                Subject = task.Subject,
                Description = task.Description,
                CreationDate = task.CreationDate,
                Status = task.Status
            };
        }

        public static bool CustomEquals(this TaskBase thisTask, TaskBase otherTask)
        {
            return thisTask.Subject == otherTask.Subject
                && thisTask.Description == otherTask.Description
                && thisTask.CreationDate == otherTask.CreationDate
                && thisTask.Status == otherTask.Status;
        }
    }
}
