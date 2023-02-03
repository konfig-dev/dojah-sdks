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
    /// GetPhoneNumberResponseEntity
    /// </summary>
    [DataContract(Name = "GetPhoneNumberResponse_entity")]
    public partial class GetPhoneNumberResponseEntity : IEquatable<GetPhoneNumberResponseEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberResponseEntity" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="msisdn">msisdn.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="middleName">middleName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="maritalStatus">maritalStatus.</param>
        /// <param name="gender">gender.</param>
        /// <param name="birthDate">birthDate.</param>
        /// <param name="birthLga">birthLga.</param>
        /// <param name="birthState">birthState.</param>
        /// <param name="educationalLevel">educationalLevel.</param>
        /// <param name="emplymentStatus">emplymentStatus.</param>
        /// <param name="nspokenLang">nspokenLang.</param>
        /// <param name="ospokenlang">ospokenlang.</param>
        /// <param name="profession">profession.</param>
        /// <param name="religion">religion.</param>
        /// <param name="residenceAddressLine1">residenceAddressLine1.</param>
        /// <param name="residenceTown">residenceTown.</param>
        /// <param name="residenceLga">residenceLga.</param>
        /// <param name="residenceState">residenceState.</param>
        /// <param name="residenceStatus">residenceStatus.</param>
        /// <param name="selfOriginLga">selfOriginLga.</param>
        /// <param name="selfOriginPlace">selfOriginPlace.</param>
        /// <param name="selfOriginState">selfOriginState.</param>
        /// <param name="state">state.</param>
        /// <param name="lga">lga.</param>
        /// <param name="nin">nin.</param>
        /// <param name="height">height.</param>
        /// <param name="picture">picture.</param>
        /// <param name="status">status.</param>
        public GetPhoneNumberResponseEntity(string title = default(string), string msisdn = default(string), string firstName = default(string), string middleName = default(string), string lastName = default(string), string maritalStatus = default(string), string gender = default(string), string birthDate = default(string), string birthLga = default(string), string birthState = default(string), string educationalLevel = default(string), string emplymentStatus = default(string), string nspokenLang = default(string), string ospokenlang = default(string), string profession = default(string), string religion = default(string), string residenceAddressLine1 = default(string), string residenceTown = default(string), string residenceLga = default(string), string residenceState = default(string), string residenceStatus = default(string), string selfOriginLga = default(string), string selfOriginPlace = default(string), string selfOriginState = default(string), string state = default(string), string lga = default(string), string nin = default(string), string height = default(string), string picture = default(string), decimal status = default(decimal))
        {
            this.Title = title;
            this.Msisdn = msisdn;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.MaritalStatus = maritalStatus;
            this.Gender = gender;
            this.BirthDate = birthDate;
            this.BirthLga = birthLga;
            this.BirthState = birthState;
            this.EducationalLevel = educationalLevel;
            this.EmplymentStatus = emplymentStatus;
            this.NspokenLang = nspokenLang;
            this.Ospokenlang = ospokenlang;
            this.Profession = profession;
            this.Religion = religion;
            this.ResidenceAddressLine1 = residenceAddressLine1;
            this.ResidenceTown = residenceTown;
            this.ResidenceLga = residenceLga;
            this.ResidenceState = residenceState;
            this.ResidenceStatus = residenceStatus;
            this.SelfOriginLga = selfOriginLga;
            this.SelfOriginPlace = selfOriginPlace;
            this.SelfOriginState = selfOriginState;
            this.State = state;
            this.Lga = lga;
            this.Nin = nin;
            this.Height = height;
            this.Picture = picture;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Msisdn
        /// </summary>
        [DataMember(Name = "msisdn", EmitDefaultValue = false)]
        public string Msisdn { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name = "middleName", EmitDefaultValue = false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets MaritalStatus
        /// </summary>
        [DataMember(Name = "maritalStatus", EmitDefaultValue = false)]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name = "birthDate", EmitDefaultValue = false)]
        public string BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets BirthLga
        /// </summary>
        [DataMember(Name = "birthLga", EmitDefaultValue = false)]
        public string BirthLga { get; set; }

        /// <summary>
        /// Gets or Sets BirthState
        /// </summary>
        [DataMember(Name = "birthState", EmitDefaultValue = false)]
        public string BirthState { get; set; }

        /// <summary>
        /// Gets or Sets EducationalLevel
        /// </summary>
        [DataMember(Name = "educationalLevel", EmitDefaultValue = false)]
        public string EducationalLevel { get; set; }

        /// <summary>
        /// Gets or Sets EmplymentStatus
        /// </summary>
        [DataMember(Name = "emplymentStatus", EmitDefaultValue = false)]
        public string EmplymentStatus { get; set; }

        /// <summary>
        /// Gets or Sets NspokenLang
        /// </summary>
        [DataMember(Name = "nspokenLang", EmitDefaultValue = false)]
        public string NspokenLang { get; set; }

        /// <summary>
        /// Gets or Sets Ospokenlang
        /// </summary>
        [DataMember(Name = "ospokenlang", EmitDefaultValue = false)]
        public string Ospokenlang { get; set; }

        /// <summary>
        /// Gets or Sets Profession
        /// </summary>
        [DataMember(Name = "profession", EmitDefaultValue = false)]
        public string Profession { get; set; }

        /// <summary>
        /// Gets or Sets Religion
        /// </summary>
        [DataMember(Name = "religion", EmitDefaultValue = false)]
        public string Religion { get; set; }

        /// <summary>
        /// Gets or Sets ResidenceAddressLine1
        /// </summary>
        [DataMember(Name = "residenceAddressLine1", EmitDefaultValue = false)]
        public string ResidenceAddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets ResidenceTown
        /// </summary>
        [DataMember(Name = "residenceTown", EmitDefaultValue = false)]
        public string ResidenceTown { get; set; }

        /// <summary>
        /// Gets or Sets ResidenceLga
        /// </summary>
        [DataMember(Name = "residenceLga", EmitDefaultValue = false)]
        public string ResidenceLga { get; set; }

        /// <summary>
        /// Gets or Sets ResidenceState
        /// </summary>
        [DataMember(Name = "residenceState", EmitDefaultValue = false)]
        public string ResidenceState { get; set; }

        /// <summary>
        /// Gets or Sets ResidenceStatus
        /// </summary>
        [DataMember(Name = "residenceStatus", EmitDefaultValue = false)]
        public string ResidenceStatus { get; set; }

        /// <summary>
        /// Gets or Sets SelfOriginLga
        /// </summary>
        [DataMember(Name = "selfOriginLga", EmitDefaultValue = false)]
        public string SelfOriginLga { get; set; }

        /// <summary>
        /// Gets or Sets SelfOriginPlace
        /// </summary>
        [DataMember(Name = "selfOriginPlace", EmitDefaultValue = false)]
        public string SelfOriginPlace { get; set; }

        /// <summary>
        /// Gets or Sets SelfOriginState
        /// </summary>
        [DataMember(Name = "selfOriginState", EmitDefaultValue = false)]
        public string SelfOriginState { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Lga
        /// </summary>
        [DataMember(Name = "lga", EmitDefaultValue = false)]
        public string Lga { get; set; }

        /// <summary>
        /// Gets or Sets Nin
        /// </summary>
        [DataMember(Name = "nin", EmitDefaultValue = false)]
        public string Nin { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public string Height { get; set; }

        /// <summary>
        /// Gets or Sets Picture
        /// </summary>
        [DataMember(Name = "picture", EmitDefaultValue = false)]
        public string Picture { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public decimal Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetPhoneNumberResponseEntity {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Msisdn: ").Append(Msisdn).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  BirthLga: ").Append(BirthLga).Append("\n");
            sb.Append("  BirthState: ").Append(BirthState).Append("\n");
            sb.Append("  EducationalLevel: ").Append(EducationalLevel).Append("\n");
            sb.Append("  EmplymentStatus: ").Append(EmplymentStatus).Append("\n");
            sb.Append("  NspokenLang: ").Append(NspokenLang).Append("\n");
            sb.Append("  Ospokenlang: ").Append(Ospokenlang).Append("\n");
            sb.Append("  Profession: ").Append(Profession).Append("\n");
            sb.Append("  Religion: ").Append(Religion).Append("\n");
            sb.Append("  ResidenceAddressLine1: ").Append(ResidenceAddressLine1).Append("\n");
            sb.Append("  ResidenceTown: ").Append(ResidenceTown).Append("\n");
            sb.Append("  ResidenceLga: ").Append(ResidenceLga).Append("\n");
            sb.Append("  ResidenceState: ").Append(ResidenceState).Append("\n");
            sb.Append("  ResidenceStatus: ").Append(ResidenceStatus).Append("\n");
            sb.Append("  SelfOriginLga: ").Append(SelfOriginLga).Append("\n");
            sb.Append("  SelfOriginPlace: ").Append(SelfOriginPlace).Append("\n");
            sb.Append("  SelfOriginState: ").Append(SelfOriginState).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Lga: ").Append(Lga).Append("\n");
            sb.Append("  Nin: ").Append(Nin).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as GetPhoneNumberResponseEntity);
        }

        /// <summary>
        /// Returns true if GetPhoneNumberResponseEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPhoneNumberResponseEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPhoneNumberResponseEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Msisdn == input.Msisdn ||
                    (this.Msisdn != null &&
                    this.Msisdn.Equals(input.Msisdn))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.MaritalStatus == input.MaritalStatus ||
                    (this.MaritalStatus != null &&
                    this.MaritalStatus.Equals(input.MaritalStatus))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.BirthLga == input.BirthLga ||
                    (this.BirthLga != null &&
                    this.BirthLga.Equals(input.BirthLga))
                ) && 
                (
                    this.BirthState == input.BirthState ||
                    (this.BirthState != null &&
                    this.BirthState.Equals(input.BirthState))
                ) && 
                (
                    this.EducationalLevel == input.EducationalLevel ||
                    (this.EducationalLevel != null &&
                    this.EducationalLevel.Equals(input.EducationalLevel))
                ) && 
                (
                    this.EmplymentStatus == input.EmplymentStatus ||
                    (this.EmplymentStatus != null &&
                    this.EmplymentStatus.Equals(input.EmplymentStatus))
                ) && 
                (
                    this.NspokenLang == input.NspokenLang ||
                    (this.NspokenLang != null &&
                    this.NspokenLang.Equals(input.NspokenLang))
                ) && 
                (
                    this.Ospokenlang == input.Ospokenlang ||
                    (this.Ospokenlang != null &&
                    this.Ospokenlang.Equals(input.Ospokenlang))
                ) && 
                (
                    this.Profession == input.Profession ||
                    (this.Profession != null &&
                    this.Profession.Equals(input.Profession))
                ) && 
                (
                    this.Religion == input.Religion ||
                    (this.Religion != null &&
                    this.Religion.Equals(input.Religion))
                ) && 
                (
                    this.ResidenceAddressLine1 == input.ResidenceAddressLine1 ||
                    (this.ResidenceAddressLine1 != null &&
                    this.ResidenceAddressLine1.Equals(input.ResidenceAddressLine1))
                ) && 
                (
                    this.ResidenceTown == input.ResidenceTown ||
                    (this.ResidenceTown != null &&
                    this.ResidenceTown.Equals(input.ResidenceTown))
                ) && 
                (
                    this.ResidenceLga == input.ResidenceLga ||
                    (this.ResidenceLga != null &&
                    this.ResidenceLga.Equals(input.ResidenceLga))
                ) && 
                (
                    this.ResidenceState == input.ResidenceState ||
                    (this.ResidenceState != null &&
                    this.ResidenceState.Equals(input.ResidenceState))
                ) && 
                (
                    this.ResidenceStatus == input.ResidenceStatus ||
                    (this.ResidenceStatus != null &&
                    this.ResidenceStatus.Equals(input.ResidenceStatus))
                ) && 
                (
                    this.SelfOriginLga == input.SelfOriginLga ||
                    (this.SelfOriginLga != null &&
                    this.SelfOriginLga.Equals(input.SelfOriginLga))
                ) && 
                (
                    this.SelfOriginPlace == input.SelfOriginPlace ||
                    (this.SelfOriginPlace != null &&
                    this.SelfOriginPlace.Equals(input.SelfOriginPlace))
                ) && 
                (
                    this.SelfOriginState == input.SelfOriginState ||
                    (this.SelfOriginState != null &&
                    this.SelfOriginState.Equals(input.SelfOriginState))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Lga == input.Lga ||
                    (this.Lga != null &&
                    this.Lga.Equals(input.Lga))
                ) && 
                (
                    this.Nin == input.Nin ||
                    (this.Nin != null &&
                    this.Nin.Equals(input.Nin))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Picture == input.Picture ||
                    (this.Picture != null &&
                    this.Picture.Equals(input.Picture))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Msisdn != null)
                {
                    hashCode = (hashCode * 59) + this.Msisdn.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.MiddleName != null)
                {
                    hashCode = (hashCode * 59) + this.MiddleName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.MaritalStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MaritalStatus.GetHashCode();
                }
                if (this.Gender != null)
                {
                    hashCode = (hashCode * 59) + this.Gender.GetHashCode();
                }
                if (this.BirthDate != null)
                {
                    hashCode = (hashCode * 59) + this.BirthDate.GetHashCode();
                }
                if (this.BirthLga != null)
                {
                    hashCode = (hashCode * 59) + this.BirthLga.GetHashCode();
                }
                if (this.BirthState != null)
                {
                    hashCode = (hashCode * 59) + this.BirthState.GetHashCode();
                }
                if (this.EducationalLevel != null)
                {
                    hashCode = (hashCode * 59) + this.EducationalLevel.GetHashCode();
                }
                if (this.EmplymentStatus != null)
                {
                    hashCode = (hashCode * 59) + this.EmplymentStatus.GetHashCode();
                }
                if (this.NspokenLang != null)
                {
                    hashCode = (hashCode * 59) + this.NspokenLang.GetHashCode();
                }
                if (this.Ospokenlang != null)
                {
                    hashCode = (hashCode * 59) + this.Ospokenlang.GetHashCode();
                }
                if (this.Profession != null)
                {
                    hashCode = (hashCode * 59) + this.Profession.GetHashCode();
                }
                if (this.Religion != null)
                {
                    hashCode = (hashCode * 59) + this.Religion.GetHashCode();
                }
                if (this.ResidenceAddressLine1 != null)
                {
                    hashCode = (hashCode * 59) + this.ResidenceAddressLine1.GetHashCode();
                }
                if (this.ResidenceTown != null)
                {
                    hashCode = (hashCode * 59) + this.ResidenceTown.GetHashCode();
                }
                if (this.ResidenceLga != null)
                {
                    hashCode = (hashCode * 59) + this.ResidenceLga.GetHashCode();
                }
                if (this.ResidenceState != null)
                {
                    hashCode = (hashCode * 59) + this.ResidenceState.GetHashCode();
                }
                if (this.ResidenceStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ResidenceStatus.GetHashCode();
                }
                if (this.SelfOriginLga != null)
                {
                    hashCode = (hashCode * 59) + this.SelfOriginLga.GetHashCode();
                }
                if (this.SelfOriginPlace != null)
                {
                    hashCode = (hashCode * 59) + this.SelfOriginPlace.GetHashCode();
                }
                if (this.SelfOriginState != null)
                {
                    hashCode = (hashCode * 59) + this.SelfOriginState.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Lga != null)
                {
                    hashCode = (hashCode * 59) + this.Lga.GetHashCode();
                }
                if (this.Nin != null)
                {
                    hashCode = (hashCode * 59) + this.Nin.GetHashCode();
                }
                if (this.Height != null)
                {
                    hashCode = (hashCode * 59) + this.Height.GetHashCode();
                }
                if (this.Picture != null)
                {
                    hashCode = (hashCode * 59) + this.Picture.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
