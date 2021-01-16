using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMarket.Business.Abstract;
using EMarket.Entity.Concrete;
using EMarket.Entity.Domain_Models;

namespace EMarket.Business.Concrete
{
    public class CartManager:ICartService
    {
        private readonly IProductService _productService;

        public CartManager(IProductService productService)
        {
            _productService = productService;
        }

        public void AddToCart(short quantity,Product product, Cart cart)
        {
            var cartItem = cart.CartItems.FirstOrDefault(c => c.Product.Id==product.Id);

            if (cartItem!=null&&product.StockAmount>=cartItem.Quantity+quantity)
            {
                cartItem.Quantity+=quantity;
            }
            else if(cartItem==null&&product.StockAmount>=quantity)
            {
                 cart.CartItems.Add(new CartItem(){Product = product,Quantity = quantity});
            }
            else
            {
                throw new Exception("There is not enough product");
            }
        }

        public void DeleteFromCart(Product product, Cart cart)
        {
            var cartItem = cart.CartItems.FirstOrDefault(c => c.Product.Id == product.Id);
            cart.CartItems.Remove(cartItem);
        }

        public void Clear(Cart cart)
        {
            cart.CartItems.Clear();
        }

        public List<CartItem> GetAll(Cart cart)
        {
            return cart.CartItems;
        }

        public void Sell(Cart cart)
        {
            foreach (var cartItem in cart.CartItems)
            {
               _productService.Update(new Product()
               {
                   Id = cartItem.Product.Id,
                   CategoryId = cartItem.Product.CategoryId,
                   UnitPrice = cartItem.Product.UnitPrice,
                   ProductName = cartItem.Product.ProductName,
                   StockAmount =Convert.ToInt16(cartItem.Product.StockAmount-cartItem.Quantity)
               });
            }
        }

        public void DeleteOneFromCart(Product product, Cart cart)
        {
            var cartItem = cart.CartItems.FirstOrDefault(c => c.Product.Id == product.Id);
            if (cartItem!=null)
            {
                if (cartItem.Quantity == 1)
                {
                    cart.CartItems.Remove(cartItem);
                }
                else
                {
                    cartItem.Quantity--;
                }
            }
        }
    }
}
