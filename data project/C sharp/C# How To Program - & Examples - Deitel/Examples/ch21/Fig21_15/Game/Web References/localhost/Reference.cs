﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3512.0
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.0.3512.0.
// 
namespace Game.localhost {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BlackjackServiceSoap", Namespace="http://www.deitel.com/csphtp1/ch21/")]
    public class BlackjackService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public BlackjackService() {
            this.Url = "http://localhost/BlackjackWebService/BlackjackService.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.deitel.com/csphtp1/ch21/DealCard", RequestNamespace="http://www.deitel.com/csphtp1/ch21/", ResponseNamespace="http://www.deitel.com/csphtp1/ch21/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DealCard() {
            object[] results = this.Invoke("DealCard", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDealCard(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DealCard", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndDealCard(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.deitel.com/csphtp1/ch21/Shuffle", RequestNamespace="http://www.deitel.com/csphtp1/ch21/", ResponseNamespace="http://www.deitel.com/csphtp1/ch21/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Shuffle() {
            this.Invoke("Shuffle", new object[0]);
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginShuffle(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Shuffle", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public void EndShuffle(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.deitel.com/csphtp1/ch21/CountCards", RequestNamespace="http://www.deitel.com/csphtp1/ch21/", ResponseNamespace="http://www.deitel.com/csphtp1/ch21/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int CountCards(string dealt) {
            object[] results = this.Invoke("CountCards", new object[] {
                        dealt});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginCountCards(string dealt, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CountCards", new object[] {
                        dealt}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndCountCards(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
    }
}
