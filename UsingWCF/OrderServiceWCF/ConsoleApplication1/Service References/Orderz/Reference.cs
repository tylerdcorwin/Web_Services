﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.Orderz {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/OrderServiceWCF")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PartNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TotalCostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UnitPriceField;
        
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
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PartNo {
            get {
                return this.PartNoField;
            }
            set {
                if ((object.ReferenceEquals(this.PartNoField, value) != true)) {
                    this.PartNoField = value;
                    this.RaisePropertyChanged("PartNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((object.ReferenceEquals(this.QuantityField, value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Size {
            get {
                return this.SizeField;
            }
            set {
                if ((object.ReferenceEquals(this.SizeField, value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TotalCost {
            get {
                return this.TotalCostField;
            }
            set {
                if ((object.ReferenceEquals(this.TotalCostField, value) != true)) {
                    this.TotalCostField = value;
                    this.RaisePropertyChanged("TotalCost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((object.ReferenceEquals(this.UnitPriceField, value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BillingInformation", Namespace="http://schemas.datacontract.org/2004/07/OrderServiceWCF")]
    [System.SerializableAttribute()]
    public partial class BillingInformation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipCodeField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
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
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ZipCode {
            get {
                return this.ZipCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipCodeField, value) != true)) {
                    this.ZipCodeField = value;
                    this.RaisePropertyChanged("ZipCode");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Orderz.IOrderService")]
    public interface IOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetNumberOfOrders", ReplyAction="http://tempuri.org/IOrderService/GetNumberOfOrdersResponse")]
        int GetNumberOfOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetNumberOfOrders", ReplyAction="http://tempuri.org/IOrderService/GetNumberOfOrdersResponse")]
        System.Threading.Tasks.Task<int> GetNumberOfOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetTotalCostForAnOrder", ReplyAction="http://tempuri.org/IOrderService/GetTotalCostForAnOrderResponse")]
        double GetTotalCostForAnOrder(int OrderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetTotalCostForAnOrder", ReplyAction="http://tempuri.org/IOrderService/GetTotalCostForAnOrderResponse")]
        System.Threading.Tasks.Task<double> GetTotalCostForAnOrderAsync(int OrderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetItemListForOrder", ReplyAction="http://tempuri.org/IOrderService/GetItemListForOrderResponse")]
        ConsoleApplication1.Orderz.Item[] GetItemListForOrder(int OrderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetItemListForOrder", ReplyAction="http://tempuri.org/IOrderService/GetItemListForOrderResponse")]
        System.Threading.Tasks.Task<ConsoleApplication1.Orderz.Item[]> GetItemListForOrderAsync(int OrderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/HowManyOrderedForAPartNo", ReplyAction="http://tempuri.org/IOrderService/HowManyOrderedForAPartNoResponse")]
        int HowManyOrderedForAPartNo(string sPartNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/HowManyOrderedForAPartNo", ReplyAction="http://tempuri.org/IOrderService/HowManyOrderedForAPartNoResponse")]
        System.Threading.Tasks.Task<int> HowManyOrderedForAPartNoAsync(string sPartNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetBillinAddressForAnOrder", ReplyAction="http://tempuri.org/IOrderService/GetBillinAddressForAnOrderResponse")]
        ConsoleApplication1.Orderz.BillingInformation GetBillinAddressForAnOrder(int OrderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetBillinAddressForAnOrder", ReplyAction="http://tempuri.org/IOrderService/GetBillinAddressForAnOrderResponse")]
        System.Threading.Tasks.Task<ConsoleApplication1.Orderz.BillingInformation> GetBillinAddressForAnOrderAsync(int OrderID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderServiceChannel : ConsoleApplication1.Orderz.IOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceClient : System.ServiceModel.ClientBase<ConsoleApplication1.Orderz.IOrderService>, ConsoleApplication1.Orderz.IOrderService {
        
        public OrderServiceClient() {
        }
        
        public OrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetNumberOfOrders() {
            return base.Channel.GetNumberOfOrders();
        }
        
        public System.Threading.Tasks.Task<int> GetNumberOfOrdersAsync() {
            return base.Channel.GetNumberOfOrdersAsync();
        }
        
        public double GetTotalCostForAnOrder(int OrderID) {
            return base.Channel.GetTotalCostForAnOrder(OrderID);
        }
        
        public System.Threading.Tasks.Task<double> GetTotalCostForAnOrderAsync(int OrderID) {
            return base.Channel.GetTotalCostForAnOrderAsync(OrderID);
        }
        
        public ConsoleApplication1.Orderz.Item[] GetItemListForOrder(int OrderID) {
            return base.Channel.GetItemListForOrder(OrderID);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.Orderz.Item[]> GetItemListForOrderAsync(int OrderID) {
            return base.Channel.GetItemListForOrderAsync(OrderID);
        }
        
        public int HowManyOrderedForAPartNo(string sPartNo) {
            return base.Channel.HowManyOrderedForAPartNo(sPartNo);
        }
        
        public System.Threading.Tasks.Task<int> HowManyOrderedForAPartNoAsync(string sPartNo) {
            return base.Channel.HowManyOrderedForAPartNoAsync(sPartNo);
        }
        
        public ConsoleApplication1.Orderz.BillingInformation GetBillinAddressForAnOrder(int OrderID) {
            return base.Channel.GetBillinAddressForAnOrder(OrderID);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.Orderz.BillingInformation> GetBillinAddressForAnOrderAsync(int OrderID) {
            return base.Channel.GetBillinAddressForAnOrderAsync(OrderID);
        }
    }
}