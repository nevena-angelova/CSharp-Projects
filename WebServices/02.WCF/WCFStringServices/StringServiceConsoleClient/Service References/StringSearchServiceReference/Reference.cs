﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StringServiceConsoleClient.StringSearchServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StringSearchServiceReference.IStringSearchService")]
    public interface IStringSearchService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringSearchService/StringFoundCount", ReplyAction="http://tempuri.org/IStringSearchService/StringFoundCountResponse")]
        int StringFoundCount(string text, string searched);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringSearchService/StringFoundCount", ReplyAction="http://tempuri.org/IStringSearchService/StringFoundCountResponse")]
        System.Threading.Tasks.Task<int> StringFoundCountAsync(string text, string searched);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStringSearchServiceChannel : StringServiceConsoleClient.StringSearchServiceReference.IStringSearchService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StringSearchServiceClient : System.ServiceModel.ClientBase<StringServiceConsoleClient.StringSearchServiceReference.IStringSearchService>, StringServiceConsoleClient.StringSearchServiceReference.IStringSearchService {
        
        public StringSearchServiceClient() {
        }
        
        public StringSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StringSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StringSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StringSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int StringFoundCount(string text, string searched) {
            return base.Channel.StringFoundCount(text, searched);
        }
        
        public System.Threading.Tasks.Task<int> StringFoundCountAsync(string text, string searched) {
            return base.Channel.StringFoundCountAsync(text, searched);
        }
    }
}
