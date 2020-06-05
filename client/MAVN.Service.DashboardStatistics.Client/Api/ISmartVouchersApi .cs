﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;
using MAVN.Service.DashboardStatistics.Client.Models.VoucherStatistic;
using Refit;

namespace MAVN.Service.DashboardStatistics.Client.Api
{
    /// <summary>
    /// Smart vouchers Api
    /// </summary>
    [PublicAPI]
    public interface ISmartVouchersApi
    {
        /// <summary>
        /// Get total voucher operations statistics per Partner
        /// </summary>
        /// <param name="partnerIds"></param>
        /// <returns></returns>
        [Post("totals")]
        Task<IList<VoucherStatisticsResponse>> GetTotalStatisticsAsync(Guid[] partnerIds);
    }
}