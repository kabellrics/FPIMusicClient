namespace FPIMusicClient.Views;

public partial class HomeDeezerPage : ContentPage
{
	public HomeDeezerPage(HomeDeezerViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
