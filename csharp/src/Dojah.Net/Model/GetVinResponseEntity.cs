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
    /// GetVinResponseEntity
    /// </summary>
    [DataContract(Name = "GetVinResponse_entity")]
    public partial class GetVinResponseEntity : IEquatable<GetVinResponseEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetVinResponseEntity" /> class.
        /// </summary>
        /// <param name="fullName">fullName.</param>
        /// <param name="voterIdentificationNumber">voterIdentificationNumber.</param>
        /// <param name="gender">gender.</param>
        /// <param name="occupation">occupation.</param>
        /// <param name="timeOfRegistration">timeOfRegistration.</param>
        /// <param name="state">state.</param>
        /// <param name="localGovernment">localGovernment.</param>
        /// <param name="registrationAreaWard">registrationAreaWard.</param>
        /// <param name="pollingUnit">pollingUnit.</param>
        /// <param name="pollingUnitCode">pollingUnitCode.</param>
        public GetVinResponseEntity(string fullName = default(string), string voterIdentificationNumber = default(string), string gender = default(string), string occupation = default(string), string timeOfRegistration = default(string), string state = default(string), string localGovernment = default(string), string registrationAreaWard = default(string), string pollingUnit = default(string), string pollingUnitCode = default(string))
        {
            this.FullName = fullName;
            this.VoterIdentificationNumber = voterIdentificationNumber;
            this.Gender = gender;
            this.Occupation = occupation;
            this.TimeOfRegistration = timeOfRegistration;
            this.State = state;
            this.LocalGovernment = localGovernment;
            this.RegistrationAreaWard = registrationAreaWard;
            this.PollingUnit = pollingUnit;
            this.PollingUnitCode = pollingUnitCode;
        }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "full_name", EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets VoterIdentificationNumber
        /// </summary>
        [DataMember(Name = "voter_identification_number:", EmitDefaultValue = false)]
        public string VoterIdentificationNumber { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender:", EmitDefaultValue = false)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets Occupation
        /// </summary>
        [DataMember(Name = "occupation:", EmitDefaultValue = false)]
        public string Occupation { get; set; }

        /// <summary>
        /// Gets or Sets TimeOfRegistration
        /// </summary>
        [DataMember(Name = "time_of_registration:", EmitDefaultValue = false)]
        public string TimeOfRegistration { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state:", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets LocalGovernment
        /// </summary>
        [DataMember(Name = "local_government:", EmitDefaultValue = false)]
        public string LocalGovernment { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationAreaWard
        /// </summary>
        [DataMember(Name = "registration_area_ward:", EmitDefaultValue = false)]
        public string RegistrationAreaWard { get; set; }

        /// <summary>
        /// Gets or Sets PollingUnit
        /// </summary>
        [DataMember(Name = "polling_unit:", EmitDefaultValue = false)]
        public string PollingUnit { get; set; }

        /// <summary>
        /// Gets or Sets PollingUnitCode
        /// </summary>
        [DataMember(Name = "polling_unit_code", EmitDefaultValue = false)]
        public string PollingUnitCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetVinResponseEntity {\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  VoterIdentificationNumber: ").Append(VoterIdentificationNumber).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Occupation: ").Append(Occupation).Append("\n");
            sb.Append("  TimeOfRegistration: ").Append(TimeOfRegistration).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  LocalGovernment: ").Append(LocalGovernment).Append("\n");
            sb.Append("  RegistrationAreaWard: ").Append(RegistrationAreaWard).Append("\n");
            sb.Append("  PollingUnit: ").Append(PollingUnit).Append("\n");
            sb.Append("  PollingUnitCode: ").Append(PollingUnitCode).Append("\n");
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
            return this.Equals(input as GetVinResponseEntity);
        }

        /// <summary>
        /// Returns true if GetVinResponseEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of GetVinResponseEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetVinResponseEntity input)
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
                    this.VoterIdentificationNumber == input.VoterIdentificationNumber ||
                    (this.VoterIdentificationNumber != null &&
                    this.VoterIdentificationNumber.Equals(input.VoterIdentificationNumber))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.Occupation == input.Occupation ||
                    (this.Occupation != null &&
                    this.Occupation.Equals(input.Occupation))
                ) && 
                (
                    this.TimeOfRegistration == input.TimeOfRegistration ||
                    (this.TimeOfRegistration != null &&
                    this.TimeOfRegistration.Equals(input.TimeOfRegistration))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.LocalGovernment == input.LocalGovernment ||
                    (this.LocalGovernment != null &&
                    this.LocalGovernment.Equals(input.LocalGovernment))
                ) && 
                (
                    this.RegistrationAreaWard == input.RegistrationAreaWard ||
                    (this.RegistrationAreaWard != null &&
                    this.RegistrationAreaWard.Equals(input.RegistrationAreaWard))
                ) && 
                (
                    this.PollingUnit == input.PollingUnit ||
                    (this.PollingUnit != null &&
                    this.PollingUnit.Equals(input.PollingUnit))
                ) && 
                (
                    this.PollingUnitCode == input.PollingUnitCode ||
                    (this.PollingUnitCode != null &&
                    this.PollingUnitCode.Equals(input.PollingUnitCode))
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
                if (this.VoterIdentificationNumber != null)
                {
                    hashCode = (hashCode * 59) + this.VoterIdentificationNumber.GetHashCode();
                }
                if (this.Gender != null)
                {
                    hashCode = (hashCode * 59) + this.Gender.GetHashCode();
                }
                if (this.Occupation != null)
                {
                    hashCode = (hashCode * 59) + this.Occupation.GetHashCode();
                }
                if (this.TimeOfRegistration != null)
                {
                    hashCode = (hashCode * 59) + this.TimeOfRegistration.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.LocalGovernment != null)
                {
                    hashCode = (hashCode * 59) + this.LocalGovernment.GetHashCode();
                }
                if (this.RegistrationAreaWard != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationAreaWard.GetHashCode();
                }
                if (this.PollingUnit != null)
                {
                    hashCode = (hashCode * 59) + this.PollingUnit.GetHashCode();
                }
                if (this.PollingUnitCode != null)
                {
                    hashCode = (hashCode * 59) + this.PollingUnitCode.GetHashCode();
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
