using Application.Common;
using Domain.Entities;

namespace DataAccess.Repositories
{
    public class RoadMapCrudRepository : BaseAdoCrudRepository<RoadMap>, ICrudRepository<RoadMap>
    {
        public RoadMapCrudRepository(string connectionString) : base(connectionString)
        {

        }
        public Task Create(RoadMap entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoadMap>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RoadMap> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(RoadMap entity)
        {
            throw new NotImplementedException();
        }
    }
}
