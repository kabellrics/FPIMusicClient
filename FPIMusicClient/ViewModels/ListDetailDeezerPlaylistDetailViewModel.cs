namespace FPIMusicClient.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetailDeezerPlaylistDetailViewModel : BaseViewModel
{
    [ObservableProperty]
    SampleItem item;
}
