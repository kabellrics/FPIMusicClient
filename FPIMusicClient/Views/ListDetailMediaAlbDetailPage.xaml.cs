namespace FPIMusicClient.Views;

public partial class ListDetailMediaAlbDetailPage : ContentPage
{
    public ListDetailMediaAlbDetailPage(ListDetailMediaAlbDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
