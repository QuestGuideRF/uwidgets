namespace uWidgets.Core.Models.Attributes;
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class LocaleAttribute(Type localeType, string? displayName = null, string? iconData = null) : Attribute
{
    public Type LocaleType { get; } = localeType;
    public string? DisplayName { get; } = displayName;
    public string? IconData { get; } = iconData;
}