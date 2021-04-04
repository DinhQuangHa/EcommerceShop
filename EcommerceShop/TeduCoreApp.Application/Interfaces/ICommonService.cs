using System;
using System.Collections.Generic;
using System.Text;
using EcommerceShop.Application.ViewModels.Common;

namespace EcommerceShop.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();
        List<SlideViewModel> GetSlides(string groupAlias);
        SystemConfigViewModel GetSystemConfig(string code);
    }
}
