using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.Data.Models
{
    public class WinkelWagen
    {
        private readonly AppDbContext _appDbContext;

        public WinkelWagen(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public string WinkelWagenId { get; set; }

        public List<WinkelWagenItem> WinkelWagenItems { get; set; }


        public static WinkelWagen GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new WinkelWagen(context) { WinkelWagenId = cartId };
        }

        public void AddToCart(Honden hond, int amount)
        {
            var shoppingCartItem =
                    _appDbContext.WinkelWagenItems.SingleOrDefault(
                        s => s.Honden.HondId == hond.HondId && s.WinkelWagenId == WinkelWagenId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new WinkelWagenItem
                {
                    WinkelWagenId = WinkelWagenId,
                    Honden = hond,
                    Hoeveelheid = 1
                };

                _appDbContext.WinkelWagenItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Hoeveelheid++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Honden hond)
        {
            var shoppingCartItem =
                    _appDbContext.WinkelWagenItems.SingleOrDefault(
                        s => s.Honden.HondId == hond.HondId && s.WinkelWagenId == WinkelWagenId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Hoeveelheid > 1)
                {
                    shoppingCartItem.Hoeveelheid--;
                    localAmount = shoppingCartItem.Hoeveelheid;
                }
                else
                {
                    _appDbContext.WinkelWagenItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<WinkelWagenItem> GetShoppingCartItems()
        {
            return WinkelWagenItems ??
                   (WinkelWagenItems =
                       _appDbContext.WinkelWagenItems.Where(c => c.WinkelWagenId == WinkelWagenId)
                           .Include(s => s.Honden)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext
                .WinkelWagenItems
                .Where(cart => cart.WinkelWagenId == WinkelWagenId);

            _appDbContext.WinkelWagenItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.WinkelWagenItems.Where(c => c.WinkelWagenId == WinkelWagenId)
                .Select(c => c.Honden.Prijs * c.Hoeveelheid).Sum();
            return total;
        }
    }
}
