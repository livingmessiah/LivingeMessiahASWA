using Client.Enums;
using Microsoft.AspNetCore.Components;

namespace Client.Components;

public partial class LoginRedirectButton
{
	[Inject] public NavigationManager? NavigationManager { get; set; }

	[Parameter, EditorRequired] public string? ReturnUrl { get; set; }
	[Parameter, EditorRequired] public string? PageTitleToView { get; set; }

	void RedirectToLoginClick()
	{
		NavigationManager!.NavigateTo($"{NavAccount.Login}?returnUrl={ReturnUrl!}", true);
	}
}