/**
 * This file is automatically created by Recurly's OpenAPI generation process
 * and thus any edits you make by hand will be lost. If you wish to make a
 * change to this file, please create a Github issue explaining the changes you
 * need and we will usher them to the appropriate places.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Recurly.Resources {
  [ExcludeFromCodeCoverage] 
  public class CouponDiscount : Resource {
  
    
    [JsonProperty("currencies")]
    public List<CouponDiscountPricing> Currencies { get; set; }
  
    
    [JsonProperty("percent")]
    public int? Percent { get; set; }
  
    
    [JsonProperty("trial")]
    public Dictionary<string, string> Trial { get; set; }
  
    
    [JsonProperty("type")]
    public string Type { get; set; }
  
  }
}
