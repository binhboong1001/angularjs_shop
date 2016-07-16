using System.Linq;
using Shop.Data.Infrastructure;
using Shop.Model.Model;
using System.Collections.Generic;
namespace Shop.Data.Repositories
{
    public interface IProductCategoryReposotory{
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository:RepositoryBase<ProductCategory>,IProductCategoryReposotory
    {
        public ProductCategoryRepository(IDbFactory factory)
            : base(factory)
        { 
        }
        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategorys.Where(x => x.Alias == alias);
        }
    }
}
