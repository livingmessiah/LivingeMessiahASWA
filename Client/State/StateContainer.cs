using Blazored.LocalStorage;
using Shared;

namespace Client.State;

public class StateContainer
{
	private readonly ILogger? Logger;
	private readonly ISyncLocalStorageService? localStorage;  //private ISyncLocalStorageService? localStorage;

	public StateContainer(ILogger<StateContainer> logger, ISyncLocalStorageService localStorage)
	{
		Logger = logger;
		this.localStorage = localStorage;
	}

	private User? user;
	public User? User
	{
		get => user;
		set
		{
			try
			{
				user = value;
				//NotifyStateChanged();
				localStorage!.Changed += (sender, e) =>
				{
					Logger!.LogInformation("Value for {Key} changed from {OldValue} to {NewValue}", e.Key, e.OldValue, e.NewValue);
				};
			}
			catch (Exception ex)
			{
				Logger!.LogError(ex, "...Exception thrown");
				//Toast!.ShowError("...Exception thrown, see the Console in your Browsers Developer Tools");
			}
		}
	}

}
