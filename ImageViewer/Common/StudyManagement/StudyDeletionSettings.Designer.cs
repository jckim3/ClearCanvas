﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.Common.StudyManagement {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class StudyDeletionSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static StudyDeletionSettings defaultInstance = ((StudyDeletionSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new StudyDeletionSettings())));
        
        public static StudyDeletionSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Enabled {
            get {
                return ((bool)(this["Enabled"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Weeks")]
        public global::ClearCanvas.ImageViewer.Common.StudyManagement.TimeUnit TimeUnit {
            get {
                return ((global::ClearCanvas.ImageViewer.Common.StudyManagement.TimeUnit)(this["TimeUnit"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int TimeValue {
            get {
                return ((int)(this["TimeValue"]));
            }
        }
    }
}
