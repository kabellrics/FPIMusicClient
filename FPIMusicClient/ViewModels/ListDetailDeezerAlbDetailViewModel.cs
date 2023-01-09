namespace FPIMusicClient.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetailDeezerAlbDetailViewModel : BaseViewModel
{
    [ObservableProperty]
    SampleItem item;
}
