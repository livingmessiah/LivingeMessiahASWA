using Ardalis.SmartEnum;

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
		internal const int BibleSearch = 23;
		internal const int BiblicalPermaculture = 29;
		internal const int Calendar = 12;
		internal const int Community = 32;
		internal const int FurtherStudies = 26;
		internal const int Gallery = 33;
		internal const int HeavensDeclare = 16;
		internal const int ImportantLinks = 27;
		internal const int IndepthStudy = 19;
		internal const int IntroductionAndWelcome = 11;
		internal const int Leadership = 22;
		internal const int Mishpocha = 31;
		internal const int Feasts = 28;
		internal const int Parasha = 20;
		internal const int ParashaArchive = 21;
		internal const int WindmillRanch = 13;
		internal const int Podcast = 17;
		internal const int SampleCode = 30;
		internal const int ShabbatService = 14;
		internal const int Store = 24;
		internal const int TorahTuesday = 18;
		internal const int UpcomingEvents = 15;

		internal const int BloodMoons = 34;   //far fa-moon
		internal const int Planner = 35;   //far fa-map
		internal const int PlannerV2 = 36;   //fas fa-bread-slice  		public const string Title = "Feast Planner";  
		internal const int LunarMonthV2 = 37;   //fas fa-cloud-moon
		internal const int SpecialEvents = 38;   //far fa-clock   //Title = "Special Events";


		internal const int Articles = 40;  // /Articles/Pesach
		internal const int Pesach = 41;   //fas fa-door-open  /Articles/Pesach // TitleEnglish = "Passover";
		internal const int MakingChallahBread = 42;   //fas fa-bread-slice  /Articles/MakingChallahBread // Title = "Challah Bread";
		internal const int Prepared = 43;   //fas fa-band-aid  /Articles/Prepared // Title = "Preparing";

		internal const int PsalmsAndProverbs = 45;   //fab fa-readme Title = "Upcoming Psalms And Proverbs"; Index2 = "/PandP";
		internal const int Psalms = 46;   //fab fa-readme   //Title = "Psalms";
		internal const int Profile = 47;
		internal const int Notifications = 48;
		internal const int LoggedOut = 49;


		/*
public static class ThankYou
{
	public const string TopId = "ThankYouTop";
	public const string Title = "ThankYou";
	public const string FragmentId = "ThankYou";
	public const string Descr = "Thank You !!!";
}
		*/

		// Remove?
		internal const int FeastTable = 50;   //fas fa-glass-cheers
		internal const int FeastSfSchedule = 51;   //far fa-calendar
		internal const int BibleBooks = 52;   // fas fa-tachometer-alt Title="Bible Books"
		internal const int BibleCascadingDDL = 53;   // fas fa-tachometer-alt Title="Bible Cascading Dropdown List"
		internal const int Grid12Calendar = 54;   // fas fa-grip-horizontal Title="Grid 12 Calendar"
		internal const int MarkDown = 55; //Index = "/MarkdownTest";   // fab fa-markdown Title="Mark Down"
		internal const int SyncfusionSfDropDownList = 56; //Index = "/BBCP";   Title = "Bible Book Chapter | Syncfusion DDL"; fas fa-search"
		internal const int Shavuot = 57; // fab fa-creative-commons-zero
		internal const int Roles = 58; // fas fa-ruler  Index = "/RolesTest";   Title = "Roles Test";
		internal const int HealThySelf = 59; // fas fa-heartbeat   Title = "Heal Thy Self!";
    internal const int TestLocalStorage = 60;   
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

	public static readonly Nav IntroductionAndWelcome = new IntroductionAndWelcomeSE();
	public static readonly Nav Calendar = new CalendarSE();
	public static readonly Nav PageWindmillRanch = new WindmillRanchSE();
	public static readonly Nav ShabbatService = new ShabbatServiceSE();
	public static readonly Nav UpcomingEvents = new UpcomingEventsSE();
	public static readonly Nav HeavensDeclare = new HeavensDeclareSE();
	public static readonly Nav Podcast = new PodcastSE();
	public static readonly Nav TorahTuesday = new TorahTuesdaySE();
	public static readonly Nav IndepthStudy = new IndepthStudySE();
	public static readonly Nav Parasha = new ParashaSE();
	public static readonly Nav ParashaArchive = new ParashaArchiveSE();
	public static readonly Nav Leadership = new LeadershipSE();
	public static readonly Nav BibleSearch = new BibleSearchSE();
	public static readonly Nav Store = new StoreSE();
	public static readonly Nav Articles = new ArticlesSE();
	public static readonly Nav FurtherStudies = new FurtherStudiesSE();
	public static readonly Nav ImportantLinks = new ImportantLinksSE();
	public static readonly Nav Feast = new FeastsSE();
	public static readonly Nav BiblicalPermaculture = new BiblicalPermacultureSE();
	public static readonly Nav SampleCode = new SampleCodeSE();
	public static readonly Nav Mishpocha = new MishpochaSE();
	public static readonly Nav Community = new CommunitySE();
	public static readonly Nav Gallery = new GallerySE();

	public static readonly Nav Profile = new ProfileSE();
	public static readonly Nav Notifications = new NotificationsSE();
	public static readonly Nav LoggedOut = new LoggedOutSE();

	public static readonly Nav TestLocalStorage = new TestLocalStorageSE();

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

	private sealed class IntroductionAndWelcomeSE : Nav
	{
		public IntroductionAndWelcomeSE() : base($"{nameof(Id.IntroductionAndWelcome)}", Id.IntroductionAndWelcome) { }
		public override string Index => "/IntroductionAndWelcome";
		public override string Title => "Welcome";  //  Title2 = "Welcome 😄";  https://github.com/anton-bot/Full-Emoji-List/blob/master/Emoji.cs
		public override string Icon => "far fa-handshake";
		public override int Sort => Id.IntroductionAndWelcome;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class CalendarSE : Nav
	{
		public CalendarSE() : base($"{nameof(Id.Calendar)}", Id.Calendar) { }
		public override string Index => "/Calendar";
		public override string Title => "Calendar";
		public override string Icon => "far fa-calendar-alt";
		public override int Sort => Id.Calendar;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class WindmillRanchSE : Nav
	{
		public WindmillRanchSE() : base($"{nameof(Id.WindmillRanch)}", Id.WindmillRanch) { }
		public override string Index => "/WindmillRanch/Permaculture";
		public override string Title => "Biblical Permaculture";  // Windmill Ranch
		public override string Icon => "fas fa-tractor";
		public override int Sort => Id.WindmillRanch;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class ShabbatServiceSE : Nav
	{
		public ShabbatServiceSE() : base($"{nameof(Id.ShabbatService)}", Id.ShabbatService) { }
		public override string Index => "/ShabbatService";
		public override string Title => "Shabbat Service";
		public override string Icon => "far fa-hand-spock";
		public override int Sort => Id.ShabbatService;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	/*
		public static class LiveFeed
	{
		public const string IndepthStudyTopId = "IndepthStudyTop";  // ToDo: Anchor Fragment's don't work in Blazor 3.1
		public const string IndepthStudyTitle = "In-depth Study";
		public const string ShabbatServiceTopId = "ShabbatServiceTop"; // ToDo: Anchor Fragment's don't work in Blazor 3.1
		public const string ShabbatServiceTitle = "Main Shabbat Service";
		public const string ShabbatServiceEspTopId = "ShabbatServiceEspTop"; // ToDo: Anchor Fragment's don't work in Blazor 3.1
		public const string ShabbatServiceEspTitle = "Servicio principal de Shabat";
	}
	*/


	private sealed class UpcomingEventsSE : Nav
	{
		public UpcomingEventsSE() : base($"{nameof(Id.UpcomingEvents)}", Id.UpcomingEvents) { }
		public override string Index => "/UpcomingEvents";
		public override string Title => "Upcoming Events";
		public override string Icon => "far fa-clock";
		public override int Sort => Id.UpcomingEvents;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class HeavensDeclareSE : Nav
	{
		public HeavensDeclareSE() : base($"{nameof(Id.HeavensDeclare)}", Id.HeavensDeclare) { }
		public override string Index => "/HeavensDeclare";
		public override string Title => "Heavens Declare";
		public override string Icon => "fas fa-cloud-moon";
		public override int Sort => Id.HeavensDeclare;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class PodcastSE : Nav
	{
		public PodcastSE() : base($"{nameof(Id.Podcast)}", Id.Podcast) { }
		public override string Index => "/Podcast";
		public override string Title => "Podcast";  // Title2 => "Podcast";
		public override string Icon => "fas fa-podcast";
		public override int Sort => Id.Podcast;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class TorahTuesdaySE : Nav
	{
		public TorahTuesdaySE() : base($"{nameof(Id.TorahTuesday)}", Id.TorahTuesday) { }
		public override string Index => "/TorahTuesday";
		public override string Title => "Torah Tuesday";
		//public override string Title2 => "Torah Tuesday Study";
		public override string Icon => "far fa-clock";
		public override int Sort => Id.TorahTuesday;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class IndepthStudySE : Nav
	{
		public IndepthStudySE() : base($"{nameof(Id.IndepthStudy)}", Id.IndepthStudy) { }
		public override string Index => "/IndepthStudy";
		public override string Title => "In-depth Study";
		public override string Icon => "fas fa-graduation-cap";
		public override int Sort => Id.IndepthStudy;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class ParashaSE : Nav
	{
		public ParashaSE() : base($"{nameof(Id.Parasha)}", Id.Parasha) { }
		public override string Index => "/Parasha";
		public override string Title => "Parasha";
		public override string Icon => "fas fa-torah";
		public override int Sort => Id.Parasha;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class ParashaArchiveSE : Nav
	{
		public ParashaArchiveSE() : base($"{nameof(Id.ParashaArchive)}", Id.ParashaArchive) { }
		public override string Index => "/ParashaArchive";
		public override string Title => "Parasha Archive";
		public override string Icon => "fas fa-archive";
		public override int Sort => Id.ParashaArchive;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class LeadershipSE : Nav
	{
		public LeadershipSE() : base($"{nameof(Id.Leadership)}", Id.Leadership) { }
		public override string Index => "/Leadership";
		public override string Title => "Leadership";
		public override string Icon => "fas fa-user-friends";
		public override int Sort => Id.Leadership;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}
	/*
	public static class Fragments
	{
		public const string Top = "Top";
		public const string Leadership = "Leadership";
	}
	*/

	private sealed class BibleSearchSE : Nav
	{
		public BibleSearchSE() : base($"{nameof(Id.BibleSearch)}", Id.BibleSearch) { }
		public override string Index => "/BibleSearch";
		public override string Title => "Bible Search";
		public override string Icon => "fas fa-search";  //fas fa-bible
		public override int Sort => Id.BibleSearch;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class StoreSE : Nav
	{
		public StoreSE() : base($"{nameof(Id.Store)}", Id.Store) { }
		public override string Index => "/Store";
		public override string Title => "Store";
		public override string Icon => "fas fa-shopping-cart";
		public override int Sort => Id.Store;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}
	/*
		public static class Items
		{
			public const string TitleTShirt = "T-Shirt";
			public const string IconTShirt = "fas fa-tshirt";
			public const string TitleCalendar = "Calendar";
			public const string SubTitleCalendar = "LMM Designed Calendar";
			public const string IconCalendar = "far fa-calendar-alt";
		}
	*/

	private sealed class ArticlesSE : Nav
	{
		public ArticlesSE() : base($"{nameof(Id.Articles)}", Id.Articles) { }
		public override string Index => "/Articles";
		public override string Title => "Articles";
		public override string Icon => "fas fa-pencil-alt";
		public override int Sort => Id.Articles;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class FurtherStudiesSE : Nav
	{
		public FurtherStudiesSE() : base($"{nameof(Id.FurtherStudies)}", Id.FurtherStudies) { }
		public override string Index => "/FurtherStudies";
		public override string Title => "Further Studies";
		public override string Icon => "fab fa-leanpub";
		public override int Sort => Id.FurtherStudies;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class ImportantLinksSE : Nav
	{
		public ImportantLinksSE() : base($"{nameof(Id.ImportantLinks)}", Id.ImportantLinks) { }
		public override string Index => "/ImportantLinks";
		public override string Title => "Important Links";
		public override string Icon => "fas fa-external-link-square-alt";
		public override int Sort => Id.ImportantLinks;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class FeastsSE : Nav
	{
		public FeastsSE() : base($"{nameof(Id.Feasts)}", Id.Feasts) { }
		public override string Index => "/Feasts";
		public override string Title => "Feasts";
		public override string Icon => "fas fa-pizza-slice"; // fas fa-drumstick-bite"
		//public override string Descr = "Landing page for Feasts of YHVH";
		public override int Sort => Id.Feasts;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class BiblicalPermacultureSE : Nav
	{
		public BiblicalPermacultureSE() : base($"{nameof(Id.BiblicalPermaculture)}", Id.BiblicalPermaculture) { }
		public override string Index => "/BiblicalPermaculture";
		public override string Title => "Biblical Permaculture";
		public override string Icon => "fas fa-tractor";
		public override int Sort => Id.BiblicalPermaculture;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class SampleCodeSE : Nav
	{
		public SampleCodeSE() : base($"{nameof(Id.SampleCode)}", Id.SampleCode) { }
		public override string Index => "/SampleCode";
		public override string Title => "Sample Code";
		public override string Icon => "fas fa-vial";
		public override int Sort => Id.SampleCode;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class MishpochaSE : Nav
	{
		public MishpochaSE() : base($"{nameof(Id.Mishpocha)}", Id.Mishpocha) { }
		public override string Index => "/Mishpocha";
		public override string Title => "Mishpocha means Family";
		public override string Icon => "fas fa-ellipsis-h";
		public override int Sort => Id.Mishpocha;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class CommunitySE : Nav
	{
		public CommunitySE() : base($"{nameof(Id.Community)}", Id.Community) { }
		public override string Index => "/Community";
		public override string Title => "Community";
		//public override string Descr = "Community Bulletin Board";
		public override string Icon => "fas fa-chalkboard";
		//public override string Icon2 => "fas fa-city";
		public override int Sort => Id.Community;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class GallerySE : Nav
	{
		public GallerySE() : base($"{nameof(Id.Gallery)}", Id.Gallery) { }
		public override string Index => "/Gallery";
		public override string Title => "Gallery";
		public override string Icon => "fas fa-image";
		public override int Sort => Id.Gallery;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}


	private sealed class ProfileSE : Nav
	{
		public ProfileSE() : base($"{nameof(Id.Profile)}", Id.Profile) { }
		public override string Index => "/profile";
		public override string Title => "Profile";
		public override string Icon => "fas fa-user";  //fab fa-superpowers
		public override int Sort => Id.Profile;
		public override PageListType PageListType => PageListType.SitemapPage;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class NotificationsSE : Nav
	{
		public NotificationsSE() : base($"{nameof(Id.Notifications)}", Id.Notifications) { }
		public override string Index => "/Notifications";
		public override string Title => "Notifications";
		public override string Icon => "far fa-envelope";
		public override int Sort => Id.Notifications;
		public override PageListType PageListType => PageListType.SitemapPage;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class LoggedOutSE : Nav
	{
		public LoggedOutSE() : base($"{nameof(Id.LoggedOut)}", Id.LoggedOut) { }
		public override string Index => "/loggedout";
		public override string Title => "Logged Out";
		public override string Icon => "fas fa-sign-out-alt";
		public override int Sort => Id.LoggedOut;
		public override PageListType PageListType => PageListType.None;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}



	private sealed class TestLocalStorageSE : Nav
  {
    public TestLocalStorageSE() : base($"{nameof(Id.TestLocalStorage)}", Id.TestLocalStorage) { }
    public override string Index => "/TestLocalStorage";
    public override string Title => "Test Blazored LocalStorage (sync)";
    public override string Icon => "fas fa-box-open"; 
    public override int Sort => Id.TestLocalStorage;
    public override PageListType PageListType => PageListType.SitemapPage;
    public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
  }


  #endregion
}

// Ignore Spelling: Nav Permaculture Indepth Mishpocha Parasha Chala Challah Syncfusion QRC Descr tshirt Torah pesach YouTube loggedout Blazored
