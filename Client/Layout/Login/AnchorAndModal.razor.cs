namespace Client.Layout.Login;

public partial class AnchorAndModal
{
#pragma warning disable CS8669

	const string? fontSize = "";
	const string? buttonSize = "btn-xs"; // ToDo: use this... Client.Layout.Navigation.Anchors.BtnSize.Xs;
	private string? currentUrl;

	bool modalOpen = false;
	string? modalClass = "modal";
	bool ModalIsNotShownToggle = true;

	protected void ShowModal()
	{
		currentUrl = NavigationManager!.Uri;
		modalOpen = true;
		ModalIsNotShownToggle = false;
		modalClass += " show";
		StateHasChanged();
	}

	protected void CloseModal()
	{
		modalOpen = false;
		ModalIsNotShownToggle = true;
		modalClass = "modal";
	}
#pragma warning restore CS8669
}


