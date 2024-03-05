using System.Net.Http;

namespace Shared;

public class User
{
	public User(ClientPrincipal clientPrincipal)
	{
		ClientPrincipal = clientPrincipal;
	}

	public bool IsLoggedIn => ClientPrincipal != null && !string.IsNullOrEmpty(ClientPrincipal.UserId);
	public ClientPrincipal ClientPrincipal { get; set; } = new ClientPrincipal();
	

	public bool IsAdmin
	{
		get
		{
			if (ClientPrincipal != null && ClientPrincipal.UserRoles != null &&
					ClientPrincipal.UserRoles!.Any(item => item.Contains("admin", System.StringComparison.InvariantCultureIgnoreCase)) )
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}

	public string UserId
	{
		get
		{
			if (ClientPrincipal != null && !string.IsNullOrEmpty(ClientPrincipal.UserId))
			{
				return ClientPrincipal.UserId;
			}
			else
			{
				return string.Empty;
			}
		}
	}

	public string Roles
	{
		get
		{
			if (ClientPrincipal != null)
			{
				return this.ClientPrincipal.UserRoles is not null ?
				String.Join(", ", this.ClientPrincipal.UserRoles.Select(s => s ))
				: "";
			}
			else
			{
				return string.Empty;
			}
		}
	}


	/*
	 * public string? IsLoggedIn => ClientPrincipal != null && !string.IsNullOrEmpty(ClientPrincipal.UserId);
	public string NameTiny
	{
		get
		{
			return !String.IsNullOrEmpty(Name) ? $"<span class='text-success'><b>{Name.Truncate(25)}</b></span>" : "";
		}
	}
	*/

	public string BlueCheck
	{
		get
		{
			if (IsLoggedIn)  //Verified
			{
				return "<span class='text-primary'><i class='fas fa-check'></i></span>";
			}
			else
			{
				return "<span class='text-danger'>Unverified<i class='fas fa-question'></i></span>";
			}
		}
	}

}
