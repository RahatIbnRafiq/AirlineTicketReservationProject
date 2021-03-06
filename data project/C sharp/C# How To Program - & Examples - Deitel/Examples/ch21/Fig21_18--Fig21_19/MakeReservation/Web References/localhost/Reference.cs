﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3328.4
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.0.3328.4.
// 
namespace MakeReservation.localhost {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ReservationSoap", Namespace="http://www.deitel.com/csphtp1/ch21/")]
    public class Reservation : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public Reservation() {
            this.Url = "http://localhost/AirlineReservation/Reservation.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.deitel.com/csphtp1/ch21/Reserve", RequestNamespace="http://www.deitel.com/csphtp1/ch21/", ResponseNamespace="http://www.deitel.com/csphtp1/ch21/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Reserve(string seatType, string classType) {
            object[] results = this.Invoke("Reserve", new object[] {
                        seatType,
                        classType});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReserve(string seatType, string classType, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Reserve", new object[] {
                        seatType,
                        classType}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndReserve(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
    }
}
