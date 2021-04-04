using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceShop.Data.Interfaces
{
    public interface ISortable
    {
        int SortOrder { set; get; }
    }
}
