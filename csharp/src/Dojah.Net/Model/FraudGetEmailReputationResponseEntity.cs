/*
 * DOJAH Publilc APIs
 *
 * Use Dojah to verify, onboard and manage user identity across Africa!
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://konfigthis.com
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Dojah.Net.Client.OpenAPIDateConverter;

namespace Dojah.Net.Model
{
    /// <summary>
    /// FraudGetEmailReputationResponseEntity
    /// </summary>
    [DataContract(Name = "FraudGetEmailReputationResponse_entity")]
    public partial class FraudGetEmailReputationResponseEntity : IEquatable<FraudGetEmailReputationResponseEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudGetEmailReputationResponseEntity" /> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="reputation">reputation.</param>
        /// <param name="suspicious">suspicious.</param>
        /// <param name="references">references.</param>
        /// <param name="details">details.</param>
        /// <param name="score">score.</param>
        /// <param name="deliverable">deliverable.</param>
        /// <param name="domainDetails">domainDetails.</param>
        /// <param name="breachDetails">breachDetails.</param>
        /// <param name="accountDetailsRegistered">accountDetailsRegistered.</param>
        public FraudGetEmailReputationResponseEntity(string email = default(string), string reputation = default(string), bool suspicious = default(bool), decimal references = default(decimal), FraudGetEmailReputationResponseEntityDetails details = default(FraudGetEmailReputationResponseEntityDetails), decimal score = default(decimal), bool deliverable = default(bool), FraudGetEmailReputationResponseEntityDomainDetails domainDetails = default(FraudGetEmailReputationResponseEntityDomainDetails), FraudGetEmailReputationResponseEntityBreachDetails breachDetails = default(FraudGetEmailReputationResponseEntityBreachDetails), List<string> accountDetailsRegistered = default(List<string>))
        {
            this.Email = email;
            this.Reputation = reputation;
            this.Suspicious = suspicious;
            this.References = references;
            this.Details = details;
            this.Score = score;
            this.Deliverable = deliverable;
            this.DomainDetails = domainDetails;
            this.BreachDetails = breachDetails;
            this.AccountDetailsRegistered = accountDetailsRegistered;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Reputation
        /// </summary>
        [DataMember(Name = "reputation", EmitDefaultValue = false)]
        public string Reputation { get; set; }

        /// <summary>
        /// Gets or Sets Suspicious
        /// </summary>
        [DataMember(Name = "suspicious", EmitDefaultValue = true)]
        public bool Suspicious { get; set; }

        /// <summary>
        /// Gets or Sets References
        /// </summary>
        [DataMember(Name = "references", EmitDefaultValue = false)]
        public decimal References { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public FraudGetEmailReputationResponseEntityDetails Details { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public decimal Score { get; set; }

        /// <summary>
        /// Gets or Sets Deliverable
        /// </summary>
        [DataMember(Name = "deliverable", EmitDefaultValue = true)]
        public bool Deliverable { get; set; }

        /// <summary>
        /// Gets or Sets DomainDetails
        /// </summary>
        [DataMember(Name = "domain_details", EmitDefaultValue = false)]
        public FraudGetEmailReputationResponseEntityDomainDetails DomainDetails { get; set; }

        /// <summary>
        /// Gets or Sets BreachDetails
        /// </summary>
        [DataMember(Name = "breach_details", EmitDefaultValue = false)]
        public FraudGetEmailReputationResponseEntityBreachDetails BreachDetails { get; set; }

        /// <summary>
        /// Gets or Sets AccountDetailsRegistered
        /// </summary>
        [DataMember(Name = "account_details_registered", EmitDefaultValue = false)]
        public List<string> AccountDetailsRegistered { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FraudGetEmailReputationResponseEntity {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Reputation: ").Append(Reputation).Append("\n");
            sb.Append("  Suspicious: ").Append(Suspicious).Append("\n");
            sb.Append("  References: ").Append(References).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Deliverable: ").Append(Deliverable).Append("\n");
            sb.Append("  DomainDetails: ").Append(DomainDetails).Append("\n");
            sb.Append("  BreachDetails: ").Append(BreachDetails).Append("\n");
            sb.Append("  AccountDetailsRegistered: ").Append(AccountDetailsRegistered).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FraudGetEmailReputationResponseEntity);
        }

        /// <summary>
        /// Returns true if FraudGetEmailReputationResponseEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudGetEmailReputationResponseEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudGetEmailReputationResponseEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Reputation == input.Reputation ||
                    (this.Reputation != null &&
                    this.Reputation.Equals(input.Reputation))
                ) && 
                (
                    this.Suspicious == input.Suspicious ||
                    this.Suspicious.Equals(input.Suspicious)
                ) && 
                (
                    this.References == input.References ||
                    this.References.Equals(input.References)
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
                ) && 
                (
                    this.Deliverable == input.Deliverable ||
                    this.Deliverable.Equals(input.Deliverable)
                ) && 
                (
                    this.DomainDetails == input.DomainDetails ||
                    (this.DomainDetails != null &&
                    this.DomainDetails.Equals(input.DomainDetails))
                ) && 
                (
                    this.BreachDetails == input.BreachDetails ||
                    (this.BreachDetails != null &&
                    this.BreachDetails.Equals(input.BreachDetails))
                ) && 
                (
                    this.AccountDetailsRegistered == input.AccountDetailsRegistered ||
                    this.AccountDetailsRegistered != null &&
                    input.AccountDetailsRegistered != null &&
                    this.AccountDetailsRegistered.SequenceEqual(input.AccountDetailsRegistered)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Reputation != null)
                {
                    hashCode = (hashCode * 59) + this.Reputation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Suspicious.GetHashCode();
                hashCode = (hashCode * 59) + this.References.GetHashCode();
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
                hashCode = (hashCode * 59) + this.Deliverable.GetHashCode();
                if (this.DomainDetails != null)
                {
                    hashCode = (hashCode * 59) + this.DomainDetails.GetHashCode();
                }
                if (this.BreachDetails != null)
                {
                    hashCode = (hashCode * 59) + this.BreachDetails.GetHashCode();
                }
                if (this.AccountDetailsRegistered != null)
                {
                    hashCode = (hashCode * 59) + this.AccountDetailsRegistered.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
