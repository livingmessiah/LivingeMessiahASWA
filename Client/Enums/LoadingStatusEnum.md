# Example

```html
@using Status = Client.Enums.LoadingStatusEnum

@switch (_status)
{
	case Status.Loading:
		<p class="text-info"><em>Loading...</em></p>
		break;

	case Status.Loaded:
		<p class="text-warning"><em>@_msg</em></p>
		break;

	case Status.EmptyList:
		<p class="text-warning"><em>@_msg</em></p>
		break;
	case Status.ListHasData:
		<p class="text-success"><em>@_msg</em></p>
		break;

	case Status.Error:
		<p class="text-danger"><em>Could not load because of an Error</em></p>
		<p class="p-2">@_msg</p>
		break;

	default:
		break;

}
```

#### `@code` 

```csharp
	private WeatherForecast[]? forecasts = Array.Empty<WeatherForecast>();

	protected Status _status = Status.Loading;
	protected string _msg = string.Empty;

	protected override async Task OnInitializedAsync()
	{
		try
		{
			//await Task.Delay(500);
			forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("/api/WeatherForecast") ?? new WeatherForecast[] { };
			if (forecasts!.Any())
			{
				_status = Status.ListHasData;
				_msg = $"Row Count: {forecasts!.Count()}";
			}
			else
			{
				_status = Status.EmptyList;
				_msg = "Row is not null, but empty";
			}
		}
		catch (Exception ex)
		{
			_status = Status.Error;
			_msg = $"Error calling forecasts, inside {nameof(OnInitializedAsync)}, Error: {ex.ToString()}";
			Console.WriteLine(ex.ToString());
		}
	}
```