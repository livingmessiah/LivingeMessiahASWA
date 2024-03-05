namespace Client.Services;

public record Preferences
{
	public string? FullName { get; set; } // No references 
	public bool DarkMode { get; init; }
}