namespace FPIMusicClient.Views;

public partial class ListDetailDeezerPlaylistPage : ContentPage
{
    ListDetailDeezerPlaylistViewModel ViewModel;

    public ListDetailDeezerPlaylistPage(ListDetailDeezerPlaylistViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = ViewModel = viewModel;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        await ViewModel.LoadDataAsync();
    }
}
