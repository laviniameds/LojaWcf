﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LojaWcf.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/LojaWcf")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Fabricante", Namespace="http://schemas.datacontract.org/2004/07/LojaWcf")]
    [System.SerializableAttribute()]
    public partial class Fabricante : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LojaWcf.ServiceReference1.Veiculo[] VeiculosField;
        
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
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LojaWcf.ServiceReference1.Veiculo[] Veiculos {
            get {
                return this.VeiculosField;
            }
            set {
                if ((object.ReferenceEquals(this.VeiculosField, value) != true)) {
                    this.VeiculosField = value;
                    this.RaisePropertyChanged("Veiculos");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Veiculo", Namespace="http://schemas.datacontract.org/2004/07/LojaWcf")]
    [System.SerializableAttribute()]
    public partial class Veiculo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DataVendaField;
        
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
        public System.Nullable<System.DateTime> DataVenda {
            get {
                return this.DataVendaField;
            }
            set {
                if ((this.DataVendaField.Equals(value) != true)) {
                    this.DataVendaField = value;
                    this.RaisePropertyChanged("DataVenda");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        LojaWcf.ServiceReference1.CompositeType GetDataUsingDataContract(LojaWcf.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<LojaWcf.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(LojaWcf.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FabricanteSelect", ReplyAction="http://tempuri.org/IService1/FabricanteSelectResponse")]
        LojaWcf.ServiceReference1.Fabricante[] FabricanteSelect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FabricanteSelect", ReplyAction="http://tempuri.org/IService1/FabricanteSelectResponse")]
        System.Threading.Tasks.Task<LojaWcf.ServiceReference1.Fabricante[]> FabricanteSelectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FabricanteInsert", ReplyAction="http://tempuri.org/IService1/FabricanteInsertResponse")]
        void FabricanteInsert(int id, string descricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FabricanteInsert", ReplyAction="http://tempuri.org/IService1/FabricanteInsertResponse")]
        System.Threading.Tasks.Task FabricanteInsertAsync(int id, string descricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FabricanteUpdate", ReplyAction="http://tempuri.org/IService1/FabricanteUpdateResponse")]
        void FabricanteUpdate(int id, string descricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FabricanteUpdate", ReplyAction="http://tempuri.org/IService1/FabricanteUpdateResponse")]
        System.Threading.Tasks.Task FabricanteUpdateAsync(int id, string descricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FabricanteDelete", ReplyAction="http://tempuri.org/IService1/FabricanteDeleteResponse")]
        void FabricanteDelete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FabricanteDelete", ReplyAction="http://tempuri.org/IService1/FabricanteDeleteResponse")]
        System.Threading.Tasks.Task FabricanteDeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VeiculoSelectDisponiveis", ReplyAction="http://tempuri.org/IService1/VeiculoSelectDisponiveisResponse")]
        LojaWcf.ServiceReference1.Veiculo[] VeiculoSelectDisponiveis();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VeiculoSelectDisponiveis", ReplyAction="http://tempuri.org/IService1/VeiculoSelectDisponiveisResponse")]
        System.Threading.Tasks.Task<LojaWcf.ServiceReference1.Veiculo[]> VeiculoSelectDisponiveisAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VeiculoInsert", ReplyAction="http://tempuri.org/IService1/VeiculoInsertResponse")]
        void VeiculoInsert(int id, string modelo, int ano, int idFab, System.DateTime dataCompra, decimal valorCompra, decimal precoVenda, System.DateTime dataVenda, decimal valorVenda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VeiculoInsert", ReplyAction="http://tempuri.org/IService1/VeiculoInsertResponse")]
        System.Threading.Tasks.Task VeiculoInsertAsync(int id, string modelo, int ano, int idFab, System.DateTime dataCompra, decimal valorCompra, decimal precoVenda, System.DateTime dataVenda, decimal valorVenda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VeiculoUpdate", ReplyAction="http://tempuri.org/IService1/VeiculoUpdateResponse")]
        void VeiculoUpdate(int id, string modelo, int ano, int idFab, System.DateTime dataCompra, decimal valorCompra, decimal precoVenda, System.DateTime dataVenda, decimal valorVenda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VeiculoUpdate", ReplyAction="http://tempuri.org/IService1/VeiculoUpdateResponse")]
        System.Threading.Tasks.Task VeiculoUpdateAsync(int id, string modelo, int ano, int idFab, System.DateTime dataCompra, decimal valorCompra, decimal precoVenda, System.DateTime dataVenda, decimal valorVenda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VeiculoDelete", ReplyAction="http://tempuri.org/IService1/VeiculoDeleteResponse")]
        void VeiculoDelete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VeiculoDelete", ReplyAction="http://tempuri.org/IService1/VeiculoDeleteResponse")]
        System.Threading.Tasks.Task VeiculoDeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : LojaWcf.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<LojaWcf.ServiceReference1.IService1>, LojaWcf.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public LojaWcf.ServiceReference1.CompositeType GetDataUsingDataContract(LojaWcf.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<LojaWcf.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(LojaWcf.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public LojaWcf.ServiceReference1.Fabricante[] FabricanteSelect() {
            return base.Channel.FabricanteSelect();
        }
        
        public System.Threading.Tasks.Task<LojaWcf.ServiceReference1.Fabricante[]> FabricanteSelectAsync() {
            return base.Channel.FabricanteSelectAsync();
        }
        
        public void FabricanteInsert(int id, string descricao) {
            base.Channel.FabricanteInsert(id, descricao);
        }
        
        public System.Threading.Tasks.Task FabricanteInsertAsync(int id, string descricao) {
            return base.Channel.FabricanteInsertAsync(id, descricao);
        }
        
        public void FabricanteUpdate(int id, string descricao) {
            base.Channel.FabricanteUpdate(id, descricao);
        }
        
        public System.Threading.Tasks.Task FabricanteUpdateAsync(int id, string descricao) {
            return base.Channel.FabricanteUpdateAsync(id, descricao);
        }
        
        public void FabricanteDelete(int id) {
            base.Channel.FabricanteDelete(id);
        }
        
        public System.Threading.Tasks.Task FabricanteDeleteAsync(int id) {
            return base.Channel.FabricanteDeleteAsync(id);
        }
        
        public LojaWcf.ServiceReference1.Veiculo[] VeiculoSelectDisponiveis() {
            return base.Channel.VeiculoSelectDisponiveis();
        }
        
        public System.Threading.Tasks.Task<LojaWcf.ServiceReference1.Veiculo[]> VeiculoSelectDisponiveisAsync() {
            return base.Channel.VeiculoSelectDisponiveisAsync();
        }
        
        public void VeiculoInsert(int id, string modelo, int ano, int idFab, System.DateTime dataCompra, decimal valorCompra, decimal precoVenda, System.DateTime dataVenda, decimal valorVenda) {
            base.Channel.VeiculoInsert(id, modelo, ano, idFab, dataCompra, valorCompra, precoVenda, dataVenda, valorVenda);
        }
        
        public System.Threading.Tasks.Task VeiculoInsertAsync(int id, string modelo, int ano, int idFab, System.DateTime dataCompra, decimal valorCompra, decimal precoVenda, System.DateTime dataVenda, decimal valorVenda) {
            return base.Channel.VeiculoInsertAsync(id, modelo, ano, idFab, dataCompra, valorCompra, precoVenda, dataVenda, valorVenda);
        }
        
        public void VeiculoUpdate(int id, string modelo, int ano, int idFab, System.DateTime dataCompra, decimal valorCompra, decimal precoVenda, System.DateTime dataVenda, decimal valorVenda) {
            base.Channel.VeiculoUpdate(id, modelo, ano, idFab, dataCompra, valorCompra, precoVenda, dataVenda, valorVenda);
        }
        
        public System.Threading.Tasks.Task VeiculoUpdateAsync(int id, string modelo, int ano, int idFab, System.DateTime dataCompra, decimal valorCompra, decimal precoVenda, System.DateTime dataVenda, decimal valorVenda) {
            return base.Channel.VeiculoUpdateAsync(id, modelo, ano, idFab, dataCompra, valorCompra, precoVenda, dataVenda, valorVenda);
        }
        
        public void VeiculoDelete(int id) {
            base.Channel.VeiculoDelete(id);
        }
        
        public System.Threading.Tasks.Task VeiculoDeleteAsync(int id) {
            return base.Channel.VeiculoDeleteAsync(id);
        }
    }
}
