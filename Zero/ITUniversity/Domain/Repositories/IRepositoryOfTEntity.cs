using ITUniversity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Domain.Repositories
{
    /// <summary>
    /// Репозиторий
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IEntity<int>
    {

    }
}
