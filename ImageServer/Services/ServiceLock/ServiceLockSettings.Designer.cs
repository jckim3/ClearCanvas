﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageServer.Services.ServiceLock {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class ServiceLockSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ServiceLockSettings defaultInstance = ((ServiceLockSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ServiceLockSettings())));
        
        public static ServiceLockSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// The number of rows to return when querying for results from the FilesystemQueue table.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The number of rows to return when querying for results from the FilesystemQueue t" +
            "able.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int FilesystemQueueResultCount {
            get {
                return ((int)(this["FilesystemQueueResultCount"]));
            }
        }
        
        /// <summary>
        /// Delay in minutes after delete is complete until next check
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Delay in minutes after delete is complete until next check")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int FilesystemDeleteRecheckDelay {
            get {
                return ((int)(this["FilesystemDeleteRecheckDelay"]));
            }
        }
        
        /// <summary>
        /// Time in minutes to wait between filesystem watermark checks.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Time in minutes to wait between filesystem watermark checks.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int FilesystemDeleteCheckInterval {
            get {
                return ((int)(this["FilesystemDeleteCheckInterval"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int TierMigrationSpeed {
            get {
                return ((int)(this["TierMigrationSpeed"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int HighWatermarkAlertInterval {
            get {
                return ((int)(this["HighWatermarkAlertInterval"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int FilesystemLossyCompressRecheckDelay {
            get {
                return ((int)(this["FilesystemLossyCompressRecheckDelay"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int FilesystemLosslessCompressRecheckDelay {
            get {
                return ((int)(this["FilesystemLosslessCompressRecheckDelay"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int ApplicationLogCachedDays {
            get {
                return ((int)(this["ApplicationLogCachedDays"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int ApplicationLogRecheckDelay {
            get {
                return ((int)(this["ApplicationLogRecheckDelay"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int AlertCachedDays {
            get {
                return ((int)(this["AlertCachedDays"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int AlertRecheckDelay {
            get {
                return ((int)(this["AlertRecheckDelay"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AlertDelete {
            get {
                return ((bool)(this["AlertDelete"]));
            }
        }
    }
}
