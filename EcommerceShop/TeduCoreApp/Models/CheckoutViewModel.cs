using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceShop.Application.ViewModels.Common;
using EcommerceShop.Application.ViewModels.Product;
using EcommerceShop.Data.Enums;
using EcommerceShop.Utilities.Extensions;

namespace EcommerceShop.WebApp.Models
{
    public class CheckoutViewModel : BillViewModel
    {
        public List<ShoppingCartViewModel> Carts { get; set; }
        public List<EnumModel> PaymentMethods
        {
            get
            {
                return ((PaymentMethod[])Enum.GetValues(typeof(PaymentMethod)))
                    .Select(c => new EnumModel
                    {
                        Value = (int)c,
                        Name = c.GetDescription()
                    }).ToList();
            }
        }
    }
}
