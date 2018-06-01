using HondenAsiel.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HondenAsiel.Data.Models;

namespace HondenAsiel.Data.Repositories
{
    public class OrderRepo : IOrderRepo
    {

        private readonly AppDbContext _appDbContext;
        private readonly WinkelWagen _winkelWagen;


        public OrderRepo(AppDbContext appDbContext, WinkelWagen winkelWagen)
        {
            _appDbContext = appDbContext;
            _winkelWagen = winkelWagen;
        }

        public void MaakOrder(Order order)
        {
            order.Ordergeplaatst = DateTime.Now;
            _appDbContext.orders.Add(order);

            var winkelwagenitems = _winkelWagen.WinkelWagenItems;

            foreach (var item in winkelwagenitems)
            {
                var orderdeatails = new OrderDetails()
                {
                    Hoeveelheid = item.Hoeveelheid,
                    HondenId = item.Honden.HondId,
                    OrderId = order.OrderId,
                    Prijs = item.Honden.Prijs
                };

                _appDbContext.orderdetails.Add(orderdeatails);
            }
        }
    }
}
