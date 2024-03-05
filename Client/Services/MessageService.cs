using Blazored.LocalStorage;

namespace Client.Services;

public class MessageService
{
	private readonly ILocalStorageService? _localStorageService;
	public event Action<Messages>? OnChange;

	public MessageService(ILocalStorageService localStorageService)
	{
		_localStorageService = localStorageService;
	}

	public async Task IncrementNotifications()  // <int>
	{
		var messages = await GetMessages();
		var newMessages = messages with { Notifications = messages.Notifications+1 };
		await _localStorageService!.SetItemAsync("messages", newMessages);
		OnChange?.Invoke(newMessages);
	}

	public async Task DecrementNotifications()
	{
		var messages = await GetMessages();
		var newMessages = messages with { Notifications = messages.Notifications - 1 };
		await _localStorageService!.SetItemAsync("messages", newMessages);
		OnChange?.Invoke(newMessages);
	}

	public async Task<Messages> GetMessages()
	{
		return await _localStorageService!.GetItemAsync<Messages>("messages")
				?? new Messages();
	}
}
