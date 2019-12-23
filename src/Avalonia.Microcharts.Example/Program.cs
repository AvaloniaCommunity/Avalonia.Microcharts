using System;

namespace Avalonia.Microcharts.Example
{
    public static class Program
    {
        static int Main(string[] args)
            => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

        static public AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseSkia();
    }
}