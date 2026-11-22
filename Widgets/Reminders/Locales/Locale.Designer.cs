
namespace Reminders.Locales {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Reminders.Locales.Locale", typeof(Locale).Assembly);
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
        public static string Reminders {
            get {
                return ResourceManager.GetString("Reminders", resourceCulture);
            }
        }
        public static string Reminders_Delete {
            get {
                return ResourceManager.GetString("Reminders_Delete", resourceCulture);
            }
        }
        public static string Reminders_DeleteAll {
            get {
                return ResourceManager.GetString("Reminders_DeleteAll", resourceCulture);
            }
        }
        public static string Reminders_DeleteCompleted {
            get {
                return ResourceManager.GetString("Reminders_DeleteCompleted", resourceCulture);
            }
        }
        public static string Reminders_List_Subtitle {
            get {
                return ResourceManager.GetString("Reminders_List_Subtitle", resourceCulture);
            }
        }
        public static string Reminders_List_Title {
            get {
                return ResourceManager.GetString("Reminders_List_Title", resourceCulture);
            }
        }
    }
}