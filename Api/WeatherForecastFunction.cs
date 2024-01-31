using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
//using Shared;

namespace Api;

public class WeatherForecastFunction
{
	private readonly ILogger _logger;

	public WeatherForecastFunction(ILoggerFactory loggerFactory)
	{
		_logger = loggerFactory.CreateLogger<WeatherForecastFunction>();
	}

	[Function("WeatherForecast")]
	public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
	{
		_logger.LogInformation("C# HTTP trigger function processed a request.");

		var randomNumber = new Random();
		var temp = 0;

		try
		{
			var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
				TemperatureC = temp = randomNumber.Next(-20, 55),
			});

			var response = req.CreateResponse(HttpStatusCode.OK);
			response.WriteAsJsonAsync(result);
			return response;
		}
		catch (Exception ex)
		{
			_logger.LogError($"Error: {ex.Message}");
			var response = req.CreateResponse(HttpStatusCode.ExpectationFailed);
			return response;
		}

	}

}


