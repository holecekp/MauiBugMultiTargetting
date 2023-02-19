﻿using Microsoft.Extensions.Logging;

namespace MauiApp3;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureMauiHandlers((handlers) =>
			{
#if ANDROID
                handlers.AddHandler(typeof(ICustomEntry), typeof(CustomEntryHandler));
#endif

#if WINDOWS
                handlers.AddHandler(typeof(ICustomEntry), typeof(CustomEntryHandler));
#endif
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
