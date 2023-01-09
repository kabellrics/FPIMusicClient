namespace FPIMusicClient.Views;

public partial class ListDetailCompilArtPage : ContentPage
{
    ListDetailCompilArtViewModel ViewModel;

    public ListDetailCompilArtPage(ListDetailCompilArtViewModel viewModel)
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
