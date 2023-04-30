using ShopApp.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Access.Abstract
{
   public interface ICartDal:IRepository<Cart>
    {
        Cart GetByUserId(string userId);
        void DeleteFromCart(int cartId, int productId);
        void ClearCart(string cartId);
    }
}
