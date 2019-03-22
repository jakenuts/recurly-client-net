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
  public class SubscriptionShipping : Resource {
  
    /// <value>Subscription's shipping cost</value>
    [JsonProperty("amount")]
    public float? Amount { get; set; }
  
    
    [JsonProperty("shipping_address")]
    public ShippingAddress ShippingAddress { get; set; }
  
    
    [JsonProperty("shipping_method")]
    public ShippingMethodMini ShippingMethod { get; set; }
  
  }
}
