using Nitrogen.Data.Repository;
using Nitrogen.Model;
using System.Collections.Generic;

namespace Nitrogen.Logic.System
{
    public class DepartmentLogic : RepositoryFactory
    {
        private IRepository _repository;
        private DepartmentLogic()
        {
            _repository = BaseRepository();
        }

        public IEnumerable<Department> GetDepartmentList()
        {
            return _repository.FindList<Department>(c => true);
        }
    }
}
