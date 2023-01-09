namespace FPIMusicClient;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddSingleton<HomeMediathequeViewModel>();

        builder.Services.AddSingleton<HomeMediathequePage>();

        builder.Services.AddSingleton<HomeCompilationViewModel>();

        builder.Services.AddSingleton<HomeCompilationPage>();

        builder.Services.AddSingleton<HomeDeezerViewModel>();

        builder.Services.AddSingleton<HomeDeezerPage>();

        builder.Services.AddSingleton<SettingsViewModel>();

        builder.Services.AddSingleton<SettingsPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailMediaArtDetailViewModel>();
		builder.Services.AddTransient<ListDetailMediaArtDetailPage>();

        builder.Services.AddSingleton<ListDetailMediaArtViewModel>();

        builder.Services.AddSingleton<ListDetailMediaArtPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailMediaAlbDetailViewModel>();
		builder.Services.AddTransient<ListDetailMediaAlbDetailPage>();

        builder.Services.AddSingleton<ListDetailMediaAlbViewModel>();

        builder.Services.AddSingleton<ListDetailMediaAlbPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailCompilArtDetailViewModel>();
		builder.Services.AddTransient<ListDetailCompilArtDetailPage>();

        builder.Services.AddSingleton<ListDetailCompilArtViewModel>();

        builder.Services.AddSingleton<ListDetailCompilArtPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailCompilAlbDetailViewModel>();
		builder.Services.AddTransient<ListDetailCompilAlbDetailPage>();

        builder.Services.AddSingleton<ListDetailCompilAlbViewModel>();

        builder.Services.AddSingleton<ListDetailCompilAlbPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailDeezerAlbDetailViewModel>();
		builder.Services.AddTransient<ListDetailDeezerAlbDetailPage>();

        builder.Services.AddSingleton<ListDetailDeezerAlbViewModel>();

        builder.Services.AddSingleton<ListDetailDeezerAlbPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailDeezerArtDetailViewModel>();
		builder.Services.AddTransient<ListDetailDeezerArtDetailPage>();

        builder.Services.AddSingleton<ListDetailDeezerArtViewModel>();

        builder.Services.AddSingleton<ListDetailDeezerArtPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailDeezerPlaylistDetailViewModel>();
		builder.Services.AddTransient<ListDetailDeezerPlaylistDetailPage>();

        builder.Services.AddSingleton<ListDetailDeezerPlaylistViewModel>();

        builder.Services.AddSingleton<ListDetailDeezerPlaylistPage>();

        builder.Services.AddSingleton<PlayerViewModel>();

        builder.Services.AddSingleton<PlayerPage>();

		return builder.Build();
	}
}
