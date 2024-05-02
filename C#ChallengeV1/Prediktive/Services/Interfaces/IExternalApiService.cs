using Prediktive.Models;

namespace Prediktive.Services.Interfaces
{
    public interface IExternalApiService
    {
        Ratios GetRatiosByIdAndYear(int id, int year);
    }
}
