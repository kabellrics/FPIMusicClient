namespace FPIMusicClient.Views;

public partial class ListDetailDeezerArtDetailPage : ContentPage
{
    public ListDetailDeezerArtDetailPage(ListDetailDeezerArtDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
