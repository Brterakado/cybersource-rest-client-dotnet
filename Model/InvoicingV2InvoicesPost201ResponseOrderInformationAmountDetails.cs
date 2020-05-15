/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Contains all of the amount-related fields in the invoice.
    /// </summary>
    [DataContract]
    public partial class InvoicingV2InvoicesPost201ResponseOrderInformationAmountDetails :  IEquatable<InvoicingV2InvoicesPost201ResponseOrderInformationAmountDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicingV2InvoicesPost201ResponseOrderInformationAmountDetails" /> class.
        /// </summary>
        /// <param name="TotalAmount">Grand total for the order. This value cannot be negative. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places.  **Note** For CTV, FDCCompass, Paymentech processors, the maximum length for this field is 12.  **Important** Some processors have specific requirements and limitations, such as maximum amounts and maximum field lengths. For details, see: - \&quot;Authorization Information for Specific Processors\&quot; in the [Credit Card Services Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/). - \&quot;Capture Information for Specific Processors\&quot; in the [Credit Card Services Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/). - \&quot;Credit Information for Specific Processors\&quot; in the [Credit Card Services Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/).  If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen. For details, see \&quot;Zero Amount Authorizations,\&quot; \&quot;Credit Information for Specific Processors\&quot; in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  #### Card Present Required to include either this field or &#x60;orderInformation.lineItems[].unitPrice&#x60; for the order.  #### GPX This field is optional for reversing an authorization or credit; however, for all other processors, these fields are required.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either this field or the 1st line item in the order and the specific line-order amount in your request. For details, see &#x60;grand_total_amount&#x60; field description in [Dynamic Currency Conversion For First Data Using the SCMP API](http://apps.cybersource.com/library/documentation/dev_guides/DCC_FirstData_SCMP/DCC_FirstData_SCMP_API.pdf).  #### FDMS South If you accept IDR or CLP currencies, see the entry for FDMS South in \&quot;Authorization Information for Specific Processors\&quot; of the [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  #### DCC for First Data Not used.  #### Invoicing Required for creating a new invoice. .</param>
        /// <param name="Currency">Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency. .</param>
        /// <param name="BalanceAmount">Remaining balance on the account.  Returned by authorization service. .</param>
        /// <param name="DiscountAmount">Total discount amount applied to the order.  For processor-specific information, see the order_discount_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="DiscountPercent">The total discount percentage applied to the invoice..</param>
        /// <param name="SubAmount">Sub-amount of the invoice..</param>
        /// <param name="MinimumPartialAmount">The minimum partial amount required to pay the invoice..</param>
        /// <param name="TaxDetails">TaxDetails.</param>
        /// <param name="Freight">Freight.</param>
        public InvoicingV2InvoicesPost201ResponseOrderInformationAmountDetails(string TotalAmount = default(string), string Currency = default(string), string BalanceAmount = default(string), string DiscountAmount = default(string), decimal? DiscountPercent = default(decimal?), decimal? SubAmount = default(decimal?), decimal? MinimumPartialAmount = default(decimal?), Invoicingv2invoicesOrderInformationAmountDetailsTaxDetails TaxDetails = default(Invoicingv2invoicesOrderInformationAmountDetailsTaxDetails), Invoicingv2invoicesOrderInformationAmountDetailsFreight Freight = default(Invoicingv2invoicesOrderInformationAmountDetailsFreight))
        {
            this.TotalAmount = TotalAmount;
            this.Currency = Currency;
            this.BalanceAmount = BalanceAmount;
            this.DiscountAmount = DiscountAmount;
            this.DiscountPercent = DiscountPercent;
            this.SubAmount = SubAmount;
            this.MinimumPartialAmount = MinimumPartialAmount;
            this.TaxDetails = TaxDetails;
            this.Freight = Freight;
        }
        
        /// <summary>
        /// Grand total for the order. This value cannot be negative. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places.  **Note** For CTV, FDCCompass, Paymentech processors, the maximum length for this field is 12.  **Important** Some processors have specific requirements and limitations, such as maximum amounts and maximum field lengths. For details, see: - \&quot;Authorization Information for Specific Processors\&quot; in the [Credit Card Services Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/). - \&quot;Capture Information for Specific Processors\&quot; in the [Credit Card Services Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/). - \&quot;Credit Information for Specific Processors\&quot; in the [Credit Card Services Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/).  If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen. For details, see \&quot;Zero Amount Authorizations,\&quot; \&quot;Credit Information for Specific Processors\&quot; in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  #### Card Present Required to include either this field or &#x60;orderInformation.lineItems[].unitPrice&#x60; for the order.  #### GPX This field is optional for reversing an authorization or credit; however, for all other processors, these fields are required.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either this field or the 1st line item in the order and the specific line-order amount in your request. For details, see &#x60;grand_total_amount&#x60; field description in [Dynamic Currency Conversion For First Data Using the SCMP API](http://apps.cybersource.com/library/documentation/dev_guides/DCC_FirstData_SCMP/DCC_FirstData_SCMP_API.pdf).  #### FDMS South If you accept IDR or CLP currencies, see the entry for FDMS South in \&quot;Authorization Information for Specific Processors\&quot; of the [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  #### DCC for First Data Not used.  #### Invoicing Required for creating a new invoice. 
        /// </summary>
        /// <value>Grand total for the order. This value cannot be negative. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places.  **Note** For CTV, FDCCompass, Paymentech processors, the maximum length for this field is 12.  **Important** Some processors have specific requirements and limitations, such as maximum amounts and maximum field lengths. For details, see: - \&quot;Authorization Information for Specific Processors\&quot; in the [Credit Card Services Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/). - \&quot;Capture Information for Specific Processors\&quot; in the [Credit Card Services Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/). - \&quot;Credit Information for Specific Processors\&quot; in the [Credit Card Services Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/).  If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen. For details, see \&quot;Zero Amount Authorizations,\&quot; \&quot;Credit Information for Specific Processors\&quot; in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  #### Card Present Required to include either this field or &#x60;orderInformation.lineItems[].unitPrice&#x60; for the order.  #### GPX This field is optional for reversing an authorization or credit; however, for all other processors, these fields are required.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either this field or the 1st line item in the order and the specific line-order amount in your request. For details, see &#x60;grand_total_amount&#x60; field description in [Dynamic Currency Conversion For First Data Using the SCMP API](http://apps.cybersource.com/library/documentation/dev_guides/DCC_FirstData_SCMP/DCC_FirstData_SCMP_API.pdf).  #### FDMS South If you accept IDR or CLP currencies, see the entry for FDMS South in \&quot;Authorization Information for Specific Processors\&quot; of the [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  #### DCC for First Data Not used.  #### Invoicing Required for creating a new invoice. </value>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency. 
        /// </summary>
        /// <value>Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency. </value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Remaining balance on the account.  Returned by authorization service. 
        /// </summary>
        /// <value>Remaining balance on the account.  Returned by authorization service. </value>
        [DataMember(Name="balanceAmount", EmitDefaultValue=false)]
        public string BalanceAmount { get; set; }

        /// <summary>
        /// Total discount amount applied to the order.  For processor-specific information, see the order_discount_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Total discount amount applied to the order.  For processor-specific information, see the order_discount_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="discountAmount", EmitDefaultValue=false)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// The total discount percentage applied to the invoice.
        /// </summary>
        /// <value>The total discount percentage applied to the invoice.</value>
        [DataMember(Name="discountPercent", EmitDefaultValue=false)]
        public decimal? DiscountPercent { get; set; }

        /// <summary>
        /// Sub-amount of the invoice.
        /// </summary>
        /// <value>Sub-amount of the invoice.</value>
        [DataMember(Name="subAmount", EmitDefaultValue=false)]
        public decimal? SubAmount { get; set; }

        /// <summary>
        /// The minimum partial amount required to pay the invoice.
        /// </summary>
        /// <value>The minimum partial amount required to pay the invoice.</value>
        [DataMember(Name="minimumPartialAmount", EmitDefaultValue=false)]
        public decimal? MinimumPartialAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxDetails
        /// </summary>
        [DataMember(Name="taxDetails", EmitDefaultValue=false)]
        public Invoicingv2invoicesOrderInformationAmountDetailsTaxDetails TaxDetails { get; set; }

        /// <summary>
        /// Gets or Sets Freight
        /// </summary>
        [DataMember(Name="freight", EmitDefaultValue=false)]
        public Invoicingv2invoicesOrderInformationAmountDetailsFreight Freight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoicingV2InvoicesPost201ResponseOrderInformationAmountDetails {\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  BalanceAmount: ").Append(BalanceAmount).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  SubAmount: ").Append(SubAmount).Append("\n");
            sb.Append("  MinimumPartialAmount: ").Append(MinimumPartialAmount).Append("\n");
            sb.Append("  TaxDetails: ").Append(TaxDetails).Append("\n");
            sb.Append("  Freight: ").Append(Freight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InvoicingV2InvoicesPost201ResponseOrderInformationAmountDetails);
        }

        /// <summary>
        /// Returns true if InvoicingV2InvoicesPost201ResponseOrderInformationAmountDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of InvoicingV2InvoicesPost201ResponseOrderInformationAmountDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoicingV2InvoicesPost201ResponseOrderInformationAmountDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalAmount == other.TotalAmount ||
                    this.TotalAmount != null &&
                    this.TotalAmount.Equals(other.TotalAmount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.BalanceAmount == other.BalanceAmount ||
                    this.BalanceAmount != null &&
                    this.BalanceAmount.Equals(other.BalanceAmount)
                ) && 
                (
                    this.DiscountAmount == other.DiscountAmount ||
                    this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(other.DiscountAmount)
                ) && 
                (
                    this.DiscountPercent == other.DiscountPercent ||
                    this.DiscountPercent != null &&
                    this.DiscountPercent.Equals(other.DiscountPercent)
                ) && 
                (
                    this.SubAmount == other.SubAmount ||
                    this.SubAmount != null &&
                    this.SubAmount.Equals(other.SubAmount)
                ) && 
                (
                    this.MinimumPartialAmount == other.MinimumPartialAmount ||
                    this.MinimumPartialAmount != null &&
                    this.MinimumPartialAmount.Equals(other.MinimumPartialAmount)
                ) && 
                (
                    this.TaxDetails == other.TaxDetails ||
                    this.TaxDetails != null &&
                    this.TaxDetails.Equals(other.TaxDetails)
                ) && 
                (
                    this.Freight == other.Freight ||
                    this.Freight != null &&
                    this.Freight.Equals(other.Freight)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.TotalAmount != null)
                    hash = hash * 59 + this.TotalAmount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.BalanceAmount != null)
                    hash = hash * 59 + this.BalanceAmount.GetHashCode();
                if (this.DiscountAmount != null)
                    hash = hash * 59 + this.DiscountAmount.GetHashCode();
                if (this.DiscountPercent != null)
                    hash = hash * 59 + this.DiscountPercent.GetHashCode();
                if (this.SubAmount != null)
                    hash = hash * 59 + this.SubAmount.GetHashCode();
                if (this.MinimumPartialAmount != null)
                    hash = hash * 59 + this.MinimumPartialAmount.GetHashCode();
                if (this.TaxDetails != null)
                    hash = hash * 59 + this.TaxDetails.GetHashCode();
                if (this.Freight != null)
                    hash = hash * 59 + this.Freight.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // TotalAmount (string) maxLength
            if(this.TotalAmount != null && this.TotalAmount.Length >= 19)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalAmount, length must be less than or equal to 19.", new [] { "TotalAmount" });
            }

            // Currency (string) maxLength
            if(this.Currency != null && this.Currency.Length >= 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than or equal to 3.", new [] { "Currency" });
            }

            // BalanceAmount (string) maxLength
            if(this.BalanceAmount != null && this.BalanceAmount.Length >= 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BalanceAmount, length must be less than or equal to 12.", new [] { "BalanceAmount" });
            }

            // DiscountAmount (string) maxLength
            if(this.DiscountAmount != null && this.DiscountAmount.Length >= 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiscountAmount, length must be less than or equal to 15.", new [] { "DiscountAmount" });
            }

            yield break;
        }
    }

}
