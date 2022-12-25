using Domain.Common;

namespace Domain.Entities
{
    public class RoadMap : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Node> Nodes { get; set; } = new List<Node>();
    }
}
