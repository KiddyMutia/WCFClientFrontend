﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rent_HouseWeb.RoomTypeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoomTypeInfo", Namespace="http://schemas.datacontract.org/2004/07/WCFKostService")]
    [System.SerializableAttribute()]
    public partial class RoomTypeInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDRoomTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InfoMonthPaidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InfoRoomTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceRoomTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipeRoomTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalRoomTypeField;
        
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
        public string IDRoomType {
            get {
                return this.IDRoomTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.IDRoomTypeField, value) != true)) {
                    this.IDRoomTypeField = value;
                    this.RaisePropertyChanged("IDRoomType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InfoMonthPaid {
            get {
                return this.InfoMonthPaidField;
            }
            set {
                if ((object.ReferenceEquals(this.InfoMonthPaidField, value) != true)) {
                    this.InfoMonthPaidField = value;
                    this.RaisePropertyChanged("InfoMonthPaid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InfoRoomType {
            get {
                return this.InfoRoomTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.InfoRoomTypeField, value) != true)) {
                    this.InfoRoomTypeField = value;
                    this.RaisePropertyChanged("InfoRoomType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PriceRoomType {
            get {
                return this.PriceRoomTypeField;
            }
            set {
                if ((this.PriceRoomTypeField.Equals(value) != true)) {
                    this.PriceRoomTypeField = value;
                    this.RaisePropertyChanged("PriceRoomType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipeRoomType {
            get {
                return this.TipeRoomTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TipeRoomTypeField, value) != true)) {
                    this.TipeRoomTypeField = value;
                    this.RaisePropertyChanged("TipeRoomType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalRoomType {
            get {
                return this.TotalRoomTypeField;
            }
            set {
                if ((this.TotalRoomTypeField.Equals(value) != true)) {
                    this.TotalRoomTypeField = value;
                    this.RaisePropertyChanged("TotalRoomType");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RoomTypeService.IRoomTypeService")]
    public interface IRoomTypeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomTypeService/getTotalRoomType", ReplyAction="http://tempuri.org/IRoomTypeService/getTotalRoomTypeResponse")]
        Rent_HouseWeb.RoomTypeService.RoomTypeInfo[] getTotalRoomType();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomTypeService/getRoomType", ReplyAction="http://tempuri.org/IRoomTypeService/getRoomTypeResponse")]
        Rent_HouseWeb.RoomTypeService.RoomTypeInfo[] getRoomType();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomTypeService/getReservation", ReplyAction="http://tempuri.org/IRoomTypeService/getReservationResponse")]
        Rent_HouseWeb.RoomTypeService.RoomTypeInfo[] getReservation(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRoomTypeServiceChannel : Rent_HouseWeb.RoomTypeService.IRoomTypeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RoomTypeServiceClient : System.ServiceModel.ClientBase<Rent_HouseWeb.RoomTypeService.IRoomTypeService>, Rent_HouseWeb.RoomTypeService.IRoomTypeService {
        
        public RoomTypeServiceClient() {
        }
        
        public RoomTypeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RoomTypeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoomTypeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoomTypeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Rent_HouseWeb.RoomTypeService.RoomTypeInfo[] getTotalRoomType() {
            return base.Channel.getTotalRoomType();
        }
        
        public Rent_HouseWeb.RoomTypeService.RoomTypeInfo[] getRoomType() {
            return base.Channel.getRoomType();
        }
        
        public Rent_HouseWeb.RoomTypeService.RoomTypeInfo[] getReservation(string id) {
            return base.Channel.getReservation(id);
        }
    }
}
