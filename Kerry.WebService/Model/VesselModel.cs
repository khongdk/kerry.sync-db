using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kerry.WebService.Model
{
    public class VesselModel
    {
        
        public string vesselCode { get; set; }
        public string vesselName { get; set; }
        public string vesselNameLocal { get; set; }
        public string companyCode { get; set; }
        public string shippingLineShortName{ get; set; }
        public string regCountryCode { get; set; }
        public string lane { get; set; }
        public string callSignNo { get; set; }
        public string imoNo { get; set; }
        public string unCode { get; set; }
        public string hanjinCode { get; set; }
    }
}