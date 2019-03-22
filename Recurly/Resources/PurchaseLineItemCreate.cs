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
  public class PurchaseLineItemCreate : Request {
  
    /// <value>The reason the credit was given when line item is `type=credit`. When the Credit Invoices feature is enabled, the value can be set and will default to `general`. When the Credit Invoices feature is not enabled, the value will always be `null`.</value>
    [JsonProperty("credit_reason_code")]
    public string CreditReasonCode { get; set; }
  
    /// <value>Description that appears on the invoice.</value>
    [JsonProperty("description")]
    public string Description { get; set; }
  
    /// <value>If this date is provided, it indicates the end of a time range.</value>
    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }
  
    /// <value>This number will be multiplied by the unit amount to compute the subtotal before any discounts or taxes.</value>
    [JsonProperty("quantity")]
    public int? Quantity { get; set; }
  
    /// <value>Create a shipping address on the account and assign it to the line item.</value>
    [JsonProperty("shipping_address")]
    public Dictionary<string, string> ShippingAddress { get; set; }
  
    /// <value>Assign a shipping address from the account's existing shipping addresses. If this and `shipping_address` are both present, `shipping_address` will take precedence.</value>
    [JsonProperty("shipping_address_id")]
    public string ShippingAddressId { get; set; }
  
    /// <value>If an end date is present, this is value indicates the beginning of a billing time range. If no end date is present it indicates billing for a specific date. Defaults to the current date-time.</value>
    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }
  
    /// <value>Optional field for EU VAT merchants and Avalara AvaTax Pro merchants. If you are using Recurly's EU VAT feature, you can use values of unknown, physical, or digital. If you have your own AvaTax account configured, you can use Avalara tax codes to assign custom tax rules.</value>
    [JsonProperty("tax_code")]
    public string TaxCode { get; set; }
  
    /// <value>`true` exempts tax on charges, `false` applies tax on charges. If not defined, then defaults to the Plan and Site settings. This attribute does not work for credits (negative line items). Credits are always applied post-tax. Pre-tax discounts should use the Coupons feature.</value>
    [JsonProperty("tax_exempt")]
    public bool? TaxExempt { get; set; }
  
    /// <value>Line item type.</value>
    [JsonProperty("type")]
    public string Type { get; set; }
  
    /// <value>
    /// A positive or negative amount with `type=charge` will result in a positive `unit_amount`.
    /// A positive or negative amount with `type=credit` will result in a negative `unit_amount`.
    /// </value>
    [JsonProperty("unit_amount")]
    public float? UnitAmount { get; set; }
  
  }
}
