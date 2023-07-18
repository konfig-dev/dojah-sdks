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
    /// FraudScreenUserResponseEntity
    /// </summary>
    [DataContract(Name = "FraudScreenUserResponse_entity")]
    public partial class FraudScreenUserResponseEntity : IEquatable<FraudScreenUserResponseEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudScreenUserResponseEntity" /> class.
        /// </summary>
        /// <param name="amlScreeningResult">amlScreeningResult.</param>
        /// <param name="ipCheckResult">ipCheckResult.</param>
        /// <param name="emailCheckResult">emailCheckResult.</param>
        /// <param name="phoneCheckResult">phoneCheckResult.</param>
        /// <param name="overallRiskScore">overallRiskScore.</param>
        public FraudScreenUserResponseEntity(string amlScreeningResult = default(string), FraudScreenUserResponseEntityIpCheckResult ipCheckResult = default(FraudScreenUserResponseEntityIpCheckResult), FraudScreenUserResponseEntityEmailCheckResult emailCheckResult = default(FraudScreenUserResponseEntityEmailCheckResult), FraudScreenUserResponseEntityPhoneCheckResult phoneCheckResult = default(FraudScreenUserResponseEntityPhoneCheckResult), decimal overallRiskScore = default(decimal))
        {
            this.AmlScreeningResult = amlScreeningResult;
            this.IpCheckResult = ipCheckResult;
            this.EmailCheckResult = emailCheckResult;
            this.PhoneCheckResult = phoneCheckResult;
            this.OverallRiskScore = overallRiskScore;
        }

        /// <summary>
        /// Gets or Sets AmlScreeningResult
        /// </summary>
        [DataMember(Name = "aml_screening_result", EmitDefaultValue = true)]
        public string AmlScreeningResult { get; set; }

        /// <summary>
        /// Gets or Sets IpCheckResult
        /// </summary>
        [DataMember(Name = "ip_check_result", EmitDefaultValue = false)]
        public FraudScreenUserResponseEntityIpCheckResult IpCheckResult { get; set; }

        /// <summary>
        /// Gets or Sets EmailCheckResult
        /// </summary>
        [DataMember(Name = "email_check_result", EmitDefaultValue = false)]
        public FraudScreenUserResponseEntityEmailCheckResult EmailCheckResult { get; set; }

        /// <summary>
        /// Gets or Sets PhoneCheckResult
        /// </summary>
        [DataMember(Name = "phone_check_result", EmitDefaultValue = false)]
        public FraudScreenUserResponseEntityPhoneCheckResult PhoneCheckResult { get; set; }

        /// <summary>
        /// Gets or Sets OverallRiskScore
        /// </summary>
        [DataMember(Name = "overall_risk_score", EmitDefaultValue = false)]
        public decimal OverallRiskScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FraudScreenUserResponseEntity {\n");
            sb.Append("  AmlScreeningResult: ").Append(AmlScreeningResult).Append("\n");
            sb.Append("  IpCheckResult: ").Append(IpCheckResult).Append("\n");
            sb.Append("  EmailCheckResult: ").Append(EmailCheckResult).Append("\n");
            sb.Append("  PhoneCheckResult: ").Append(PhoneCheckResult).Append("\n");
            sb.Append("  OverallRiskScore: ").Append(OverallRiskScore).Append("\n");
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
            return this.Equals(input as FraudScreenUserResponseEntity);
        }

        /// <summary>
        /// Returns true if FraudScreenUserResponseEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudScreenUserResponseEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudScreenUserResponseEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmlScreeningResult == input.AmlScreeningResult ||
                    (this.AmlScreeningResult != null &&
                    this.AmlScreeningResult.Equals(input.AmlScreeningResult))
                ) && 
                (
                    this.IpCheckResult == input.IpCheckResult ||
                    (this.IpCheckResult != null &&
                    this.IpCheckResult.Equals(input.IpCheckResult))
                ) && 
                (
                    this.EmailCheckResult == input.EmailCheckResult ||
                    (this.EmailCheckResult != null &&
                    this.EmailCheckResult.Equals(input.EmailCheckResult))
                ) && 
                (
                    this.PhoneCheckResult == input.PhoneCheckResult ||
                    (this.PhoneCheckResult != null &&
                    this.PhoneCheckResult.Equals(input.PhoneCheckResult))
                ) && 
                (
                    this.OverallRiskScore == input.OverallRiskScore ||
                    this.OverallRiskScore.Equals(input.OverallRiskScore)
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
                if (this.AmlScreeningResult != null)
                {
                    hashCode = (hashCode * 59) + this.AmlScreeningResult.GetHashCode();
                }
                if (this.IpCheckResult != null)
                {
                    hashCode = (hashCode * 59) + this.IpCheckResult.GetHashCode();
                }
                if (this.EmailCheckResult != null)
                {
                    hashCode = (hashCode * 59) + this.EmailCheckResult.GetHashCode();
                }
                if (this.PhoneCheckResult != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneCheckResult.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OverallRiskScore.GetHashCode();
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
