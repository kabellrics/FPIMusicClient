namespace FPIMusicClient.Views;

public partial class ListDetailDeezerPlaylistDetailPage : ContentPage
{
    public ListDetailDeezerPlaylistDetailPage(ListDetailDeezerPlaylistDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
