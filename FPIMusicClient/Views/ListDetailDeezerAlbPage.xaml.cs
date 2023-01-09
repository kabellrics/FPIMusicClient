namespace FPIMusicClient.Views;

public partial class ListDetailDeezerAlbPage : ContentPage
{
    ListDetailDeezerAlbViewModel ViewModel;

    public ListDetailDeezerAlbPage(ListDetailDeezerAlbViewModel viewModel)
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
