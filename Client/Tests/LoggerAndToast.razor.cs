using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
//using Microsoft.Extensions.Logging;

namespace Client.Tests;

public partial class LoggerAndToast
{
	[Inject] public ILogger<LoggerAndToast>? Logger { get; set; }
	[Inject] public IToastService? Toast { get; set; }

	protected override void OnInitialized()
	{
		Logger!.LogInformation("Inside {Class}!{Method}", nameof(LoggerAndToast), nameof(OnInitializedAsync));
	}


	//<button @onclick="@(e => ThrowException_ButtonClick())"
	//<button type="button" @onclick="CloseModal" class="btn btn-primary">

	void ThrowExceptionButtonClick()
	{
		//Logger!.LogDebug(string.Format("Inside {0}", nameof(LoggerAndToast) + "!" + nameof(ThrowExceptionButtonClick)));
		Logger!.LogWarning(string.Format("Inside {0}", $"{nameof(LoggerAndToast)}!{nameof(ThrowExceptionButtonClick)}"));
		try
		{
			for (int i = 0; i < 10; i++)
			{
				if (i == 5)
				{
					throw new Exception("This is our demo exception");
				}
				else
				{
					//Logger!.LogDebug($"The value of i is {i}");
					Logger!.LogWarning($"The value of i is {i}");
				}
			}

		}
		catch (Exception ex)
		{
			Logger!.LogError(ex, "...Exception thrown");
			Toast!.ShowError("...Exception thrown, see the Console in your Browsers Developer Tools");
		}
	}
}