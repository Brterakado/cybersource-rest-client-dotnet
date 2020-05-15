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
    /// Tmsv1paymentinstrumentsInstrumentIdentifier
    /// </summary>
    [DataContract]
    public partial class Tmsv1paymentinstrumentsInstrumentIdentifier :  IEquatable<Tmsv1paymentinstrumentsInstrumentIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tmsv1paymentinstrumentsInstrumentIdentifier" /> class.
        /// </summary>
        /// <param name="Id">The ID of the existing instrument identifier to be linked to the newly created payment instrument..</param>
        /// <param name="Card">Card.</param>
        /// <param name="BankAccount">BankAccount.</param>
        public Tmsv1paymentinstrumentsInstrumentIdentifier(string Id = default(string), TmsV1InstrumentIdentifiersPost200ResponseCard Card = default(TmsV1InstrumentIdentifiersPost200ResponseCard), Tmsv1instrumentidentifiersBankAccount BankAccount = default(Tmsv1instrumentidentifiersBankAccount))
        {
            this.Id = Id;
            this.Card = Card;
            this.BankAccount = BankAccount;
        }
        
        /// <summary>
        /// The ID of the existing instrument identifier to be linked to the newly created payment instrument.
        /// </summary>
        /// <value>The ID of the existing instrument identifier to be linked to the newly created payment instrument.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public TmsV1InstrumentIdentifiersPost200ResponseCard Card { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name="bankAccount", EmitDefaultValue=false)]
        public Tmsv1instrumentidentifiersBankAccount BankAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tmsv1paymentinstrumentsInstrumentIdentifier {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
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
            return this.Equals(obj as Tmsv1paymentinstrumentsInstrumentIdentifier);
        }

        /// <summary>
        /// Returns true if Tmsv1paymentinstrumentsInstrumentIdentifier instances are equal
        /// </summary>
        /// <param name="other">Instance of Tmsv1paymentinstrumentsInstrumentIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tmsv1paymentinstrumentsInstrumentIdentifier other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) && 
                (
                    this.BankAccount == other.BankAccount ||
                    this.BankAccount != null &&
                    this.BankAccount.Equals(other.BankAccount)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
                if (this.BankAccount != null)
                    hash = hash * 59 + this.BankAccount.GetHashCode();
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
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length >= 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than or equal to 32.", new [] { "Id" });
            }

            // Id (string) minLength
            if(this.Id != null && this.Id.Length <= 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than or equal to 12.", new [] { "Id" });
            }

            yield break;
        }
    }

}
