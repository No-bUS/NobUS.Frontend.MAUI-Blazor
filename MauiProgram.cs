using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using NobUS.DataContract.Model.Entity;
using NobUS.DataContract.Reader.OfficialAPI;
using NobUS.Infrastructure.Façade;
using NobUS.Infrastructure.Repository;

namespace NobUS.Frontend.MAUI_Blazor
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<IClient, CongestedClient>();
            builder.Services.AddSingleton<IFaçade, DummyFaçade>();
            builder.Services.AddSingleton<IRepository<Station>, StaticRepository<Station>>();
            builder.Services.AddSingleton<IRepository<Route>, StaticRepository<Route>>();

            return builder.Build();
        }
    }
}