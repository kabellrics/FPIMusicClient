namespace FPIMusicClient;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(ListDetailDeezerPlaylistDetailPage), typeof(ListDetailDeezerPlaylistDetailPage));
        Routing.RegisterRoute(nameof(ListDetailDeezerArtDetailPage), typeof(ListDetailDeezerArtDetailPage));
        Routing.RegisterRoute(nameof(ListDetailDeezerAlbDetailPage), typeof(ListDetailDeezerAlbDetailPage));
        Routing.RegisterRoute(nameof(ListDetailCompilAlbDetailPage), typeof(ListDetailCompilAlbDetailPage));
        Routing.RegisterRoute(nameof(ListDetailCompilArtDetailPage), typeof(ListDetailCompilArtDetailPage));
        Routing.RegisterRoute(nameof(ListDetailMediaAlbDetailPage), typeof(ListDetailMediaAlbDetailPage));
        Routing.RegisterRoute(nameof(ListDetailMediaArtDetailPage), typeof(ListDetailMediaArtDetailPage));
	}
}
