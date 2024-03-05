using System.Text.Json.Serialization;

namespace Shared;

public class ClientPrincipal
{
	[JsonPropertyName("userId")]
	public string? UserId { get; set; }

	[JsonPropertyName("userRoles")]
	public IEnumerable<string>? UserRoles { get; set; }

	[JsonPropertyName("identityProvider")]
	public string? IdentityProvider { get; set; }

	[JsonPropertyName("userDetails")]
	public string? UserDetails { get; set; }
}

