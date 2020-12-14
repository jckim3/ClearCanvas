﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.Common {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class MemoryManagementSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static MemoryManagementSettings defaultInstance = ((MemoryManagementSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new MemoryManagementSettings())));
        
        public static MemoryManagementSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// The high watermark for process memory.  When the high watermark is hit, memory management will unload objects until it reaches the low watermark.  A value of -1 means this value is computed automatically. Applies to both 32 and 64 bit processes, and overrides all 64-bit specific settings.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute(@"The high watermark for process memory.  When the high watermark is hit, memory management will unload objects until it reaches the low watermark.  A value of -1 means this value is computed automatically. Applies to both 32 and 64 bit processes, and overrides all 64-bit specific settings.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public long HighWatermarkMegaBytes {
            get {
                return ((long)(this["HighWatermarkMegaBytes"]));
            }
        }
        
        /// <summary>
        /// The low watermark for process virtual memory.  When the high watermark is hit, memory management will unload objects until it reaches the low watermark.  A value of -1 means this value is computed automatically. Applies to both 32 and 64 bit processes, and overrides all 64-bit specific settings.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute(@"The low watermark for process virtual memory.  When the high watermark is hit, memory management will unload objects until it reaches the low watermark.  A value of -1 means this value is computed automatically. Applies to both 32 and 64 bit processes, and overrides all 64-bit specific settings.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public long LowWatermarkMegaBytes {
            get {
                return ((long)(this["LowWatermarkMegaBytes"]));
            }
        }
        
        /// <summary>
        /// The amount of held (large object) memory to collect, as a percentage of the total in use by the process.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The amount of held (large object) memory to collect, as a percentage of the total" +
            " in use by the process.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public double HeldMemoryToCollectPercent {
            get {
                return ((double)(this["HeldMemoryToCollectPercent"]));
            }
        }
        
        /// <summary>
        /// When calculating the maximum memory usage based on the amount of free system memory, this amount is excluded from the calculation.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("When calculating the maximum memory usage based on the amount of free system memo" +
            "ry, this amount is excluded from the calculation.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public long x64MinimumFreeSystemMemoryMegabytes {
            get {
                return ((long)(this["x64MinimumFreeSystemMemoryMegabytes"]));
            }
        }
        
        /// <summary>
        /// The high watermark for process memory, as a percentage of an approximate maximum (process used + system free).
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The high watermark for process memory, as a percentage of an approximate maximum " +
            "(process used + system free).")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("70")]
        public double x64MaxMemoryUsagePercent {
            get {
                return ((double)(this["x64MaxMemoryUsagePercent"]));
            }
        }
        
        /// <summary>
        /// A maximum amount of memory to collect at once. Important on systems with a lot of memory, as collecting too much at once can slow the process down.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("A maximum amount of memory to collect at once. Important on systems with a lot of" +
            " memory, as collecting too much at once can slow the process down.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("800")]
        public long x64MaxMemoryToCollectMegabytes {
            get {
                return ((long)(this["x64MaxMemoryToCollectMegabytes"]));
            }
        }
    }
}
