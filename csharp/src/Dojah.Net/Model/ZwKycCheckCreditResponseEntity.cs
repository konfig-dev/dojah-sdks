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
    /// ZwKycCheckCreditResponseEntity
    /// </summary>
    [DataContract(Name = "ZwKycCheckCreditResponse_entity")]
    public partial class ZwKycCheckCreditResponseEntity : IEquatable<ZwKycCheckCreditResponseEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZwKycCheckCreditResponseEntity" /> class.
        /// </summary>
        /// <param name="fullName">fullName.</param>
        /// <param name="score">score.</param>
        /// <param name="status">status.</param>
        /// <param name="gender">gender.</param>
        /// <param name="dob">dob.</param>
        /// <param name="idNumber">idNumber.</param>
        public ZwKycCheckCreditResponseEntity(string fullName = default(string), decimal score = default(decimal), string status = default(string), string gender = default(string), string dob = default(string), string idNumber = default(string))
        {
            this.FullName = fullName;
            this.Score = score;
            this.Status = status;
            this.Gender = gender;
            this.Dob = dob;
            this.IdNumber = idNumber;
        }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "full_name", EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public decimal Score { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets Dob
        /// </summary>
        [DataMember(Name = "dob", EmitDefaultValue = false)]
        public string Dob { get; set; }

        /// <summary>
        /// Gets or Sets IdNumber
        /// </summary>
        [DataMember(Name = "id_number", EmitDefaultValue = true)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZwKycCheckCreditResponseEntity {\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Dob: ").Append(Dob).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
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
            return this.Equals(input as ZwKycCheckCreditResponseEntity);
        }

        /// <summary>
        /// Returns true if ZwKycCheckCreditResponseEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ZwKycCheckCreditResponseEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZwKycCheckCreditResponseEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.Dob == input.Dob ||
                    (this.Dob != null &&
                    this.Dob.Equals(input.Dob))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
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
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Gender != null)
                {
                    hashCode = (hashCode * 59) + this.Gender.GetHashCode();
                }
                if (this.Dob != null)
                {
                    hashCode = (hashCode * 59) + this.Dob.GetHashCode();
                }
                if (this.IdNumber != null)
                {
                    hashCode = (hashCode * 59) + this.IdNumber.GetHashCode();
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
