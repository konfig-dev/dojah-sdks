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
    /// ZafKycGetIdResponseEntity
    /// </summary>
    [DataContract(Name = "ZafKycGetIdResponse_entity")]
    public partial class ZafKycGetIdResponseEntity : IEquatable<ZafKycGetIdResponseEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZafKycGetIdResponseEntity" /> class.
        /// </summary>
        /// <param name="birthPlaceCountry">birthPlaceCountry.</param>
        /// <param name="birthPlaceCountryCode">birthPlaceCountryCode.</param>
        /// <param name="bookedDate">bookedDate.</param>
        /// <param name="cardDate">cardDate.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="gender">gender.</param>
        /// <param name="idBlocked">idBlocked.</param>
        /// <param name="idNumber">idNumber.</param>
        /// <param name="issuedDate">issuedDate.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="maidenName">maidenName.</param>
        /// <param name="maritalStatus">maritalStatus.</param>
        /// <param name="onHANIS">onHANIS.</param>
        /// <param name="onNPR">onNPR.</param>
        /// <param name="photo">photo.</param>
        /// <param name="smartCardIssued">smartCardIssued.</param>
        /// <param name="status">status.</param>
        public ZafKycGetIdResponseEntity(string birthPlaceCountry = default(string), string birthPlaceCountryCode = default(string), string bookedDate = default(string), string cardDate = default(string), string dateOfBirth = default(string), string fullName = default(string), string gender = default(string), string idBlocked = default(string), string idNumber = default(string), string issuedDate = default(string), string lastName = default(string), string maidenName = default(string), string maritalStatus = default(string), string onHANIS = default(string), string onNPR = default(string), string photo = default(string), string smartCardIssued = default(string), decimal status = default(decimal))
        {
            this.BirthPlaceCountry = birthPlaceCountry;
            this.BirthPlaceCountryCode = birthPlaceCountryCode;
            this.BookedDate = bookedDate;
            this.CardDate = cardDate;
            this.DateOfBirth = dateOfBirth;
            this.FullName = fullName;
            this.Gender = gender;
            this.IdBlocked = idBlocked;
            this.IdNumber = idNumber;
            this.IssuedDate = issuedDate;
            this.LastName = lastName;
            this.MaidenName = maidenName;
            this.MaritalStatus = maritalStatus;
            this.OnHANIS = onHANIS;
            this.OnNPR = onNPR;
            this.Photo = photo;
            this.SmartCardIssued = smartCardIssued;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets BirthPlaceCountry
        /// </summary>
        [DataMember(Name = "birth_place_country", EmitDefaultValue = false)]
        public string BirthPlaceCountry { get; set; }

        /// <summary>
        /// Gets or Sets BirthPlaceCountryCode
        /// </summary>
        [DataMember(Name = "birth_place_country_code", EmitDefaultValue = false)]
        public string BirthPlaceCountryCode { get; set; }

        /// <summary>
        /// Gets or Sets BookedDate
        /// </summary>
        [DataMember(Name = "booked_date", EmitDefaultValue = false)]
        public string BookedDate { get; set; }

        /// <summary>
        /// Gets or Sets CardDate
        /// </summary>
        [DataMember(Name = "card_date", EmitDefaultValue = false)]
        public string CardDate { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name = "date_of_birth", EmitDefaultValue = false)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "full_name", EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets IdBlocked
        /// </summary>
        [DataMember(Name = "id_blocked", EmitDefaultValue = false)]
        public string IdBlocked { get; set; }

        /// <summary>
        /// Gets or Sets IdNumber
        /// </summary>
        [DataMember(Name = "id_number", EmitDefaultValue = false)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Gets or Sets IssuedDate
        /// </summary>
        [DataMember(Name = "issued_date", EmitDefaultValue = false)]
        public string IssuedDate { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets MaidenName
        /// </summary>
        [DataMember(Name = "maiden_name", EmitDefaultValue = false)]
        public string MaidenName { get; set; }

        /// <summary>
        /// Gets or Sets MaritalStatus
        /// </summary>
        [DataMember(Name = "marital_status", EmitDefaultValue = false)]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// Gets or Sets OnHANIS
        /// </summary>
        [DataMember(Name = "on_HANIS", EmitDefaultValue = false)]
        public string OnHANIS { get; set; }

        /// <summary>
        /// Gets or Sets OnNPR
        /// </summary>
        [DataMember(Name = "on_NPR", EmitDefaultValue = false)]
        public string OnNPR { get; set; }

        /// <summary>
        /// Gets or Sets Photo
        /// </summary>
        [DataMember(Name = "photo", EmitDefaultValue = false)]
        public string Photo { get; set; }

        /// <summary>
        /// Gets or Sets SmartCardIssued
        /// </summary>
        [DataMember(Name = "smart_card_issued", EmitDefaultValue = false)]
        public string SmartCardIssued { get; set; }

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
            sb.Append("class ZafKycGetIdResponseEntity {\n");
            sb.Append("  BirthPlaceCountry: ").Append(BirthPlaceCountry).Append("\n");
            sb.Append("  BirthPlaceCountryCode: ").Append(BirthPlaceCountryCode).Append("\n");
            sb.Append("  BookedDate: ").Append(BookedDate).Append("\n");
            sb.Append("  CardDate: ").Append(CardDate).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  IdBlocked: ").Append(IdBlocked).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  IssuedDate: ").Append(IssuedDate).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MaidenName: ").Append(MaidenName).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  OnHANIS: ").Append(OnHANIS).Append("\n");
            sb.Append("  OnNPR: ").Append(OnNPR).Append("\n");
            sb.Append("  Photo: ").Append(Photo).Append("\n");
            sb.Append("  SmartCardIssued: ").Append(SmartCardIssued).Append("\n");
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
            return this.Equals(input as ZafKycGetIdResponseEntity);
        }

        /// <summary>
        /// Returns true if ZafKycGetIdResponseEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ZafKycGetIdResponseEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZafKycGetIdResponseEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BirthPlaceCountry == input.BirthPlaceCountry ||
                    (this.BirthPlaceCountry != null &&
                    this.BirthPlaceCountry.Equals(input.BirthPlaceCountry))
                ) && 
                (
                    this.BirthPlaceCountryCode == input.BirthPlaceCountryCode ||
                    (this.BirthPlaceCountryCode != null &&
                    this.BirthPlaceCountryCode.Equals(input.BirthPlaceCountryCode))
                ) && 
                (
                    this.BookedDate == input.BookedDate ||
                    (this.BookedDate != null &&
                    this.BookedDate.Equals(input.BookedDate))
                ) && 
                (
                    this.CardDate == input.CardDate ||
                    (this.CardDate != null &&
                    this.CardDate.Equals(input.CardDate))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.IdBlocked == input.IdBlocked ||
                    (this.IdBlocked != null &&
                    this.IdBlocked.Equals(input.IdBlocked))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.IssuedDate == input.IssuedDate ||
                    (this.IssuedDate != null &&
                    this.IssuedDate.Equals(input.IssuedDate))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.MaidenName == input.MaidenName ||
                    (this.MaidenName != null &&
                    this.MaidenName.Equals(input.MaidenName))
                ) && 
                (
                    this.MaritalStatus == input.MaritalStatus ||
                    (this.MaritalStatus != null &&
                    this.MaritalStatus.Equals(input.MaritalStatus))
                ) && 
                (
                    this.OnHANIS == input.OnHANIS ||
                    (this.OnHANIS != null &&
                    this.OnHANIS.Equals(input.OnHANIS))
                ) && 
                (
                    this.OnNPR == input.OnNPR ||
                    (this.OnNPR != null &&
                    this.OnNPR.Equals(input.OnNPR))
                ) && 
                (
                    this.Photo == input.Photo ||
                    (this.Photo != null &&
                    this.Photo.Equals(input.Photo))
                ) && 
                (
                    this.SmartCardIssued == input.SmartCardIssued ||
                    (this.SmartCardIssued != null &&
                    this.SmartCardIssued.Equals(input.SmartCardIssued))
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
                if (this.BirthPlaceCountry != null)
                {
                    hashCode = (hashCode * 59) + this.BirthPlaceCountry.GetHashCode();
                }
                if (this.BirthPlaceCountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.BirthPlaceCountryCode.GetHashCode();
                }
                if (this.BookedDate != null)
                {
                    hashCode = (hashCode * 59) + this.BookedDate.GetHashCode();
                }
                if (this.CardDate != null)
                {
                    hashCode = (hashCode * 59) + this.CardDate.GetHashCode();
                }
                if (this.DateOfBirth != null)
                {
                    hashCode = (hashCode * 59) + this.DateOfBirth.GetHashCode();
                }
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                if (this.Gender != null)
                {
                    hashCode = (hashCode * 59) + this.Gender.GetHashCode();
                }
                if (this.IdBlocked != null)
                {
                    hashCode = (hashCode * 59) + this.IdBlocked.GetHashCode();
                }
                if (this.IdNumber != null)
                {
                    hashCode = (hashCode * 59) + this.IdNumber.GetHashCode();
                }
                if (this.IssuedDate != null)
                {
                    hashCode = (hashCode * 59) + this.IssuedDate.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.MaidenName != null)
                {
                    hashCode = (hashCode * 59) + this.MaidenName.GetHashCode();
                }
                if (this.MaritalStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MaritalStatus.GetHashCode();
                }
                if (this.OnHANIS != null)
                {
                    hashCode = (hashCode * 59) + this.OnHANIS.GetHashCode();
                }
                if (this.OnNPR != null)
                {
                    hashCode = (hashCode * 59) + this.OnNPR.GetHashCode();
                }
                if (this.Photo != null)
                {
                    hashCode = (hashCode * 59) + this.Photo.GetHashCode();
                }
                if (this.SmartCardIssued != null)
                {
                    hashCode = (hashCode * 59) + this.SmartCardIssued.GetHashCode();
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
