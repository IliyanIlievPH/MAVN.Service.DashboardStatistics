using System.Threading.Tasks;
using JetBrains.Annotations;
using MAVN.Service.DashboardStatistics.Client.Models.Tokens;
using Refit;

namespace MAVN.Service.DashboardStatistics.Client.Api
{
    /// <summary>
    /// DashboardStatistics client API interface.
    /// </summary>
    [PublicAPI]
    public interface ITokensApi
    {
        /// <summary>
        /// Returns a tokens list for given time period.
        /// </summary>
        /// <param name="request">Filtering parameter.</param>
        /// <returns>TokensListResponseModel</returns>
        [Get("/api/tokens")]
        Task<TokensListResponseModel> GetAsync(TokensListRequestModel request);
    }
}
