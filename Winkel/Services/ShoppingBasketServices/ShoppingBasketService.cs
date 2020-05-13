using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.Sales;
using Winkel.Contracts.Request.ShoppingBasket;
using Winkel.Contracts.Response.ShoppingBasket;
using Winkel.Services.SalesServices;
using WinkelDAL.Context;
using WinkelDAL.Model;

namespace Winkel.Services.ShoppingBasketServices
{
    public class ShoppingBasketService : IShoppingBasketService
    {
        ISalesService salesService = new SalesService();
        
        public int AddSales(AddShoppingBasketRequest addShoppingBasketRequest)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var shoppinglist = dataAccess.ShoppingBasket.Where(x => x.CustomerID == addShoppingBasketRequest.CustomerID).ToList();
                
                foreach (var item in shoppinglist)
                {
                    var seller = (from s in dataAccess.ShoppingBasket
                                  join p in dataAccess.Products on s.ProductID equals p.ProductID
                                  join sel in dataAccess.Sellers on p.SellerID equals sel.SellerID
                                  where p.ProductID== item.ProductID
                                  select new
                                  {
                                      Name=sel.Name,
                                      Surname=sel.Surname,
                                      Email=sel.Email
                                  }).ToList()[0];
                             
                    AddSalesRequest addSales = new AddSalesRequest();
                    addSales.CustomerID = addShoppingBasketRequest.CustomerID;
                    addSales.SellerName = seller.Name;
                    addSales.SellerSurname = seller.Surname;
                    addSales.SellerEmail = seller.Email;
                    addSales.ProductID = item.ProductID;
                    addSales.SalesNumber = item.SalesNumber;
                    addSales.Cost = item.Cost;
                    salesService.AddSales(addSales);
                    dataAccess.SaveChanges();
                    ClearAllShoppingList(new Contracts.Request.ShoppingBasket.ClearAllShoppingList(addShoppingBasketRequest.CustomerID));
                }
                return dataAccess.SaveChanges();
            }
        }

        public int AddShoppingList(AddShoppingBasketRequest addShoppingBasket)
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                var added = new ShoppingBasket();
                added.CustomerID = addShoppingBasket.CustomerID;
                added.ProductID = addShoppingBasket.ProductID;
                added.SalesNumber = addShoppingBasket.SalesNumber;
                added.Cost = addShoppingBasket.Cost;
                dataAccess.ShoppingBasket.Add(added);
                return dataAccess.SaveChanges();
            }
        }

        public bool ClearAllShoppingList(ClearAllShoppingList clearAllShoppingList)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var list = dataAccess.ShoppingBasket.Where(x => x.CustomerID == clearAllShoppingList.CustomerID).ToList();
                foreach (var s in list)
                {
                    dataAccess.ShoppingBasket.Remove(s);
                }
                return dataAccess.SaveChanges() > 0;
            }
        }

        public bool ClearShoppingBasket(ClearShoppingListRequest clearShoppingList)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var clearproduct = dataAccess.ShoppingBasket.Where(x => x.ShoppingBasketID == clearShoppingList.ShoppingBasketID).FirstOrDefault<ShoppingBasket>();
                dataAccess.ShoppingBasket.Remove(clearproduct);
                return dataAccess.SaveChanges() > 0;
            }
        }

        public List<ShoppingBasketResponse> ShoppingList(ShoppingListRequest shoppingListRequest)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var list = from s in dataAccess.ShoppingBasket
                           join product in dataAccess.Products on s.ProductID equals product.ProductID
                           join category in dataAccess.Categories on product.CategoryID equals category.CategoryID
                           join unit in dataAccess.Unit on product.UnitID equals unit.UnitID
                           join seller in dataAccess.Sellers on product.SellerID equals seller.SellerID
                           join city in dataAccess.Cities on seller.CityID equals city.CityID
                           where s.CustomerID == shoppingListRequest.CustomerID
                           orderby s.ShoppingBasketID descending
                           select new ShoppingBasketResponse
                           {
                               ID = s.ShoppingBasketID,
                               CategoryName = category.CategoryName,
                               ProductCode = product.ProductCode,
                               ProductName = product.ProductName,
                               Volume = product.Volume,
                               UnitName = unit.UnitName,
                               SellerName = seller.Name,
                               SellerSurame = seller.Surname,
                               SellerEmail = seller.Email,
                               SellerCity = city.CityName,
                               SalesNumber = s.SalesNumber,
                               Cost = s.Cost
                           };


                return list.ToList();
            }
        }
    }
}
