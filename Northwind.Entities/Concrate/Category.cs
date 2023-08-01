using Northwind.Core.Entities;

namespace Northwind.Entities.Concrate
{
    public class Category : IEntity
    {
        public virtual int CategoryId { get; set; }
        public virtual string CategoryName { get; set; }
    }
}
