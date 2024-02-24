using Ardalis.SmartEnum;

namespace Client.Tests.Enums;

public abstract class NavTest : SmartEnum<NavTest>
{

	#region Id's
	private static class Id
	{
		internal const int Parent = 50;
		internal const int LocalStorage = 51;
		internal const int FeastTable = 52;                             //fas fa-glass-cheers
		internal const int FeastSfSchedule = 53;                    //far fa-calendar
		internal const int BibleBooks = 54;                             // fas fa-tachometer-alt Title="Bible Books"
		internal const int BibleCascadingDDL = 55;              // fas fa-tachometer-alt Title="Bible Cascading Dropdown List"
		internal const int Grid12Calendar = 56;                     // fas fa-grip-horizontal Title="Grid 12 Calendar"
		internal const int MarkDown = 57;                                   //Index = "/MarkdownTest";   // fab fa-markdown Title="Mark Down"
		internal const int SyncfusionSfDropDownList = 58; //Index = "/BBCP";   Title = "Bible Book Chapter | Syncfusion DDL"; fas fa-search"
		internal const int Shavuot = 59;                                    // fab fa-creative-commons-zero
		internal const int Roles = 60;                                      // fas fa-ruler  Index = "/RolesTest";   Title = "Roles Test";
		internal const int HealThySelf = 61;                            // fas fa-heartbeat   Title = "Heal Thy Self!";
		internal const int LoggerAndToast = 62;
	}
	#endregion

	#region  Declared Public Instances

	public static readonly NavTest Parent = new ParentSE();
	public static readonly NavTest LocalStorage = new LocalStorageSE();
	public static readonly NavTest LoggerAndToast = new LoggerAndToastSE();

	#endregion

	private NavTest(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Index { get; }
	public abstract string Title { get; }
	public abstract string Icon { get; }
	public abstract int Sort { get; }
	#endregion

	#region Private Instantiation

	private sealed class ParentSE : NavTest
	{
		public ParentSE() : base($"{nameof(Id.Parent)}", Id.Parent) { }
		public override string Index => "/Test";
		public override string Title => "Test Index";
		public override string Icon => "fas fa-vial";  
		public override int Sort => Id.Parent;
	}

	private sealed class LocalStorageSE : NavTest
	{
		public LocalStorageSE() : base($"{nameof(Id.LocalStorage)}", Id.LocalStorage) { }
		public override string Index => "/Test/LocalStorage";
		public override string Title => "Test Blazored LocalStorage (sync)";
		public override string Icon => "fas fa-box-open";
		public override int Sort => Id.LocalStorage;
	}

	private sealed class LoggerAndToastSE : NavTest
	{
		public LoggerAndToastSE() : base($"{nameof(Id.LoggerAndToast)}", Id.LoggerAndToast) { }
		public override string Index => "/Test/LoggerAndToast";
		public override string Title => "Test Logger and Toast";
		public override string Icon => "fas fa-hard-hat";  
		public override int Sort => Id.LoggerAndToast;
	}


	#endregion
}

// Ignore Spelling: NavTest Nav Blazored
