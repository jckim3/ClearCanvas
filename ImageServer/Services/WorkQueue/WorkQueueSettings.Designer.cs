﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageServer.Services.WorkQueue {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class WorkQueueSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static WorkQueueSettings defaultInstance = ((WorkQueueSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new WorkQueueSettings())));
        
        public static WorkQueueSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10000")]
        public int WorkQueueQueryDelay {
            get {
                return ((int)(this["WorkQueueQueryDelay"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableStudyIntegrityValidation {
            get {
                return ((bool)(this["EnableStudyIntegrityValidation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int WorkQueueThreadCount {
            get {
                return ((int)(this["WorkQueueThreadCount"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int PriorityWorkQueueThreadCount {
            get {
                return ((int)(this["PriorityWorkQueueThreadCount"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int MemoryLimitedWorkQueueThreadCount {
            get {
                return ((int)(this["MemoryLimitedWorkQueueThreadCount"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("256")]
        public int WorkQueueMinimumFreeMemoryMB {
            get {
                return ((int)(this["WorkQueueMinimumFreeMemoryMB"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int TierMigrationProgressUpdateInSeconds {
            get {
                return ((int)(this["TierMigrationProgressUpdateInSeconds"]));
            }
        }
    }
}
