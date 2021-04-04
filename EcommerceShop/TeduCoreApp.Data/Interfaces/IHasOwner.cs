using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceShop.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }


    }
}
