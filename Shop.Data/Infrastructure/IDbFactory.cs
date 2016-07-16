using System;
using System.Collections.Generic;
using System.Linq;
namespace Shop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopDbContext Init();

    }
}
