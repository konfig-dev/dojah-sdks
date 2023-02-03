/*
 * DOJAH APIs
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
    /// ValidateBvnResponseEntity
    /// </summary>
    [DataContract(Name = "ValidateBvnResponse_entity")]
    public partial class ValidateBvnResponseEntity : IEquatable<ValidateBvnResponseEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateBvnResponseEntity" /> class.
        /// </summary>
        /// <param name="bvn">bvn.</param>
        /// <param name="firstName">firstName.</param>
        public ValidateBvnResponseEntity(ValidateBvnResponseEntityBvn bvn = default(ValidateBvnResponseEntityBvn), ValidateBvnResponseEntityFirstName firstName = default(ValidateBvnResponseEntityFirstName))
        {
            this.Bvn = bvn;
            this.FirstName = firstName;
        }

        /// <summary>
        /// Gets or Sets Bvn
        /// </summary>
        [DataMember(Name = "bvn", EmitDefaultValue = false)]
        public ValidateBvnResponseEntityBvn Bvn { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public ValidateBvnResponseEntityFirstName FirstName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidateBvnResponseEntity {\n");
            sb.Append("  Bvn: ").Append(Bvn).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
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
            return this.Equals(input as ValidateBvnResponseEntity);
        }

        /// <summary>
        /// Returns true if ValidateBvnResponseEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateBvnResponseEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateBvnResponseEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Bvn == input.Bvn ||
                    (this.Bvn != null &&
                    this.Bvn.Equals(input.Bvn))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
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
                if (this.Bvn != null)
                {
                    hashCode = (hashCode * 59) + this.Bvn.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
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
