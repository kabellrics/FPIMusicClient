namespace FPIMusicClient.Views;

public partial class ListDetailMediaAlbPage : ContentPage
{
    ListDetailMediaAlbViewModel ViewModel;

    public ListDetailMediaAlbPage(ListDetailMediaAlbViewModel viewModel)
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
