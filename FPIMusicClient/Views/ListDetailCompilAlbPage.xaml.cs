namespace FPIMusicClient.Views;

public partial class ListDetailCompilAlbPage : ContentPage
{
    ListDetailCompilAlbViewModel ViewModel;

    public ListDetailCompilAlbPage(ListDetailCompilAlbViewModel viewModel)
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
