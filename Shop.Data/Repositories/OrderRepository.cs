﻿using Shop.Data.Infrastructure;
using Shop.Model.Model;

namespace Shop.Data.Repositories
{
    public interface IOrderRepository  : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}