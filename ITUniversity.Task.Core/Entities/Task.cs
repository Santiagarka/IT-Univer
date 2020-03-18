using System;

using ITUniversity.Task.Enums;

namespace ITUniversity.Task.Entities
{

    public class TaskBase
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Заголовок
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public TaskStatus Status { get; set; }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                return this.Id == ((TaskBase)obj).Id;
            }
            
        }
    }
}
