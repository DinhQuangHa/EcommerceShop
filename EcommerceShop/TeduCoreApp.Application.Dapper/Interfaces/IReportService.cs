﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EcommerceShop.Application.Dapper.ViewModels;

namespace EcommerceShop.Application.Dapper.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<RevenueReportViewModel>> GetReportAsync(string fromDate, string toDate);
    }
}
