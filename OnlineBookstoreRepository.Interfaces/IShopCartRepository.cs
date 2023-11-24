using OnlineBookstore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Repository.Interfaces
{
    public interface IShopCartRepository
    {
        void Add(ShopCart shopCart);

        void Edit(ShopCart shopCart);

        void Delete(ShopCart shopCart);

        ShopCart GetShopCartById(int id);

        IEnumerable<ShopCart> GetAllShopCarts();
    }
}
