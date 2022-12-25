using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Source : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Uri { get; set; }
        public SourceType Type { get; set; }
    }
}
