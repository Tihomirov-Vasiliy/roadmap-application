using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Node : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Depth { get; set; }
        public NodeImportance Importance { get; set; }
        public Node ParentNode { get; set; }
        public IEnumerable<Source> Sources { get; set; } = new List<Source>();
    }
}
