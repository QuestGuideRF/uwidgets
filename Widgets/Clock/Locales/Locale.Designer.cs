
namespace Clock.Locales {
    using System;
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Locale {
        private static global::System.Resources.ResourceManager resourceMan;
        private static global::System.Globalization.CultureInfo resourceCulture;
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Locale() {
        }
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Clock.Locales.Locale", typeof(Locale).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        public static string Clock {
            get {
                return ResourceManager.GetString("Clock", resourceCulture);
            }
        }
        public static string Clock_Analog_Subtitle {
            get {
                return ResourceManager.GetString("Clock_Analog_Subtitle", resourceCulture);
            }
        }
        public static string Clock_AnalogI_Title {
            get {
                return ResourceManager.GetString("Clock_AnalogI_Title", resourceCulture);
            }
        }
        public static string Clock_AnalogII_Title {
            get {
                return ResourceManager.GetString("Clock_AnalogII_Title", resourceCulture);
            }
        }
        public static string Clock_AnalogIII_Title {
            get {
                return ResourceManager.GetString("Clock_AnalogIII_Title", resourceCulture);
            }
        }
        public static string Clock_Digital_Title {
            get {
                return ResourceManager.GetString("Clock_Digital_Title", resourceCulture);
            }
        }
        public static string Clock_LocalTimeZone {
            get {
                return ResourceManager.GetString("Clock_LocalTimeZone", resourceCulture);
            }
        }
        public static string Clock_ShowDate {
            get {
                return ResourceManager.GetString("Clock_ShowDate", resourceCulture);
            }
        }
        public static string Clock_ShowSeconds {
            get {
                return ResourceManager.GetString("Clock_ShowSeconds", resourceCulture);
            }
        }
        public static string Clock_TimeZone {
            get {
                return ResourceManager.GetString("Clock_TimeZone", resourceCulture);
            }
        }
        public static string Clock_Today {
            get {
                return ResourceManager.GetString("Clock_Today", resourceCulture);
            }
        }
        public static string Clock_Tomorrow {
            get {
                return ResourceManager.GetString("Clock_Tomorrow", resourceCulture);
            }
        }
        public static string Clock_Use24Hours {
            get {
                return ResourceManager.GetString("Clock_Use24Hours", resourceCulture);
            }
        }
        public static string Clock_World_Subtitle {
            get {
                return ResourceManager.GetString("Clock_World_Subtitle", resourceCulture);
            }
        }
        public static string Clock_World_Title {
            get {
                return ResourceManager.GetString("Clock_World_Title", resourceCulture);
            }
        }
        public static string Clock_Yesterday {
            get {
                return ResourceManager.GetString("Clock_Yesterday", resourceCulture);
            }
        }
    }
}