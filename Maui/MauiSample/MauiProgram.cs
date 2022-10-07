﻿using MauiSample.Domain.Silly;
using MauiSample.Infrastructure;
using MauiSample.Presentation.Navigables;
using MauiSample.Presentation.Navigables.Impl;

using Sharpnado.CollectionView;
using Sharpnado.Tabs;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MauiSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSkiaSharp()
			.UseSharpnadoTabs(loggerEnable: false)
			.UseSharpnadoCollectionView(loggerEnable: false)
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Road_Rage.otf", "RoadRage");

                fonts.AddFont("ka1.ttf", "KarmaticFont");
			});

        return builder.Build();
	}
}
