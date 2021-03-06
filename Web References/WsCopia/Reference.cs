﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.985
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.985.
// 
namespace TesteCopias.WsCopia {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WsCopiaSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VO))]
    public class WsCopia : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        public SoapLogin SoapLoginValue;
        
        /// <remarks/>
        public WsCopia() {
            this.Url = "http://www.portalctf.com.br/PortalCopias/wscopia.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("SoapLoginValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListarTemplatesDisponiveis", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ListarTemplatesDisponiveis() {
            object[] results = this.Invoke("ListarTemplatesDisponiveis", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginListarTemplatesDisponiveis(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ListarTemplatesDisponiveis", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndListarTemplatesDisponiveis(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("SoapLoginValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RecuperarCopia", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RecuperarCopia(ParametrosCopia parametroCopia) {
            object[] results = this.Invoke("RecuperarCopia", new object[] {
                        parametroCopia});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginRecuperarCopia(ParametrosCopia parametroCopia, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("RecuperarCopia", new object[] {
                        parametroCopia}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndRecuperarCopia(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public class SoapLogin : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        public string login;
        
        /// <remarks/>
        public string senha;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParametrosCopia))]
    public class VO {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public class ParametrosCopia : VO {
        
        /// <remarks/>
        public int Ponteiro;
        
        /// <remarks/>
        public int CodTemplate;
        
        /// <remarks/>
        public int QtdRegistro;
    }
}
