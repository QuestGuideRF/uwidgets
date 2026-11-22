using Avalonia;
using System;
using System.IO;
using uWidgets.Core;
using uWidgets.Core.Services;
namespace uWidgets;
class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        try
        {
            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        }
        catch (Exception e)
        {
            var fileName = Path.Combine(Const.CurrentFolder, "crash_log.txt");
            File.WriteAllText(fileName, $"{e.Message}{Environment.NewLine}{e.StackTrace}");
            throw;
        }
    }
    public static AppBuilder BuildAvaloniaApp()
    {
        var settings = new AppSettingsProvider().Get();
        return AppBuilder.Configure<App>()
            .UseWin32()
            .UsePlatformDetect()
            .WithInterFont()
            .With(new Win32PlatformOptions
            {
                CompositionMode = new[] { Win32CompositionMode.WinUIComposition },
                WinUICompositionBackdropCornerRadius = settings.Theme.UseNativeFrame ? 0 : settings.Dimensions.Radius
            })
            .LogToTrace();
    }
}