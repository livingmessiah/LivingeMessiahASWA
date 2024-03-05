using Client.Layout.Enums;

namespace Client.Layout.SecondRowSection;



public static class LogUiConstants
{
	public static class Login
	{
		public const string Title = "Login";
		public const string Icon = "fas fa-sign-in-alt";
		public const string ButtonCSS = "btn btn-xs btn-outline-info text-black-50"; //  float-end

		// ToDo: Referenced only by LoginRedirectButton, which isn't being used
		public static string Href(ThirdPartyLogin thirdPartyLogin, string currentUrl)  //System.Uri uri
		{
			return $"{thirdPartyLogin.Href}?post_login_redirect_uri={currentUrl}";
		}
	}
	public static class Logout
	{
		public const string Href = "/.auth/logout?post_logout_redirect_uri=/loggedout";
		public const string Title = "Log out";
		public const string Icon = "fas fa-sign-out-alt";
		public const string ButtonCSS = "btn btn-xs btn-outline-info text-black-50";
	}

}

// Ignore Spelling: loggedout uri xs