namespace FPIMusicClient.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetailCompilArtDetailViewModel : BaseViewModel
{
    [ObservableProperty]
    SampleItem item;
}
