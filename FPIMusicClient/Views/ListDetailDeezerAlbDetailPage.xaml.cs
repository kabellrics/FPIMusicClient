namespace FPIMusicClient.Views;

public partial class ListDetailDeezerAlbDetailPage : ContentPage
{
    public ListDetailDeezerAlbDetailPage(ListDetailDeezerAlbDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
