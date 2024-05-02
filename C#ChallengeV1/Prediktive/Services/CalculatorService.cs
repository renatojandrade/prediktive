using Prediktive.Models;
using Prediktive.Services.Interfaces;

namespace Prediktive.Services
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IExternalApiService ExternalApiService;

        public CalculatorService(IExternalApiService externalApiService)
        {
            ExternalApiService = externalApiService;
        }

        public CalculusResponse? Calculate(int id, int year)
        {
            try
            {
                var ratios = ExternalApiService.GetRatiosByIdAndYear(id, year);

                return new CalculusResponse
                {
                    AuctionValue = ratios.AuctionRatio * ratios.Cost,
                    MarketValue = ratios.MarketRatio * ratios.Cost
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
