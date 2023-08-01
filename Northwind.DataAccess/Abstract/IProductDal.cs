using Northwind.Core.DataAccess;
using Northwind.Entities.ComplexType;
using Northwind.Entities.Concrate;
using System.Collections.Generic;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
