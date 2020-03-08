using Nitrogen.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Nitrogen.Logic
{
    public class BaseLogc<T> : RepositoryFactory where T:class,new()
    {
        private IRepository _repository;
        public BaseLogc()
        {
            this._repository = BaseRepository();
        }

        public T GetEntity(Expression<Func<T, bool>> expression)
        {
            return _repository.FindEntity<T>(expression);
        }

        public int Modfiy(T entity)
        {
            return _repository.Update(entity);
        }
    }
}
