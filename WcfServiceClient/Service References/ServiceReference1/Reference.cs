﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IOperation1")]
    public interface IOperation1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperation1/sumNumbersBetween", ReplyAction="http://tempuri.org/IOperation1/sumNumbersBetweenResponse")]
        int sumNumbersBetween(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperation1/sumNumbersBetween", ReplyAction="http://tempuri.org/IOperation1/sumNumbersBetweenResponse")]
        System.Threading.Tasks.Task<int> sumNumbersBetweenAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperation1/modulo", ReplyAction="http://tempuri.org/IOperation1/moduloResponse")]
        int modulo(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperation1/modulo", ReplyAction="http://tempuri.org/IOperation1/moduloResponse")]
        System.Threading.Tasks.Task<int> moduloAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOperation1Channel : WcfServiceClient.ServiceReference1.IOperation1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Operation1Client : System.ServiceModel.ClientBase<WcfServiceClient.ServiceReference1.IOperation1>, WcfServiceClient.ServiceReference1.IOperation1 {
        
        public Operation1Client() {
        }
        
        public Operation1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Operation1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Operation1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Operation1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int sumNumbersBetween(int a, int b) {
            return base.Channel.sumNumbersBetween(a, b);
        }
        
        public System.Threading.Tasks.Task<int> sumNumbersBetweenAsync(int a, int b) {
            return base.Channel.sumNumbersBetweenAsync(a, b);
        }
        
        public int modulo(int a, int b) {
            return base.Channel.modulo(a, b);
        }
        
        public System.Threading.Tasks.Task<int> moduloAsync(int a, int b) {
            return base.Channel.moduloAsync(a, b);
        }
    }
}