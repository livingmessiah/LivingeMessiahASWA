//namespace Shared;
namespace Client.Features.Weather;

public class IndexVM
{
	public DateOnly Date { get; set; }
	public int TemperatureC { get; set; }
	//public string? Summary { get; set; }
	public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

	public string? Summary
	{
		get
		{
			if (TemperatureC >= 32)
			{
				return "Hot";
			}
			else
			{
				if (TemperatureC <= 16)
				{
					return "Freezing";
				}
				else
				{
					return "Mild";
				}
			}
		}
	}

}
