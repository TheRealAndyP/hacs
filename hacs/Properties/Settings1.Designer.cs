﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hacs.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.178.36")]
        public string XS1 {
            get {
                return ((string)(this["XS1"]));
            }
            set {
                this["XS1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Admin")]
        public string Username {
            get {
                return ((string)(this["Username"]));
            }
            set {
                this["Username"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("92")]
        public int HTTPPort {
            get {
                return ((int)(this["HTTPPort"]));
            }
            set {
                this["HTTPPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.0.0.0")]
        public string HTTPIP {
            get {
                return ((string)(this["HTTPIP"]));
            }
            set {
                this["HTTPIP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int ConfigurationCacheMinutes {
            get {
                return ((int)(this["ConfigurationCacheMinutes"]));
            }
            set {
                this["ConfigurationCacheMinutes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ScriptingActorConfiguration.config")]
        public string ScriptingActorConfigurationFilename {
            get {
                return ((string)(this["ScriptingActorConfigurationFilename"]));
            }
            set {
                this["ScriptingActorConfigurationFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("password")]
        public string Password {
            get {
                return ((string)(this["Password"]));
            }
            set {
                this["Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PowerSensorConfiguration.config")]
        public string PowerSensorConfigurationFilename {
            get {
                return ((string)(this["PowerSensorConfigurationFilename"]));
            }
            set {
                this["PowerSensorConfigurationFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ScriptingTimerConfiguration.config")]
        public string ScriptingTimerConfigurationFilename {
            get {
                return ((string)(this["ScriptingTimerConfigurationFilename"]));
            }
            set {
                this["ScriptingTimerConfigurationFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("14")]
        public int DefaultSensorOutputPeriod {
            get {
                return ((int)(this["DefaultSensorOutputPeriod"]));
            }
            set {
                this["DefaultSensorOutputPeriod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int SwitchAgainCheckpointMinutes {
            get {
                return ((int)(this["SwitchAgainCheckpointMinutes"]));
            }
            set {
                this["SwitchAgainCheckpointMinutes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public int SwitchAgainTimeWindowMinutes {
            get {
                return ((int)(this["SwitchAgainTimeWindowMinutes"]));
            }
            set {
                this["SwitchAgainTimeWindowMinutes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int AutomatedSensorCheck_ResponseTimeWindow {
            get {
                return ((int)(this["AutomatedSensorCheck_ResponseTimeWindow"]));
            }
            set {
                this["AutomatedSensorCheck_ResponseTimeWindow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SensorCheckIgnoreList.config")]
        public string SensorCheckIgnoreFile {
            get {
                return ((string)(this["SensorCheckIgnoreFile"]));
            }
            set {
                this["SensorCheckIgnoreFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("log")]
        public string LogfileDirectory {
            get {
                return ((string)(this["LogfileDirectory"]));
            }
            set {
                this["LogfileDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000000")]
        public long DataObjectCacheSize {
            get {
                return ((long)(this["DataObjectCacheSize"]));
            }
            set {
                this["DataObjectCacheSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HTTPProxy.config")]
        public string HTTPProxyConfigurationFilename {
            get {
                return ((string)(this["HTTPProxyConfigurationFilename"]));
            }
            set {
                this["HTTPProxyConfigurationFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ELVMAXEnabled {
            get {
                return ((bool)(this["ELVMAXEnabled"]));
            }
            set {
                this["ELVMAXEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.178.82")]
        public string ELVMAXIP {
            get {
                return ((string)(this["ELVMAXIP"]));
            }
            set {
                this["ELVMAXIP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("62910")]
        public int ELVMAXPort {
            get {
                return ((int)(this["ELVMAXPort"]));
            }
            set {
                this["ELVMAXPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10000")]
        public int ELVMAXUpdateIntervalMsec {
            get {
                return ((int)(this["ELVMAXUpdateIntervalMsec"]));
            }
            set {
                this["ELVMAXUpdateIntervalMsec"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60000")]
        public int ELVMAXReconnectTimeMsec {
            get {
                return ((int)(this["ELVMAXReconnectTimeMsec"]));
            }
            set {
                this["ELVMAXReconnectTimeMsec"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int SensorCheckIntervalSec {
            get {
                return ((int)(this["SensorCheckIntervalSec"]));
            }
            set {
                this["SensorCheckIntervalSec"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("360")]
        public int ELVMAXSensorReStoringSec {
            get {
                return ((int)(this["ELVMAXSensorReStoringSec"]));
            }
            set {
                this["ELVMAXSensorReStoringSec"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SolarLogEnabled {
            get {
                return ((bool)(this["SolarLogEnabled"]));
            }
            set {
                this["SolarLogEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("solarlog.fritz.box")]
        public string SolarLogURLDomain {
            get {
                return ((string)(this["SolarLogURLDomain"]));
            }
            set {
                this["SolarLogURLDomain"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10000")]
        public int SolarLogUpdateIntervalMsec {
            get {
                return ((int)(this["SolarLogUpdateIntervalMsec"]));
            }
            set {
                this["SolarLogUpdateIntervalMsec"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NetworkMonitorConfiguration.config")]
        public string NetworkMonitorConfigurationFilename {
            get {
                return ((string)(this["NetworkMonitorConfigurationFilename"]));
            }
            set {
                this["NetworkMonitorConfigurationFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool NetworkMonitorEnabled {
            get {
                return ((bool)(this["NetworkMonitorEnabled"]));
            }
            set {
                this["NetworkMonitorEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60000")]
        public int NetworkMonitorUpdateIntervalMsec {
            get {
                return ((int)(this["NetworkMonitorUpdateIntervalMsec"]));
            }
            set {
                this["NetworkMonitorUpdateIntervalMsec"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AlarmingConfiguration.config")]
        public string AlarmingConfigurationFilename {
            get {
                return ((string)(this["AlarmingConfigurationFilename"]));
            }
            set {
                this["AlarmingConfigurationFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AlarmingEnabled {
            get {
                return ((bool)(this["AlarmingEnabled"]));
            }
            set {
                this["AlarmingEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MiataruConfiguration.config")]
        public string MiataruConfigurationFilename {
            get {
                return ((string)(this["MiataruConfigurationFilename"]));
            }
            set {
                this["MiataruConfigurationFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30000")]
        public int MiataruUpdateTime {
            get {
                return ((int)(this["MiataruUpdateTime"]));
            }
            set {
                this["MiataruUpdateTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MiataruEnabled {
            get {
                return ((bool)(this["MiataruEnabled"]));
            }
            set {
                this["MiataruEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sms77username")]
        public string AlarmingSMS77Username {
            get {
                return ((string)(this["AlarmingSMS77Username"]));
            }
            set {
                this["AlarmingSMS77Username"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sms77password")]
        public string AlarmingSMS77Password {
            get {
                return ((string)(this["AlarmingSMS77Password"]));
            }
            set {
                this["AlarmingSMS77Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0000000")]
        public string AlarmingSMS77SenderNumber {
            get {
                return ((string)(this["AlarmingSMS77SenderNumber"]));
            }
            set {
                this["AlarmingSMS77SenderNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("configuration")]
        public string ConfigurationDirectory {
            get {
                return ((string)(this["ConfigurationDirectory"]));
            }
            set {
                this["ConfigurationDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("data")]
        public string DataDirectory {
            get {
                return ((string)(this["DataDirectory"]));
            }
            set {
                this["DataDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ui")]
        public string HTTPDocumentRoot {
            get {
                return ((string)(this["HTTPDocumentRoot"]));
            }
            set {
                this["HTTPDocumentRoot"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool XMPPEnabled {
            get {
                return ((bool)(this["XMPPEnabled"]));
            }
            set {
                this["XMPPEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("XMPPConfiguration.config")]
        public string XMPPConfigurationFilename {
            get {
                return ((string)(this["XMPPConfigurationFilename"]));
            }
            set {
                this["XMPPConfigurationFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HTTPAuthEnabled {
            get {
                return ((bool)(this["HTTPAuthEnabled"]));
            }
            set {
                this["HTTPAuthEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("username")]
        public string HTTPAuthUsername {
            get {
                return ((string)(this["HTTPAuthUsername"]));
            }
            set {
                this["HTTPAuthUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("password")]
        public string HTTPAuthPassword {
            get {
                return ((string)(this["HTTPAuthPassword"]));
            }
            set {
                this["HTTPAuthPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.178")]
        public string HTTPAuthDisabledAdressStartsWith {
            get {
                return ((string)(this["HTTPAuthDisabledAdressStartsWith"]));
            }
            set {
                this["HTTPAuthDisabledAdressStartsWith"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("developergarden-client-id")]
        public string TelekomSMSClientID {
            get {
                return ((string)(this["TelekomSMSClientID"]));
            }
            set {
                this["TelekomSMSClientID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("developergarden-client-secret")]
        public string TelekomSMSClientSecret {
            get {
                return ((string)(this["TelekomSMSClientSecret"]));
            }
            set {
                this["TelekomSMSClientSecret"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseTelekomSMSInsteadofSMS77 {
            get {
                return ((bool)(this["UseTelekomSMSInsteadofSMS77"]));
            }
            set {
                this["UseTelekomSMSInsteadofSMS77"] = value;
            }
        }
    }
}
