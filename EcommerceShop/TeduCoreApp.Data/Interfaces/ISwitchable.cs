using System;
using System.Collections.Generic;
using System.Text;
using EcommerceShop.Data.Enums;

namespace EcommerceShop.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
