namespace FPIMusicClient.Views;

public partial class ListDetailCompilAlbDetailPage : ContentPage
{
    public ListDetailCompilAlbDetailPage(ListDetailCompilAlbDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
