using ITUniversity.Task.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Task.Core.Helpers
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
    }
}
