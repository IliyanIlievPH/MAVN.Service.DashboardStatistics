﻿using Lykke.HttpClientGenerator;
using MAVN.Service.DashboardStatistics.Client.Api;

namespace MAVN.Service.DashboardStatistics.Client
{
    /// <inheritdoc />
    public class DashboardStatisticsClient : IDashboardStatisticsClient
    {
        /// <summary>
        /// Initializes a new instance of <see cref="DashboardStatisticsClient"/> with <param name="httpClientGenerator"></param>.
        /// </summary> 
        public DashboardStatisticsClient(IHttpClientGenerator httpClientGenerator)
        {
            CustomersApi = httpClientGenerator.Generate<ICustomersApi>();
            TokensApi = httpClientGenerator.Generate<ITokensApi>();
            SmartVouchersApi = httpClientGenerator.Generate<ISmartVouchersApi>();
        }

        /// <inheritdoc />
        public ICustomersApi CustomersApi { get; }

        /// <inheritdoc />
        public ITokensApi TokensApi { get; }

        /// <inheritdoc />
        public ISmartVouchersApi SmartVouchersApi { get; }
    }
}
