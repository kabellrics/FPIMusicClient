namespace FPIMusicClient.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetailCompilAlbDetailViewModel : BaseViewModel
{
    [ObservableProperty]
    SampleItem item;
}
