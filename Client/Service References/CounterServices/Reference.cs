﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.CounterServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.artech.com/", ConfigurationName="CounterServices.CalculatorService")]
    public interface CalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.artech.com/CalculatorService/Add", ReplyAction="http://www.artech.com/CalculatorService/AddResponse")]
        double Add(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.artech.com/CalculatorService/Subtract", ReplyAction="http://www.artech.com/CalculatorService/SubtractResponse")]
        double Subtract(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.artech.com/CalculatorService/Multiply", ReplyAction="http://www.artech.com/CalculatorService/MultiplyResponse")]
        double Multiply(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.artech.com/CalculatorService/Divide", ReplyAction="http://www.artech.com/CalculatorService/DivideResponse")]
        double Divide(double x, double y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorServiceChannel : Client.CounterServices.CalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.ClientBase<Client.CounterServices.CalculatorService>, Client.CounterServices.CalculatorService {
        
        public CalculatorServiceClient() {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double x, double y) {
            return base.Channel.Add(x, y);
        }
        
        public double Subtract(double x, double y) {
            return base.Channel.Subtract(x, y);
        }
        
        public double Multiply(double x, double y) {
            return base.Channel.Multiply(x, y);
        }
        
        public double Divide(double x, double y) {
            return base.Channel.Divide(x, y);
        }
    }
}
