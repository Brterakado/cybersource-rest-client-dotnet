/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
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
    /// CreatePaymentRequest
    /// </summary>
    [DataContract]
    public partial class CreatePaymentRequest :  IEquatable<CreatePaymentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentRequest" /> class.
        /// </summary>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        /// <param name="BuyerInformation">BuyerInformation.</param>
        /// <param name="RecipientInformation">RecipientInformation.</param>
        /// <param name="DeviceInformation">DeviceInformation.</param>
        /// <param name="MerchantInformation">MerchantInformation.</param>
        /// <param name="AggregatorInformation">AggregatorInformation.</param>
        /// <param name="ConsumerAuthenticationInformation">ConsumerAuthenticationInformation.</param>
        /// <param name="PointOfSaleInformation">PointOfSaleInformation.</param>
        /// <param name="MerchantDefinedInformation">TBD.</param>
        public CreatePaymentRequest(V2paymentsClientReferenceInformation ClientReferenceInformation = default(V2paymentsClientReferenceInformation), V2paymentsProcessingInformation ProcessingInformation = default(V2paymentsProcessingInformation), V2paymentsPaymentInformation PaymentInformation = default(V2paymentsPaymentInformation), V2paymentsOrderInformation OrderInformation = default(V2paymentsOrderInformation), V2paymentsBuyerInformation BuyerInformation = default(V2paymentsBuyerInformation), V2paymentsRecipientInformation RecipientInformation = default(V2paymentsRecipientInformation), V2paymentsDeviceInformation DeviceInformation = default(V2paymentsDeviceInformation), V2paymentsMerchantInformation MerchantInformation = default(V2paymentsMerchantInformation), V2paymentsAggregatorInformation AggregatorInformation = default(V2paymentsAggregatorInformation), V2paymentsConsumerAuthenticationInformation ConsumerAuthenticationInformation = default(V2paymentsConsumerAuthenticationInformation), V2paymentsPointOfSaleInformation PointOfSaleInformation = default(V2paymentsPointOfSaleInformation), List<V2paymentsMerchantDefinedInformation> MerchantDefinedInformation = default(List<V2paymentsMerchantDefinedInformation>))
        {
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.ProcessingInformation = ProcessingInformation;
            this.PaymentInformation = PaymentInformation;
            this.OrderInformation = OrderInformation;
            this.BuyerInformation = BuyerInformation;
            this.RecipientInformation = RecipientInformation;
            this.DeviceInformation = DeviceInformation;
            this.MerchantInformation = MerchantInformation;
            this.AggregatorInformation = AggregatorInformation;
            this.ConsumerAuthenticationInformation = ConsumerAuthenticationInformation;
            this.PointOfSaleInformation = PointOfSaleInformation;
            this.MerchantDefinedInformation = MerchantDefinedInformation;
        }
        
        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public V2paymentsClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public V2paymentsProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public V2paymentsPaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public V2paymentsOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Gets or Sets BuyerInformation
        /// </summary>
        [DataMember(Name="buyerInformation", EmitDefaultValue=false)]
        public V2paymentsBuyerInformation BuyerInformation { get; set; }

        /// <summary>
        /// Gets or Sets RecipientInformation
        /// </summary>
        [DataMember(Name="recipientInformation", EmitDefaultValue=false)]
        public V2paymentsRecipientInformation RecipientInformation { get; set; }

        /// <summary>
        /// Gets or Sets DeviceInformation
        /// </summary>
        [DataMember(Name="deviceInformation", EmitDefaultValue=false)]
        public V2paymentsDeviceInformation DeviceInformation { get; set; }

        /// <summary>
        /// Gets or Sets MerchantInformation
        /// </summary>
        [DataMember(Name="merchantInformation", EmitDefaultValue=false)]
        public V2paymentsMerchantInformation MerchantInformation { get; set; }

        /// <summary>
        /// Gets or Sets AggregatorInformation
        /// </summary>
        [DataMember(Name="aggregatorInformation", EmitDefaultValue=false)]
        public V2paymentsAggregatorInformation AggregatorInformation { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerAuthenticationInformation
        /// </summary>
        [DataMember(Name="consumerAuthenticationInformation", EmitDefaultValue=false)]
        public V2paymentsConsumerAuthenticationInformation ConsumerAuthenticationInformation { get; set; }

        /// <summary>
        /// Gets or Sets PointOfSaleInformation
        /// </summary>
        [DataMember(Name="pointOfSaleInformation", EmitDefaultValue=false)]
        public V2paymentsPointOfSaleInformation PointOfSaleInformation { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="merchantDefinedInformation", EmitDefaultValue=false)]
        public List<V2paymentsMerchantDefinedInformation> MerchantDefinedInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePaymentRequest {\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
            sb.Append("  BuyerInformation: ").Append(BuyerInformation).Append("\n");
            sb.Append("  RecipientInformation: ").Append(RecipientInformation).Append("\n");
            sb.Append("  DeviceInformation: ").Append(DeviceInformation).Append("\n");
            sb.Append("  MerchantInformation: ").Append(MerchantInformation).Append("\n");
            sb.Append("  AggregatorInformation: ").Append(AggregatorInformation).Append("\n");
            sb.Append("  ConsumerAuthenticationInformation: ").Append(ConsumerAuthenticationInformation).Append("\n");
            sb.Append("  PointOfSaleInformation: ").Append(PointOfSaleInformation).Append("\n");
            sb.Append("  MerchantDefinedInformation: ").Append(MerchantDefinedInformation).Append("\n");
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
            return this.Equals(obj as CreatePaymentRequest);
        }

        /// <summary>
        /// Returns true if CreatePaymentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatePaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePaymentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
                ) && 
                (
                    this.BuyerInformation == other.BuyerInformation ||
                    this.BuyerInformation != null &&
                    this.BuyerInformation.Equals(other.BuyerInformation)
                ) && 
                (
                    this.RecipientInformation == other.RecipientInformation ||
                    this.RecipientInformation != null &&
                    this.RecipientInformation.Equals(other.RecipientInformation)
                ) && 
                (
                    this.DeviceInformation == other.DeviceInformation ||
                    this.DeviceInformation != null &&
                    this.DeviceInformation.Equals(other.DeviceInformation)
                ) && 
                (
                    this.MerchantInformation == other.MerchantInformation ||
                    this.MerchantInformation != null &&
                    this.MerchantInformation.Equals(other.MerchantInformation)
                ) && 
                (
                    this.AggregatorInformation == other.AggregatorInformation ||
                    this.AggregatorInformation != null &&
                    this.AggregatorInformation.Equals(other.AggregatorInformation)
                ) && 
                (
                    this.ConsumerAuthenticationInformation == other.ConsumerAuthenticationInformation ||
                    this.ConsumerAuthenticationInformation != null &&
                    this.ConsumerAuthenticationInformation.Equals(other.ConsumerAuthenticationInformation)
                ) && 
                (
                    this.PointOfSaleInformation == other.PointOfSaleInformation ||
                    this.PointOfSaleInformation != null &&
                    this.PointOfSaleInformation.Equals(other.PointOfSaleInformation)
                ) && 
                (
                    this.MerchantDefinedInformation == other.MerchantDefinedInformation ||
                    this.MerchantDefinedInformation != null &&
                    this.MerchantDefinedInformation.SequenceEqual(other.MerchantDefinedInformation)
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
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
                if (this.BuyerInformation != null)
                    hash = hash * 59 + this.BuyerInformation.GetHashCode();
                if (this.RecipientInformation != null)
                    hash = hash * 59 + this.RecipientInformation.GetHashCode();
                if (this.DeviceInformation != null)
                    hash = hash * 59 + this.DeviceInformation.GetHashCode();
                if (this.MerchantInformation != null)
                    hash = hash * 59 + this.MerchantInformation.GetHashCode();
                if (this.AggregatorInformation != null)
                    hash = hash * 59 + this.AggregatorInformation.GetHashCode();
                if (this.ConsumerAuthenticationInformation != null)
                    hash = hash * 59 + this.ConsumerAuthenticationInformation.GetHashCode();
                if (this.PointOfSaleInformation != null)
                    hash = hash * 59 + this.PointOfSaleInformation.GetHashCode();
                if (this.MerchantDefinedInformation != null)
                    hash = hash * 59 + this.MerchantDefinedInformation.GetHashCode();
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
            yield break;
        }
    }

}