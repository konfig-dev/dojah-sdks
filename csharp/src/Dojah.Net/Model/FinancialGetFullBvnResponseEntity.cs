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
    /// FinancialGetFullBvnResponseEntity
    /// </summary>
    [DataContract(Name = "FinancialGetFullBvnResponse_entity")]
    public partial class FinancialGetFullBvnResponseEntity : IEquatable<FinancialGetFullBvnResponseEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialGetFullBvnResponseEntity" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="bvn">bvn.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="email">email.</param>
        /// <param name="enrollmentBank">enrollmentBank.</param>
        /// <param name="enrollmentBranch">enrollmentBranch.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="gender">gender.</param>
        /// <param name="image">image.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="levelOfAccount">levelOfAccount.</param>
        /// <param name="lgaOfOrigin">lgaOfOrigin.</param>
        /// <param name="lgaOfResidence">lgaOfResidence.</param>
        /// <param name="maritalStatus">maritalStatus.</param>
        /// <param name="middleName">middleName.</param>
        /// <param name="nameOnCard">nameOnCard.</param>
        /// <param name="nationality">nationality.</param>
        /// <param name="nin">nin.</param>
        /// <param name="phoneNumber1">phoneNumber1.</param>
        /// <param name="phoneNumber2">phoneNumber2.</param>
        /// <param name="registrationDate">registrationDate.</param>
        /// <param name="residentialAddress">residentialAddress.</param>
        /// <param name="stateOfOrigin">stateOfOrigin.</param>
        /// <param name="stateOfResidence">stateOfResidence.</param>
        /// <param name="watchListed">watchListed.</param>
        public FinancialGetFullBvnResponseEntity(string title = default(string), string bvn = default(string), string dateOfBirth = default(string), string email = default(string), string enrollmentBank = default(string), string enrollmentBranch = default(string), string firstName = default(string), string gender = default(string), string image = default(string), string lastName = default(string), string levelOfAccount = default(string), string lgaOfOrigin = default(string), string lgaOfResidence = default(string), string maritalStatus = default(string), string middleName = default(string), string nameOnCard = default(string), string nationality = default(string), string nin = default(string), string phoneNumber1 = default(string), string phoneNumber2 = default(string), string registrationDate = default(string), string residentialAddress = default(string), string stateOfOrigin = default(string), string stateOfResidence = default(string), string watchListed = default(string))
        {
            this.Title = title;
            this.Bvn = bvn;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.EnrollmentBank = enrollmentBank;
            this.EnrollmentBranch = enrollmentBranch;
            this.FirstName = firstName;
            this.Gender = gender;
            this.Image = image;
            this.LastName = lastName;
            this.LevelOfAccount = levelOfAccount;
            this.LgaOfOrigin = lgaOfOrigin;
            this.LgaOfResidence = lgaOfResidence;
            this.MaritalStatus = maritalStatus;
            this.MiddleName = middleName;
            this.NameOnCard = nameOnCard;
            this.Nationality = nationality;
            this.Nin = nin;
            this.PhoneNumber1 = phoneNumber1;
            this.PhoneNumber2 = phoneNumber2;
            this.RegistrationDate = registrationDate;
            this.ResidentialAddress = residentialAddress;
            this.StateOfOrigin = stateOfOrigin;
            this.StateOfResidence = stateOfResidence;
            this.WatchListed = watchListed;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Bvn
        /// </summary>
        [DataMember(Name = "bvn", EmitDefaultValue = false)]
        public string Bvn { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name = "date_of_birth", EmitDefaultValue = false)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets EnrollmentBank
        /// </summary>
        [DataMember(Name = "enrollment_bank", EmitDefaultValue = false)]
        public string EnrollmentBank { get; set; }

        /// <summary>
        /// Gets or Sets EnrollmentBranch
        /// </summary>
        [DataMember(Name = "enrollment_branch", EmitDefaultValue = false)]
        public string EnrollmentBranch { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets LevelOfAccount
        /// </summary>
        [DataMember(Name = "level_of_account", EmitDefaultValue = false)]
        public string LevelOfAccount { get; set; }

        /// <summary>
        /// Gets or Sets LgaOfOrigin
        /// </summary>
        [DataMember(Name = "lga_of_origin", EmitDefaultValue = false)]
        public string LgaOfOrigin { get; set; }

        /// <summary>
        /// Gets or Sets LgaOfResidence
        /// </summary>
        [DataMember(Name = "lga_of_residence", EmitDefaultValue = false)]
        public string LgaOfResidence { get; set; }

        /// <summary>
        /// Gets or Sets MaritalStatus
        /// </summary>
        [DataMember(Name = "marital_status", EmitDefaultValue = false)]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name = "middle_name", EmitDefaultValue = false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets NameOnCard
        /// </summary>
        [DataMember(Name = "name_on_card", EmitDefaultValue = false)]
        public string NameOnCard { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>
        [DataMember(Name = "nationality", EmitDefaultValue = false)]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or Sets Nin
        /// </summary>
        [DataMember(Name = "nin", EmitDefaultValue = false)]
        public string Nin { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber1
        /// </summary>
        [DataMember(Name = "phone_number1", EmitDefaultValue = false)]
        public string PhoneNumber1 { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber2
        /// </summary>
        [DataMember(Name = "phone_number2", EmitDefaultValue = false)]
        public string PhoneNumber2 { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDate
        /// </summary>
        [DataMember(Name = "registration_date", EmitDefaultValue = false)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets ResidentialAddress
        /// </summary>
        [DataMember(Name = "residential_address", EmitDefaultValue = false)]
        public string ResidentialAddress { get; set; }

        /// <summary>
        /// Gets or Sets StateOfOrigin
        /// </summary>
        [DataMember(Name = "state_of_origin", EmitDefaultValue = false)]
        public string StateOfOrigin { get; set; }

        /// <summary>
        /// Gets or Sets StateOfResidence
        /// </summary>
        [DataMember(Name = "state_of_residence", EmitDefaultValue = false)]
        public string StateOfResidence { get; set; }

        /// <summary>
        /// Gets or Sets WatchListed
        /// </summary>
        [DataMember(Name = "watch_listed", EmitDefaultValue = false)]
        public string WatchListed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FinancialGetFullBvnResponseEntity {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Bvn: ").Append(Bvn).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EnrollmentBank: ").Append(EnrollmentBank).Append("\n");
            sb.Append("  EnrollmentBranch: ").Append(EnrollmentBranch).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  LevelOfAccount: ").Append(LevelOfAccount).Append("\n");
            sb.Append("  LgaOfOrigin: ").Append(LgaOfOrigin).Append("\n");
            sb.Append("  LgaOfResidence: ").Append(LgaOfResidence).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  NameOnCard: ").Append(NameOnCard).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  Nin: ").Append(Nin).Append("\n");
            sb.Append("  PhoneNumber1: ").Append(PhoneNumber1).Append("\n");
            sb.Append("  PhoneNumber2: ").Append(PhoneNumber2).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  ResidentialAddress: ").Append(ResidentialAddress).Append("\n");
            sb.Append("  StateOfOrigin: ").Append(StateOfOrigin).Append("\n");
            sb.Append("  StateOfResidence: ").Append(StateOfResidence).Append("\n");
            sb.Append("  WatchListed: ").Append(WatchListed).Append("\n");
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
            return this.Equals(input as FinancialGetFullBvnResponseEntity);
        }

        /// <summary>
        /// Returns true if FinancialGetFullBvnResponseEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of FinancialGetFullBvnResponseEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinancialGetFullBvnResponseEntity input)
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
                    this.Bvn == input.Bvn ||
                    (this.Bvn != null &&
                    this.Bvn.Equals(input.Bvn))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.EnrollmentBank == input.EnrollmentBank ||
                    (this.EnrollmentBank != null &&
                    this.EnrollmentBank.Equals(input.EnrollmentBank))
                ) && 
                (
                    this.EnrollmentBranch == input.EnrollmentBranch ||
                    (this.EnrollmentBranch != null &&
                    this.EnrollmentBranch.Equals(input.EnrollmentBranch))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.LevelOfAccount == input.LevelOfAccount ||
                    (this.LevelOfAccount != null &&
                    this.LevelOfAccount.Equals(input.LevelOfAccount))
                ) && 
                (
                    this.LgaOfOrigin == input.LgaOfOrigin ||
                    (this.LgaOfOrigin != null &&
                    this.LgaOfOrigin.Equals(input.LgaOfOrigin))
                ) && 
                (
                    this.LgaOfResidence == input.LgaOfResidence ||
                    (this.LgaOfResidence != null &&
                    this.LgaOfResidence.Equals(input.LgaOfResidence))
                ) && 
                (
                    this.MaritalStatus == input.MaritalStatus ||
                    (this.MaritalStatus != null &&
                    this.MaritalStatus.Equals(input.MaritalStatus))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.NameOnCard == input.NameOnCard ||
                    (this.NameOnCard != null &&
                    this.NameOnCard.Equals(input.NameOnCard))
                ) && 
                (
                    this.Nationality == input.Nationality ||
                    (this.Nationality != null &&
                    this.Nationality.Equals(input.Nationality))
                ) && 
                (
                    this.Nin == input.Nin ||
                    (this.Nin != null &&
                    this.Nin.Equals(input.Nin))
                ) && 
                (
                    this.PhoneNumber1 == input.PhoneNumber1 ||
                    (this.PhoneNumber1 != null &&
                    this.PhoneNumber1.Equals(input.PhoneNumber1))
                ) && 
                (
                    this.PhoneNumber2 == input.PhoneNumber2 ||
                    (this.PhoneNumber2 != null &&
                    this.PhoneNumber2.Equals(input.PhoneNumber2))
                ) && 
                (
                    this.RegistrationDate == input.RegistrationDate ||
                    (this.RegistrationDate != null &&
                    this.RegistrationDate.Equals(input.RegistrationDate))
                ) && 
                (
                    this.ResidentialAddress == input.ResidentialAddress ||
                    (this.ResidentialAddress != null &&
                    this.ResidentialAddress.Equals(input.ResidentialAddress))
                ) && 
                (
                    this.StateOfOrigin == input.StateOfOrigin ||
                    (this.StateOfOrigin != null &&
                    this.StateOfOrigin.Equals(input.StateOfOrigin))
                ) && 
                (
                    this.StateOfResidence == input.StateOfResidence ||
                    (this.StateOfResidence != null &&
                    this.StateOfResidence.Equals(input.StateOfResidence))
                ) && 
                (
                    this.WatchListed == input.WatchListed ||
                    (this.WatchListed != null &&
                    this.WatchListed.Equals(input.WatchListed))
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
                if (this.Bvn != null)
                {
                    hashCode = (hashCode * 59) + this.Bvn.GetHashCode();
                }
                if (this.DateOfBirth != null)
                {
                    hashCode = (hashCode * 59) + this.DateOfBirth.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.EnrollmentBank != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollmentBank.GetHashCode();
                }
                if (this.EnrollmentBranch != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollmentBranch.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.Gender != null)
                {
                    hashCode = (hashCode * 59) + this.Gender.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.LevelOfAccount != null)
                {
                    hashCode = (hashCode * 59) + this.LevelOfAccount.GetHashCode();
                }
                if (this.LgaOfOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.LgaOfOrigin.GetHashCode();
                }
                if (this.LgaOfResidence != null)
                {
                    hashCode = (hashCode * 59) + this.LgaOfResidence.GetHashCode();
                }
                if (this.MaritalStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MaritalStatus.GetHashCode();
                }
                if (this.MiddleName != null)
                {
                    hashCode = (hashCode * 59) + this.MiddleName.GetHashCode();
                }
                if (this.NameOnCard != null)
                {
                    hashCode = (hashCode * 59) + this.NameOnCard.GetHashCode();
                }
                if (this.Nationality != null)
                {
                    hashCode = (hashCode * 59) + this.Nationality.GetHashCode();
                }
                if (this.Nin != null)
                {
                    hashCode = (hashCode * 59) + this.Nin.GetHashCode();
                }
                if (this.PhoneNumber1 != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber1.GetHashCode();
                }
                if (this.PhoneNumber2 != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber2.GetHashCode();
                }
                if (this.RegistrationDate != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationDate.GetHashCode();
                }
                if (this.ResidentialAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ResidentialAddress.GetHashCode();
                }
                if (this.StateOfOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.StateOfOrigin.GetHashCode();
                }
                if (this.StateOfResidence != null)
                {
                    hashCode = (hashCode * 59) + this.StateOfResidence.GetHashCode();
                }
                if (this.WatchListed != null)
                {
                    hashCode = (hashCode * 59) + this.WatchListed.GetHashCode();
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
