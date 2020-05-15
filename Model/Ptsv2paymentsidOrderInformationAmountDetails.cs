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
    /// Ptsv2paymentsidOrderInformationAmountDetails
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidOrderInformationAmountDetails :  IEquatable<Ptsv2paymentsidOrderInformationAmountDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidOrderInformationAmountDetails" /> class.
        /// </summary>
        /// <param name="AdditionalAmount">Additional charges that have to be authorized against a lodging or auto-rental order. This value cannot be negative. You can include a decimal point (.), but no other special characters. .</param>
        /// <param name="Currency">Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency. .</param>
        public Ptsv2paymentsidOrderInformationAmountDetails(string AdditionalAmount = default(string), string Currency = default(string))
        {
            this.AdditionalAmount = AdditionalAmount;
            this.Currency = Currency;
        }
        
        /// <summary>
        /// Additional charges that have to be authorized against a lodging or auto-rental order. This value cannot be negative. You can include a decimal point (.), but no other special characters. 
        /// </summary>
        /// <value>Additional charges that have to be authorized against a lodging or auto-rental order. This value cannot be negative. You can include a decimal point (.), but no other special characters. </value>
        [DataMember(Name="additionalAmount", EmitDefaultValue=false)]
        public string AdditionalAmount { get; set; }

        /// <summary>
        /// Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency. 
        /// </summary>
        /// <value>Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency. </value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidOrderInformationAmountDetails {\n");
            sb.Append("  AdditionalAmount: ").Append(AdditionalAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidOrderInformationAmountDetails);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidOrderInformationAmountDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidOrderInformationAmountDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidOrderInformationAmountDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdditionalAmount == other.AdditionalAmount ||
                    this.AdditionalAmount != null &&
                    this.AdditionalAmount.Equals(other.AdditionalAmount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
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
                if (this.AdditionalAmount != null)
                    hash = hash * 59 + this.AdditionalAmount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
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
            // AdditionalAmount (string) maxLength
            if(this.AdditionalAmount != null && this.AdditionalAmount.Length >= 19)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdditionalAmount, length must be less than or equal to 19.", new [] { "AdditionalAmount" });
            }

            // Currency (string) maxLength
            if(this.Currency != null && this.Currency.Length >= 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than or equal to 3.", new [] { "Currency" });
            }

            yield break;
        }
    }

}
