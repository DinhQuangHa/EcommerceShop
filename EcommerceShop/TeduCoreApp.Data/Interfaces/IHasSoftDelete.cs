using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceShop.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { set; get; }
    }
}
