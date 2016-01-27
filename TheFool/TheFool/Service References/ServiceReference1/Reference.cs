﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheFool.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/ChatService")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Passwd {
            get {
                return this.PasswdField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswdField, value) != true)) {
                    this.PasswdField = value;
                    this.RaisePropertyChanged("Passwd");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="DurakService", ConfigurationName="ServiceReference1.IChat", CallbackContract=typeof(TheFool.ServiceReference1.IChatCallback))]
    public interface IChat {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="DurakService/IChat/StartChatSession")]
        void StartChatSession(string player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="DurakService/IChat/StartChatSession")]
        System.Threading.Tasks.Task StartChatSessionAsync(string player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="DurakService/IChat/addPlyer")]
        void addPlyer(TheFool.ServiceReference1.Player player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="DurakService/IChat/addPlyer")]
        System.Threading.Tasks.Task addPlyerAsync(TheFool.ServiceReference1.Player player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="DurakService/IChat/PostChatMessage")]
        void PostChatMessage(string message, string postername, string opponent);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="DurakService/IChat/PostChatMessage")]
        System.Threading.Tasks.Task PostChatMessageAsync(string message, string postername, string opponent);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="DurakService/IChat/createNewUser")]
        void createNewUser(string name, string psw);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="DurakService/IChat/createNewUser")]
        System.Threading.Tasks.Task createNewUserAsync(string name, string psw);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="DurakService/IChat/UpdateChatMessages", ReplyAction="DurakService/IChat/UpdateChatMessagesResponse")]
        void UpdateChatMessages(string message, string playername);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatChannel : TheFool.ServiceReference1.IChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatClient : System.ServiceModel.DuplexClientBase<TheFool.ServiceReference1.IChat>, TheFool.ServiceReference1.IChat {
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void StartChatSession(string player) {
            base.Channel.StartChatSession(player);
        }
        
        public System.Threading.Tasks.Task StartChatSessionAsync(string player) {
            return base.Channel.StartChatSessionAsync(player);
        }
        
        public void addPlyer(TheFool.ServiceReference1.Player player) {
            base.Channel.addPlyer(player);
        }
        
        public System.Threading.Tasks.Task addPlyerAsync(TheFool.ServiceReference1.Player player) {
            return base.Channel.addPlyerAsync(player);
        }
        
        public void PostChatMessage(string message, string postername, string opponent) {
            base.Channel.PostChatMessage(message, postername, opponent);
        }
        
        public System.Threading.Tasks.Task PostChatMessageAsync(string message, string postername, string opponent) {
            return base.Channel.PostChatMessageAsync(message, postername, opponent);
        }
        
        public void createNewUser(string name, string psw) {
            base.Channel.createNewUser(name, psw);
        }
        
        public System.Threading.Tasks.Task createNewUserAsync(string name, string psw) {
            return base.Channel.createNewUserAsync(name, psw);
        }
    }
}