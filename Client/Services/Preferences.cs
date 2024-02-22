namespace Client.Services;

public record Preferences
{
	public string? FullName { get; set; }
	public bool DarkMode { get; init; }
	public int Notifications { get; set; }
}