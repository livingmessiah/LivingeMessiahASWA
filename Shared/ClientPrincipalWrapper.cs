using System.Text.Json.Serialization;

namespace Shared;

public class ClientPrincipalWrapper
{
	[JsonPropertyName("clientPrincipal")]
	public ClientPrincipal ClientPrincipal { get; set; } = new ClientPrincipal();
}
