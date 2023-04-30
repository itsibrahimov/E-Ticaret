using ShopApp.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Access.Abstract
{
   public interface IOrderDal: IRepository<Order>
    {
        List<Order> GetOrders(string userId);
    }
}
