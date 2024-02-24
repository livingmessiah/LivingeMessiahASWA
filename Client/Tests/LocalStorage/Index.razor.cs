namespace Client.Tests.LocalStorage;

public partial class Index
{

  string? NameFromLocalStorage { get; set; }
  string? StringFromLocalStorage { get; set; }
  int ItemsInLocalStorage { get; set; }
  string? Name { get; set; }
  bool ItemExist { get; set; }

  protected override void OnInitialized()
  {
    GetNameFromLocalStorage();
    GetStringFromLocalStorage();
    GetLocalStorageLength();

    localStorage.Changed += (sender, e) =>
    {
      Console.WriteLine($"Value for key {e.Key} changed from {e.OldValue} to {e.NewValue}");
    };
  }

  void SaveName()
  {
    Console.WriteLine(Name);
    localStorage.SetItem("name", Name);
    GetNameFromLocalStorage();
    GetStringFromLocalStorage();
    GetLocalStorageLength();

    Name = "";
  }

  void GetNameFromLocalStorage()
  {
    try
    {
      NameFromLocalStorage = localStorage.GetItem<string>("name");

      if (string.IsNullOrEmpty(NameFromLocalStorage))
      {
        NameFromLocalStorage = "Nothing Saved";
      }
    }
    catch (Exception)
    {
      Console.WriteLine("error reading 'name'");
    }
  }

  void GetStringFromLocalStorage()
  {
    StringFromLocalStorage = localStorage.GetItemAsString("name");

    if (string.IsNullOrEmpty(StringFromLocalStorage))
    {
      StringFromLocalStorage = "Nothing Saved";
    }
  }

  void RemoveName()
  {
    localStorage.RemoveItem("name");
    GetNameFromLocalStorage();
    GetStringFromLocalStorage();
    GetLocalStorageLength();
  }

  void ClearLocalStorage()
  {
    Console.WriteLine("Calling Clear...");
    localStorage.Clear();
    Console.WriteLine("Getting name from local storage...");
    GetNameFromLocalStorage();
    GetStringFromLocalStorage();
    Console.WriteLine("Calling Get Length...");
    GetLocalStorageLength();
  }

  void GetLocalStorageLength()
  {
    Console.WriteLine(localStorage.Length());
    ItemsInLocalStorage = localStorage.Length();
    ItemExist = localStorage.ContainKey("name");
  }

}