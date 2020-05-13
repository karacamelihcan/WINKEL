using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.Sales;
using Winkel.Contracts.Request.ShoppingBasket;
using Winkel.Contracts.Response.ShoppingBasket;

namespace Winkel.Services.ShoppingBasketServices
{
    public interface IShoppingBasketService
    {
        int AddSales(AddShoppingBasketRequest addShoppingBasketRequest);
        bool ClearShoppingBasket(ClearShoppingListRequest clearShoppingList);
        bool ClearAllShoppingList(ClearAllShoppingList clearAllShoppingList);
        int AddShoppingList(AddShoppingBasketRequest addShoppingBasket);
        List<ShoppingBasketResponse> ShoppingList(ShoppingListRequest shoppingListRequest);
    }
}
