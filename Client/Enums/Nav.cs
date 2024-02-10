using Ardalis.SmartEnum;
using Client.Features;

namespace Client.Enums;

[Flags]
public enum PageListType
{
	None = 0,
	SitemapPage = 1,
	Footer = 2,
	Layout = 4,
	Reply = 8
}

public abstract class Nav : SmartEnum<Nav>
{

	#region Id's
	private static class Id
	{
		internal const int Home = 1;
		internal const int About = 2;
		internal const int Donate = 3;
		internal const int Location = 4;
		internal const int Sitemap = 5;
		internal const int Contact = 6;
		internal const int Weather = 7;
		internal const int DonateReplyConfirm = 8;
		internal const int DonateReplyCancel = 9;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly Nav Home = new HomeSE();
	public static readonly Nav About = new AboutSE();
	public static readonly Nav Donate = new DonateSE();
	public static readonly Nav Location = new LocationSE();
	public static readonly Nav Sitemap = new SitemapSE();
	public static readonly Nav Contact = new ContactSE();
	public static readonly Nav Weather = new WeatherSE();
	public static readonly Nav DonateReplyConfirm = new DonateReplyConfirmSE();
	public static readonly Nav DonateReplyCancel = new DonateReplyCancelSE();
	#endregion

	private Nav(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Index { get; }
	public abstract string Title { get; }
	public abstract string Icon { get; }
	public abstract int Sort { get; }
	public abstract bool IsPartOfList(PageListType pageListType);
	public abstract PageListType PageListType { get; }
	#endregion

	#region Private Instantiation

	private sealed class HomeSE : Nav
	{
		public HomeSE() : base($"{nameof(Id.Home)}", Id.Home) { }
		public override string Index => "/";
		public override string Title => "Home";
		public override string Icon => "fas fa-home";
		public override int Sort => Id.Home;
		public override PageListType PageListType => PageListType.Footer;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class AboutSE : Nav
	{
		public AboutSE() : base($"{nameof(Id.About)}", Id.About) { }
		public override string Index => "/About";
		public override string Title => "About";
		public override string Icon => "fas fa-info";
		public override int Sort => Id.About;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class DonateSE : Nav
	{
		public DonateSE() : base($"{nameof(Id.Donate)}", Id.Donate) { }
		public override string Index => "/Donate";
		public override string Title => "Donate";
		public override string Icon => "fas fa-donate";
		public override int Sort => Id.Donate;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Footer | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}



	private sealed class LocationSE : Nav
	{
		public LocationSE() : base($"{nameof(Id.Location)}", Id.Location) { }
		public override string Index => "/Location";
		public override string Title => "Location";
		public override string Icon => "fas fa-map-signs";
		public override int Sort => Id.Location;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class SitemapSE : Nav
	{
		public SitemapSE() : base($"{nameof(Id.Sitemap)}", Id.Sitemap) { }
		public override string Index => "/Sitemap";
		public override string Title => "Sitemap";
		public override string Icon => "fas fa-sitemap";
		public override int Sort => Id.Sitemap;
		public override PageListType PageListType => PageListType.Footer | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class ContactSE : Nav
	{
		public ContactSE() : base($"{nameof(Id.Contact)}", Id.Contact) { }
		public override string Index => "/Contact";
		public override string Title => "Contact";
		public override string Icon => "far fa-comment-dots"; 
		public override int Sort => Id.Contact;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout | PageListType.Footer;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class WeatherSE : Nav
	{
		public WeatherSE() : base($"{nameof(Id.Weather)}", Id.Weather) { }
		public override string Index => "/Weather";
		public override string Title => "Weather";
		public override string Icon => "fas fa-cloud-moon-rain";
		public override int Sort => Id.Weather;
		public override PageListType PageListType => PageListType.SitemapPage;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class DonateReplyConfirmSE : Nav
	{
		public DonateReplyConfirmSE() : base($"{nameof(Id.DonateReplyConfirm)}", Id.DonateReplyConfirm) { }
		public override string Index => "/confirm_donation.html";
		public override string Title => "Donation Confirmed";
		public override string Icon => "fab fa-cc-stripe";
		public override int Sort => Id.DonateReplyConfirm;
		public override PageListType PageListType => PageListType.Reply;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class DonateReplyCancelSE : Nav
	{
		public DonateReplyCancelSE() : base($"{nameof(Id.DonateReplyCancel)}", Id.DonateReplyCancel) { }
		public override string Index => "/cancel_donation.html";
		public override string Title => "Donation Canceled";
		public override string Icon => "fab fa-cc-stripe";
		public override int Sort => Id.DonateReplyCancel;
		public override PageListType PageListType => PageListType.Reply;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}
	#endregion
}

// Ignore Spelling: Nav