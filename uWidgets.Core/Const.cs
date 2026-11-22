namespace uWidgets.Core;
public static class Const
{
    public const string AppName = "uWidgets";
    public static readonly string CurrentFolder = Path.GetDirectoryName(Environment.ProcessPath)!;
    public static readonly string WidgetsFolder = Path.Combine(CurrentFolder, WidgetsFolderName);
    public static readonly string AppSettingsFile = Path.Combine(CurrentFolder, AppSettingsFileName);
    public static readonly string LayoutFile = Path.Combine(CurrentFolder, LayoutFileName);
    private static string WidgetsFolderName => "Widgets";
    private static string AppSettingsFileName => "appSettings.json";
    private static string LayoutFileName => "layout.json";
}