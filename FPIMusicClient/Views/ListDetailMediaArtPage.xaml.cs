namespace FPIMusicClient.Views;

public partial class ListDetailMediaArtPage : ContentPage
{
    ListDetailMediaArtViewModel ViewModel;

    public ListDetailMediaArtPage(ListDetailMediaArtViewModel viewModel)
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
