using Application.Common;
using Domain.Entities;

namespace DataAccess.Repositories
{
    public class NodeCrudRepository : BaseAdoCrudRepository<Node>, ICrudRepository<Node>
    {
        public NodeCrudRepository(string connectionString):base(connectionString)
        {

        }
        public Task Create(Node entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Node>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Node> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Node entity)
        {
            throw new NotImplementedException();
        }
    }
}
