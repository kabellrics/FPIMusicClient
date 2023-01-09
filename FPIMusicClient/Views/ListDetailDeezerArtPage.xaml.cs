namespace FPIMusicClient.Views;

public partial class ListDetailDeezerArtPage : ContentPage
{
    ListDetailDeezerArtViewModel ViewModel;

    public ListDetailDeezerArtPage(ListDetailDeezerArtViewModel viewModel)
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
