using System;
using ITUniversity.Domain.Entities;
using ITUniversity.Tasks.Enums;

namespace ITUniversity.Tasks.Entities
{
    /// <summary>
    /// Базовый класс задач
    /// </summary>
     public class TaskBase:Entity<long>
    {

        /// <summary>
        /// Имя таблицы
        /// </summary>
        public const string TableName = "Tasks";

        /// <summary>
        /// Идентификатор
        /// </summary>
        virtual public long Id { get; set; }

        /// <summary>
        /// Тема
        /// </summary>
        virtual public string Subject { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        virtual public string Description { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        virtual public DateTime CreationDate { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        virtual public TaskStatus Status { get; set; }
    }
}