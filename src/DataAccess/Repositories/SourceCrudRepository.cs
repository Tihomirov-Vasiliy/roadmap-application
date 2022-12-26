using Application.Common;
using Domain.Entities;

namespace DataAccess.Repositories
{
    public class SourceCrudRepository : BaseAdoCrudRepository<Source>, ICrudRepository<Source>
    {
        public SourceCrudRepository(string connectionString) : base(connectionString)
        {

        }
        public Task Create(Source entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Source>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Source> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Source entity)
        {
            throw new NotImplementedException();
        }
    }
}
