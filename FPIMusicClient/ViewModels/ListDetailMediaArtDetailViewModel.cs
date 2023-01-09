namespace FPIMusicClient.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetailMediaArtDetailViewModel : BaseViewModel
{
    [ObservableProperty]
    SampleItem item;
}
