using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITUniversity.Task.Web.Models
{
    /// <summary>
    /// Модель создание задачи
    /// </summary>
    public class TaskCreateModel
    {

        public static TaskCreateModel New
        {
            get { return new TaskCreateModel(); }
        }

        /// <summary>
        /// Заголовок
        /// </summary>
        [Required(ErrorMessage ="Fill Subject")]
        public string Subject { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}
