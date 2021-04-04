using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceShop.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }

        DateTime DateModified { set; get; }
    }
}
