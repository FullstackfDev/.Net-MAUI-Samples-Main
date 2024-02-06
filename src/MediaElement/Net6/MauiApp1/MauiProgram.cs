﻿using CommunityToolkit.Maui.MediaElement;

namespace MauiApp1
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder.UseMauiApp<App>()
				   .UseMauiCommunityToolkitMediaElement()
				   .ConfigureFonts(fonts =>
				   {
					   fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					   fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				   });

			return builder.Build();
		}
	}
}