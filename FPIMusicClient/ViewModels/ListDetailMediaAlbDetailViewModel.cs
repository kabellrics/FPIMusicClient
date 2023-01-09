namespace FPIMusicClient.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetailMediaAlbDetailViewModel : BaseViewModel
{
    [ObservableProperty]
    SampleItem item;
}
