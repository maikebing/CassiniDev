﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CassiniDev.FixtureExamples.NUnit.TestWebServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HelloWorldArgs", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class HelloWorldArgs : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TestWebServiceReference.TestWebServiceSoap")]
    public interface TestWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldResponse HelloWorld(CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name args from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorldWithArgsInOut", ReplyAction="*")]
        CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldWithArgsInOutResponse HelloWorldWithArgsInOut(CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldWithArgsInOutRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldWithArgsInOutRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldWithArgsInOut", Namespace="http://tempuri.org/", Order=0)]
        public CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldWithArgsInOutRequestBody Body;
        
        public HelloWorldWithArgsInOutRequest() {
        }
        
        public HelloWorldWithArgsInOutRequest(CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldWithArgsInOutRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldWithArgsInOutRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldArgs args;
        
        public HelloWorldWithArgsInOutRequestBody() {
        }
        
        public HelloWorldWithArgsInOutRequestBody(CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldArgs args) {
            this.args = args;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldWithArgsInOutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldWithArgsInOutResponse", Namespace="http://tempuri.org/", Order=0)]
        public CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldWithArgsInOutResponseBody Body;
        
        public HelloWorldWithArgsInOutResponse() {
        }
        
        public HelloWorldWithArgsInOutResponse(CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldWithArgsInOutResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldWithArgsInOutResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldArgs HelloWorldWithArgsInOutResult;
        
        public HelloWorldWithArgsInOutResponseBody() {
        }
        
        public HelloWorldWithArgsInOutResponseBody(CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldArgs HelloWorldWithArgsInOutResult) {
            this.HelloWorldWithArgsInOutResult = HelloWorldWithArgsInOutResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface TestWebServiceSoapChannel : CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.TestWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class TestWebServiceSoapClient : System.ServiceModel.ClientBase<CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.TestWebServiceSoap>, CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.TestWebServiceSoap {
        
        public TestWebServiceSoapClient() {
        }
        
        public TestWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldResponse CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.TestWebServiceSoap.HelloWorld(CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldRequest inValue = new CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldRequest();
            inValue.Body = new CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldRequestBody();
            CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldResponse retVal = ((CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.TestWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldWithArgsInOutResponse CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.TestWebServiceSoap.HelloWorldWithArgsInOut(CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldWithArgsInOutRequest request) {
            return base.Channel.HelloWorldWithArgsInOut(request);
        }
        
        public CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldArgs HelloWorldWithArgsInOut(CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldArgs args) {
            CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldWithArgsInOutRequest inValue = new CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldWithArgsInOutRequest();
            inValue.Body = new CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldWithArgsInOutRequestBody();
            inValue.Body.args = args;
            CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.HelloWorldWithArgsInOutResponse retVal = ((CassiniDev.FixtureExamples.NUnit.TestWebServiceReference.TestWebServiceSoap)(this)).HelloWorldWithArgsInOut(inValue);
            return retVal.Body.HelloWorldWithArgsInOutResult;
        }
    }
}
