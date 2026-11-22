
namespace Calendar.Locales {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Calendar.Locales.Locale", typeof(Locale).Assembly);
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
        public static string Calendar {
            get {
                return ResourceManager.GetString("Calendar", resourceCulture);
            }
        }
        public static string Calendar_Date_Subtitle {
            get {
                return ResourceManager.GetString("Calendar_Date_Subtitle", resourceCulture);
            }
        }
        public static string Calendar_Date_Title {
            get {
                return ResourceManager.GetString("Calendar_Date_Title", resourceCulture);
            }
        }
        public static string Calendar_FirstDayOfWeek {
            get {
                return ResourceManager.GetString("Calendar_FirstDayOfWeek", resourceCulture);
            }
        }
        public static string Calendar_Month_Subtitle {
            get {
                return ResourceManager.GetString("Calendar_Month_Subtitle", resourceCulture);
            }
        }
        public static string Calendar_Month_Title {
            get {
                return ResourceManager.GetString("Calendar_Month_Title", resourceCulture);
            }
        }
    }
}