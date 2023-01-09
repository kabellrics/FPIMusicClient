namespace FPIMusicClient.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetailDeezerArtDetailViewModel : BaseViewModel
{
    [ObservableProperty]
    SampleItem item;
}
