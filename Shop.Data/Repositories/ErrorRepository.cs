using Shop.Data.Infrastructure;
using Shop.Model.Model;

namespace Shop.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {

    }

    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}
