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
  public class SubscriptionShippingUpdate : Request {
  
    /// <value>Create a shipping address on the account and assign it to the subscription. If this and `shipping_address_id` are both present, `shipping_address_id` will take precedence."</value>
    [JsonProperty("address")]
    public Dictionary<string, string> Address { get; set; }
  
    /// <value>Assign a shipping address from the account's existing shipping addresses.</value>
    [JsonProperty("address_id")]
    public string AddressId { get; set; }
  
  }
}
