﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Healthcare {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class WorklistSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static WorklistSettings defaultInstance = ((WorklistSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new WorklistSettings())));
        
        public static WorklistSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Specifies whether a worklist is required to have a time window specified.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether a worklist is required to have a time window specified.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TimeWindowRequired {
            get {
                return ((bool)(this["TimeWindowRequired"]));
            }
        }
        
        /// <summary>
        /// Specifies the maximum number of days that a worklist time window can span.  Use 0 to disable this constraint.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies the maximum number of days that a worklist time window can span.  Use 0" +
            " to disable this constraint.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("14")]
        public int TimeWindowMaxSpanDays {
            get {
                return ((int)(this["TimeWindowMaxSpanDays"]));
            }
        }
    }
}
