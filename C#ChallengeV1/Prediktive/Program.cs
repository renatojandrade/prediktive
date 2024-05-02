// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Prediktive.Models;
using Prediktive.Services;
using Prediktive.Services.Interfaces;

(int id, int year)[] calculusList = new[]
{
    (67352, 2007),
    (87964, 2011)
};

var builder = new ServiceCollection()
    .AddSingleton<IExternalApiService, ExternalApiService>()
    .AddSingleton<ICalculatorService, CalculatorService>()
    .BuildServiceProvider();

var calculatorService = builder.GetRequiredService<ICalculatorService>();

foreach (var calc in calculusList)
{
    CalculusResponse? response = calculatorService.Calculate(calc.id, calc.year);

    if (response != null)
    {
        Console.WriteLine($"{JsonConvert.SerializeObject(response)}");
    }
}