using Ardalis.SmartEnum;
namespace Client.Enums;

public abstract class NavAccount : SmartEnum<NavAccount>
{
	/*
	
	
	<a href="/.auth/login/aad">Login Entra</a>
	 <a href="/.auth/login/github">Login GitHub</a>

	<a href="/.auth/login/github?post_login_redirect_uri=https://zealous-water.azurestaticapps.net/success">Login</a>

	<a href="/.auth/logout">Log out</a>

	<a href="/.auth/logout?post_logout_redirect_uri=https://zealous-water.azurestaticapps.net/success">Log out Redirect</a>

	*/
	#region Id's
	private static class Id
	{
		internal const int Login = 1;
		internal const int LogoutAction = 2;
		internal const int PasswordChanged = 3;
		internal const int Profile = 4;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly NavAccount Login = new LoginSE();
	public static readonly NavAccount LogoutAction = new LogoutActionSE();
	public static readonly NavAccount PasswordChanged = new PasswordChangedSE();
	public static readonly NavAccount Profile = new ProfileSE();
	#endregion

	private NavAccount(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Index { get; }
	public abstract string Title { get; }
	public abstract string Icon { get; }
	#endregion

	#region Private Instantiation

	private sealed class LoginSE : NavAccount
	{
		public LoginSE() : base($"{nameof(Id.Login)}", Id.Login) { }
		public override string Index => "/Account/Login";
		public override string Title => "Log in";
		public override string Icon => "fas fa-sign-in-alt";
	}

	private sealed class LogoutActionSE : NavAccount
	{
		public LogoutActionSE() : base($"{nameof(Id.LogoutAction)}", Id.LogoutAction) { }
		public override string Index => "/Account/Logout";
		public override string Title => "Log out";
		public override string Icon => "fas fa-sign-out-alt";
	}

	private sealed class PasswordChangedSE : NavAccount
	{
		public PasswordChangedSE() : base($"{nameof(Id.PasswordChanged)}", Id.PasswordChanged) { }
		public override string Index => "/account/PasswordChanged";
		public override string Title => "Password Changed Successfully";
		//public override string PageTitle = " Password Changed";
		public override string Icon => "fas fa-key";
	}

	private sealed class ProfileSE : NavAccount
	{
		public ProfileSE() : base($"{nameof(Id.Profile)}", Id.Profile) { }
		public override string Index => "/account/profile";
		public override string Title => "Profile";
		public override string Icon => "fas fa-user";  //fab fa-superpowers
																				//public const string IconVerified = "fas fa-check";
																				//public const string IconNotVerified = "fas fa-question";
	}
	#endregion

}

// Ignore Spelling: Nav