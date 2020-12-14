﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class StandardModalitySettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static StandardModalitySettings defaultInstance = ((StandardModalitySettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new StandardModalitySettings())));
        
        public static StandardModalitySettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// A list of standard DICOM modalities that can be used anywhere a list of modalities is required.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("A list of standard DICOM modalities that can be used anywhere a list of modalitie" +
            "s is required.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CR,CT,DOC,DX,ES,KO,MG,MR,NM,PR,OT,PT,RF,SC,US,XA")]
        public string Modalities {
            get {
                return ((string)(this["Modalities"]));
            }
        }
    }
}
