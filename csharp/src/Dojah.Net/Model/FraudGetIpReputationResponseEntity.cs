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
    /// FraudGetIpReputationResponseEntity
    /// </summary>
    [DataContract(Name = "FraudGetIpReputationResponse_entity")]
    public partial class FraudGetIpReputationResponseEntity : IEquatable<FraudGetIpReputationResponseEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudGetIpReputationResponseEntity" /> class.
        /// </summary>
        /// <param name="report">report.</param>
        /// <param name="success">success.</param>
        public FraudGetIpReputationResponseEntity(FraudGetIpReputationResponseEntityReport report = default(FraudGetIpReputationResponseEntityReport), bool success = default(bool))
        {
            this.Report = report;
            this.Success = success;
        }

        /// <summary>
        /// Gets or Sets Report
        /// </summary>
        [DataMember(Name = "report", EmitDefaultValue = false)]
        public FraudGetIpReputationResponseEntityReport Report { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FraudGetIpReputationResponseEntity {\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(input as FraudGetIpReputationResponseEntity);
        }

        /// <summary>
        /// Returns true if FraudGetIpReputationResponseEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudGetIpReputationResponseEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudGetIpReputationResponseEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Report == input.Report ||
                    (this.Report != null &&
                    this.Report.Equals(input.Report))
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
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
                if (this.Report != null)
                {
                    hashCode = (hashCode * 59) + this.Report.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
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
