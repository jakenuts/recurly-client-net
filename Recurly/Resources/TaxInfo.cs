using System;
using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Recurly.Resources {
  public class TaxInfo : Resource {
  
    /// <value>Rate</value>
    [DeserializeAs(Name = "rate")]
    public float? Rate { get; set; }
  
    /// <value>Provides the tax region applied on an invoice. For U.S. Sales Tax, this will be the 2 letter state code. For EU VAT this will be the 2 letter country code. For all country level tax types, this will display the regional tax, like VAT, GST, or PST.</value>
    [DeserializeAs(Name = "region")]
    public string Region { get; set; }
  
    /// <value>Provides the tax type as "vat" for EU VAT, "usst" for U.S. Sales Tax, or the 2 letter country code for country level tax types like Canada, Australia, New Zealand, Israel, and all non-EU European countries.</value>
    [DeserializeAs(Name = "type")]
    public string Type { get; set; }
  
  }
}
