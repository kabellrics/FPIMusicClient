namespace FPIMusicClient.Views;

public partial class HomeMediathequePage : ContentPage
{
	public HomeMediathequePage(HomeMediathequeViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
