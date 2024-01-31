
using Ardalis.SmartEnum;
using Client.Pages;

namespace Client.Enums;

public abstract class Nav : SmartEnum<Nav>
{
	#region Id's
	private static class Id
	{
		internal const int Home = 1;
		internal const int About = 2; 
		//internal const int Contact = 3;
		//internal const int Gallery = 4;  
		//internal const int Reviews = 5;
		//internal const int Counter = 6;
		internal const int Weather = 7;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly Nav Home = new HomeSE();
	public static readonly Nav About = new AboutSE();
	//public static readonly Nav Contact = new ContactSE();
	//public static readonly Nav Gallery = new GallerySE();
	//public static readonly Nav Reviews = new ReviewsSE();
	//public static readonly Nav Counter = new CounterSE();
	public static readonly Nav Weather = new WeatherSE();
	#endregion

	private Nav(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Index { get; }
	public abstract string Title { get; }
	public abstract string Icon { get; }
	public abstract int Sort { get; }
	public abstract bool SampleCode { get; }
//	public abstract string Role { get; }
	#endregion

	#region Private Instantiation

	private sealed class HomeSE : Nav
	{
		public HomeSE() : base($"{nameof(Id.Home)}", Id.Home) { }
		public override string Index => "/";
		public override string Title => "Home";
		public override string Icon => "fas fa-home";
		public override int Sort => Id.Home;
		public override bool SampleCode => false;
		//	public override string Role => "";
	}

	private sealed class AboutSE : Nav
	{
		public AboutSE() : base($"{nameof(Id.About)}", Id.About) { }
		public override string Index => "/About";
		public override string Title => "About";
		public override string Icon => "fas fa-info";
		public override int Sort => Id.About;
		public override bool SampleCode => false;
		//public override string Role => "";
	}
/*
	private sealed class ContactSE : Nav
	{
		public ContactSE() : base($"{nameof(Id.Contact)}", Id.Contact) { }
		public override string Index => "/Contact";
		public override string Title => "Contact";
		public override string Icon => "fas fa-address-card";  // fas fa-user-friends
		public override int Sort => Id.Contact;
		public override bool SampleCode => false;
		//public override string Role => "";
	}

	private sealed class GallerySE : Nav
	{
		public GallerySE() : base($"{nameof(Id.Gallery)}", Id.Gallery) { }
		public override string Index => "/Gallery";
		public override string Title => "Gallery";
		public override string Icon => "fas fa-image"; 
		public override int Sort => Id.Gallery;
		public override bool SampleCode => false;
		//public override string Role => "";
	}

	private sealed class ReviewsSE : Nav
	{
		public ReviewsSE() : base($"{nameof(Id.Reviews)}", Id.Reviews) { }
		public override string Index => "/Reviews";
		public override string Title => "Reviews";
		public override string Icon => "far fa-newspaper"; 
		public override int Sort => Id.Reviews;
		public override bool SampleCode => false;
		//public override string Role => "";
	}

	private sealed class CounterSE : Nav
	{
		public CounterSE() : base($"{nameof(Id.Counter)}", Id.Counter) { }
		public override string Index => "/Counter";
		public override string Title => "Counter";
		public override string Icon => "fas fa-calculator"; 
		public override int Sort => Id.Counter;
		public override bool SampleCode => true;
		//public override string Role => "";
	}
*/
	private sealed class WeatherSE : Nav
	{
		public WeatherSE() : base($"{nameof(Id.Weather)}", Id.Weather) { }
		public override string Index => "/Weather";
		public override string Title => "Weather";
		public override string Icon => "fas fa-cloud-moon-rain";  
		public override int Sort => Id.Weather;
		public override bool SampleCode => true;
		//public override string Role => "";
	}



	#endregion
}

// Ignore Spelling: Nav