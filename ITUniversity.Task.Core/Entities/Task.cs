using System;

using ITUniversity.Task.Core.Enums;

namespace ITUniversity.Task.Core.Entities
{

    public class TaskBase
    {
        public long Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public TaskStatus Status { get; set; }
    }
}
