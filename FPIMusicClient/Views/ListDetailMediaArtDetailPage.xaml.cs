namespace FPIMusicClient.Views;

public partial class ListDetailMediaArtDetailPage : ContentPage
{
    public ListDetailMediaArtDetailPage(ListDetailMediaArtDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
