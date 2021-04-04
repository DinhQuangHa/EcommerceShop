﻿using System;
using System.Collections.Generic;
using System.Text;
using EcommerceShop.Application.ViewModels.Common;
using EcommerceShop.Utilities.Dtos;

namespace EcommerceShop.Application.Interfaces
{
    public interface IFeedbackService
    {
        void Add(FeedbackViewModel feedbackVm);

        void Update(FeedbackViewModel feedbackVm);

        void Delete(int id);

        List<FeedbackViewModel> GetAll();

        PagedResult<FeedbackViewModel> GetAllPaging(string keyword, int page, int pageSize);

        FeedbackViewModel GetById(int id);

        void SaveChanges();
    }
}
