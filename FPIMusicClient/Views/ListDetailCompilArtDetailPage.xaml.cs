namespace FPIMusicClient.Views;

public partial class ListDetailCompilArtDetailPage : ContentPage
{
    public ListDetailCompilArtDetailPage(ListDetailCompilArtDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
