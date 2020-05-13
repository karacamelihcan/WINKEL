using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.ShoppingBasket
{
    public class ClearShoppingListRequest
    {
        public ClearShoppingListRequest(int ShoppingBasketID)
        {
            this.ShoppingBasketID = ShoppingBasketID;
        }
        
        public int ShoppingBasketID { get; set; }
        


    }
}
