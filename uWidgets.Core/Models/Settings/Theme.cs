namespace uWidgets.Core.Models.Settings;
public record Theme(
    bool? DarkMode,
    string? AccentColor,
    double OpacityLevel,
    bool Monochrome,
    bool UseNativeFrame,
    string FontFamily);