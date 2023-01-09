namespace FPIMusicClient.Views;

public partial class PlayerPage : ContentPage
{
	public PlayerPage(PlayerViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
