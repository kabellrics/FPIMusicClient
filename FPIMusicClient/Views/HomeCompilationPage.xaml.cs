namespace FPIMusicClient.Views;

public partial class HomeCompilationPage : ContentPage
{
	public HomeCompilationPage(HomeCompilationViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
