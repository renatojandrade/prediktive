using Prediktive.Models;

namespace Prediktive.Services.Interfaces
{
    public interface ICalculatorService
    {
        CalculusResponse? Calculate(int id, int year);
    }
}
