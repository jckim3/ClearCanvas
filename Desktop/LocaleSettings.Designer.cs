﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Desktop {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class LocaleSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static LocaleSettings defaultInstance = ((LocaleSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LocaleSettings())));
        
        public static LocaleSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::ClearCanvas.Desktop.InstalledLocales InstalledLocales {
            get {
                return ((global::ClearCanvas.Desktop.InstalledLocales)(this["InstalledLocales"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SelectedLocale {
            get {
                return ((string)(this["SelectedLocale"]));
            }
            set {
                this["SelectedLocale"] = value;
            }
        }
    }
}
