
namespace Monitor.Locales {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Monitor.Locales.Locale", typeof(Locale).Assembly);
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
        public static string Monitor {
            get {
                return ResourceManager.GetString("Monitor", resourceCulture);
            }
        }
        public static string Monitor_Metric {
            get {
                return ResourceManager.GetString("Monitor_Metric", resourceCulture);
            }
        }
        public static string Monitor_Metric_0 {
            get {
                return ResourceManager.GetString("Monitor_Metric_0", resourceCulture);
            }
        }
        public static string Monitor_Metric_1 {
            get {
                return ResourceManager.GetString("Monitor_Metric_1", resourceCulture);
            }
        }
        public static string Monitor_Metric_2 {
            get {
                return ResourceManager.GetString("Monitor_Metric_2", resourceCulture);
            }
        }
        public static string Monitor_Metric_3 {
            get {
                return ResourceManager.GetString("Monitor_Metric_3", resourceCulture);
            }
        }
        public static string Monitor_Metric_4 {
            get {
                return ResourceManager.GetString("Monitor_Metric_4", resourceCulture);
            }
        }
        public static string Monitor_SingleMetric_Subtitle {
            get {
                return ResourceManager.GetString("Monitor_SingleMetric_Subtitle", resourceCulture);
            }
        }
        public static string Monitor_SingleMetric_Title {
            get {
                return ResourceManager.GetString("Monitor_SingleMetric_Title", resourceCulture);
            }
        }
    }
}