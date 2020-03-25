using ITUniversity.Tasks.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Tasks.API.Services.Dto
{
    /// <summary>
    /// Дто для обновления <see cref="TaskBase"/>
    /// </summary>
    public class TaskUpdateDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public TaskStatus Status { get; set; }
    }
}
