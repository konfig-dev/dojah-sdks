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
    /// FraudGetEmailReputationResponseEntityDetails
    /// </summary>
    [DataContract(Name = "FraudGetEmailReputationResponse_entity_details")]
    public partial class FraudGetEmailReputationResponseEntityDetails : IEquatable<FraudGetEmailReputationResponseEntityDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudGetEmailReputationResponseEntityDetails" /> class.
        /// </summary>
        /// <param name="blacklisted">blacklisted.</param>
        /// <param name="maliciousActivity">maliciousActivity.</param>
        /// <param name="maliciousActivityRecent">maliciousActivityRecent.</param>
        /// <param name="credentialsLeaked">credentialsLeaked.</param>
        /// <param name="credentialsLeakedRecent">credentialsLeakedRecent.</param>
        /// <param name="dataBreach">dataBreach.</param>
        /// <param name="firstSeen">firstSeen.</param>
        /// <param name="lastSeen">lastSeen.</param>
        /// <param name="domainExists">domainExists.</param>
        /// <param name="domainReputation">domainReputation.</param>
        /// <param name="newDomain">newDomain.</param>
        /// <param name="daysSinceDomainCreation">daysSinceDomainCreation.</param>
        /// <param name="suspiciousTld">suspiciousTld.</param>
        /// <param name="spam">spam.</param>
        /// <param name="freeProvider">freeProvider.</param>
        /// <param name="disposable">disposable.</param>
        /// <param name="deliverable">deliverable.</param>
        /// <param name="acceptAll">acceptAll.</param>
        /// <param name="validMx">validMx.</param>
        /// <param name="primaryMx">primaryMx.</param>
        /// <param name="spoofable">spoofable.</param>
        /// <param name="spfStrict">spfStrict.</param>
        /// <param name="dmarcEnforced">dmarcEnforced.</param>
        /// <param name="profiles">profiles.</param>
        public FraudGetEmailReputationResponseEntityDetails(bool blacklisted = default(bool), bool maliciousActivity = default(bool), bool maliciousActivityRecent = default(bool), bool credentialsLeaked = default(bool), bool credentialsLeakedRecent = default(bool), bool dataBreach = default(bool), string firstSeen = default(string), string lastSeen = default(string), bool domainExists = default(bool), string domainReputation = default(string), bool newDomain = default(bool), decimal daysSinceDomainCreation = default(decimal), bool suspiciousTld = default(bool), bool spam = default(bool), bool freeProvider = default(bool), bool disposable = default(bool), bool deliverable = default(bool), bool acceptAll = default(bool), bool validMx = default(bool), string primaryMx = default(string), bool spoofable = default(bool), bool spfStrict = default(bool), bool dmarcEnforced = default(bool), List<string> profiles = default(List<string>))
        {
            this.Blacklisted = blacklisted;
            this.MaliciousActivity = maliciousActivity;
            this.MaliciousActivityRecent = maliciousActivityRecent;
            this.CredentialsLeaked = credentialsLeaked;
            this.CredentialsLeakedRecent = credentialsLeakedRecent;
            this.DataBreach = dataBreach;
            this.FirstSeen = firstSeen;
            this.LastSeen = lastSeen;
            this.DomainExists = domainExists;
            this.DomainReputation = domainReputation;
            this.NewDomain = newDomain;
            this.DaysSinceDomainCreation = daysSinceDomainCreation;
            this.SuspiciousTld = suspiciousTld;
            this.Spam = spam;
            this.FreeProvider = freeProvider;
            this.Disposable = disposable;
            this.Deliverable = deliverable;
            this.AcceptAll = acceptAll;
            this.ValidMx = validMx;
            this.PrimaryMx = primaryMx;
            this.Spoofable = spoofable;
            this.SpfStrict = spfStrict;
            this.DmarcEnforced = dmarcEnforced;
            this.Profiles = profiles;
        }

        /// <summary>
        /// Gets or Sets Blacklisted
        /// </summary>
        [DataMember(Name = "blacklisted", EmitDefaultValue = true)]
        public bool Blacklisted { get; set; }

        /// <summary>
        /// Gets or Sets MaliciousActivity
        /// </summary>
        [DataMember(Name = "malicious_activity", EmitDefaultValue = true)]
        public bool MaliciousActivity { get; set; }

        /// <summary>
        /// Gets or Sets MaliciousActivityRecent
        /// </summary>
        [DataMember(Name = "malicious_activity_recent", EmitDefaultValue = true)]
        public bool MaliciousActivityRecent { get; set; }

        /// <summary>
        /// Gets or Sets CredentialsLeaked
        /// </summary>
        [DataMember(Name = "credentials_leaked", EmitDefaultValue = true)]
        public bool CredentialsLeaked { get; set; }

        /// <summary>
        /// Gets or Sets CredentialsLeakedRecent
        /// </summary>
        [DataMember(Name = "credentials_leaked_recent", EmitDefaultValue = true)]
        public bool CredentialsLeakedRecent { get; set; }

        /// <summary>
        /// Gets or Sets DataBreach
        /// </summary>
        [DataMember(Name = "data_breach", EmitDefaultValue = true)]
        public bool DataBreach { get; set; }

        /// <summary>
        /// Gets or Sets FirstSeen
        /// </summary>
        [DataMember(Name = "first_seen", EmitDefaultValue = false)]
        public string FirstSeen { get; set; }

        /// <summary>
        /// Gets or Sets LastSeen
        /// </summary>
        [DataMember(Name = "last_seen", EmitDefaultValue = false)]
        public string LastSeen { get; set; }

        /// <summary>
        /// Gets or Sets DomainExists
        /// </summary>
        [DataMember(Name = "domain_exists", EmitDefaultValue = true)]
        public bool DomainExists { get; set; }

        /// <summary>
        /// Gets or Sets DomainReputation
        /// </summary>
        [DataMember(Name = "domain_reputation", EmitDefaultValue = false)]
        public string DomainReputation { get; set; }

        /// <summary>
        /// Gets or Sets NewDomain
        /// </summary>
        [DataMember(Name = "new_domain", EmitDefaultValue = true)]
        public bool NewDomain { get; set; }

        /// <summary>
        /// Gets or Sets DaysSinceDomainCreation
        /// </summary>
        [DataMember(Name = "days_since_domain_creation", EmitDefaultValue = false)]
        public decimal DaysSinceDomainCreation { get; set; }

        /// <summary>
        /// Gets or Sets SuspiciousTld
        /// </summary>
        [DataMember(Name = "suspicious_tld", EmitDefaultValue = true)]
        public bool SuspiciousTld { get; set; }

        /// <summary>
        /// Gets or Sets Spam
        /// </summary>
        [DataMember(Name = "spam", EmitDefaultValue = true)]
        public bool Spam { get; set; }

        /// <summary>
        /// Gets or Sets FreeProvider
        /// </summary>
        [DataMember(Name = "free_provider", EmitDefaultValue = true)]
        public bool FreeProvider { get; set; }

        /// <summary>
        /// Gets or Sets Disposable
        /// </summary>
        [DataMember(Name = "disposable", EmitDefaultValue = true)]
        public bool Disposable { get; set; }

        /// <summary>
        /// Gets or Sets Deliverable
        /// </summary>
        [DataMember(Name = "deliverable", EmitDefaultValue = true)]
        public bool Deliverable { get; set; }

        /// <summary>
        /// Gets or Sets AcceptAll
        /// </summary>
        [DataMember(Name = "accept_all", EmitDefaultValue = true)]
        public bool AcceptAll { get; set; }

        /// <summary>
        /// Gets or Sets ValidMx
        /// </summary>
        [DataMember(Name = "valid_mx", EmitDefaultValue = true)]
        public bool ValidMx { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryMx
        /// </summary>
        [DataMember(Name = "primary_mx", EmitDefaultValue = false)]
        public string PrimaryMx { get; set; }

        /// <summary>
        /// Gets or Sets Spoofable
        /// </summary>
        [DataMember(Name = "spoofable", EmitDefaultValue = true)]
        public bool Spoofable { get; set; }

        /// <summary>
        /// Gets or Sets SpfStrict
        /// </summary>
        [DataMember(Name = "spf_strict", EmitDefaultValue = true)]
        public bool SpfStrict { get; set; }

        /// <summary>
        /// Gets or Sets DmarcEnforced
        /// </summary>
        [DataMember(Name = "dmarc_enforced", EmitDefaultValue = true)]
        public bool DmarcEnforced { get; set; }

        /// <summary>
        /// Gets or Sets Profiles
        /// </summary>
        [DataMember(Name = "profiles", EmitDefaultValue = false)]
        public List<string> Profiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FraudGetEmailReputationResponseEntityDetails {\n");
            sb.Append("  Blacklisted: ").Append(Blacklisted).Append("\n");
            sb.Append("  MaliciousActivity: ").Append(MaliciousActivity).Append("\n");
            sb.Append("  MaliciousActivityRecent: ").Append(MaliciousActivityRecent).Append("\n");
            sb.Append("  CredentialsLeaked: ").Append(CredentialsLeaked).Append("\n");
            sb.Append("  CredentialsLeakedRecent: ").Append(CredentialsLeakedRecent).Append("\n");
            sb.Append("  DataBreach: ").Append(DataBreach).Append("\n");
            sb.Append("  FirstSeen: ").Append(FirstSeen).Append("\n");
            sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
            sb.Append("  DomainExists: ").Append(DomainExists).Append("\n");
            sb.Append("  DomainReputation: ").Append(DomainReputation).Append("\n");
            sb.Append("  NewDomain: ").Append(NewDomain).Append("\n");
            sb.Append("  DaysSinceDomainCreation: ").Append(DaysSinceDomainCreation).Append("\n");
            sb.Append("  SuspiciousTld: ").Append(SuspiciousTld).Append("\n");
            sb.Append("  Spam: ").Append(Spam).Append("\n");
            sb.Append("  FreeProvider: ").Append(FreeProvider).Append("\n");
            sb.Append("  Disposable: ").Append(Disposable).Append("\n");
            sb.Append("  Deliverable: ").Append(Deliverable).Append("\n");
            sb.Append("  AcceptAll: ").Append(AcceptAll).Append("\n");
            sb.Append("  ValidMx: ").Append(ValidMx).Append("\n");
            sb.Append("  PrimaryMx: ").Append(PrimaryMx).Append("\n");
            sb.Append("  Spoofable: ").Append(Spoofable).Append("\n");
            sb.Append("  SpfStrict: ").Append(SpfStrict).Append("\n");
            sb.Append("  DmarcEnforced: ").Append(DmarcEnforced).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
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
            return this.Equals(input as FraudGetEmailReputationResponseEntityDetails);
        }

        /// <summary>
        /// Returns true if FraudGetEmailReputationResponseEntityDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudGetEmailReputationResponseEntityDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudGetEmailReputationResponseEntityDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Blacklisted == input.Blacklisted ||
                    this.Blacklisted.Equals(input.Blacklisted)
                ) && 
                (
                    this.MaliciousActivity == input.MaliciousActivity ||
                    this.MaliciousActivity.Equals(input.MaliciousActivity)
                ) && 
                (
                    this.MaliciousActivityRecent == input.MaliciousActivityRecent ||
                    this.MaliciousActivityRecent.Equals(input.MaliciousActivityRecent)
                ) && 
                (
                    this.CredentialsLeaked == input.CredentialsLeaked ||
                    this.CredentialsLeaked.Equals(input.CredentialsLeaked)
                ) && 
                (
                    this.CredentialsLeakedRecent == input.CredentialsLeakedRecent ||
                    this.CredentialsLeakedRecent.Equals(input.CredentialsLeakedRecent)
                ) && 
                (
                    this.DataBreach == input.DataBreach ||
                    this.DataBreach.Equals(input.DataBreach)
                ) && 
                (
                    this.FirstSeen == input.FirstSeen ||
                    (this.FirstSeen != null &&
                    this.FirstSeen.Equals(input.FirstSeen))
                ) && 
                (
                    this.LastSeen == input.LastSeen ||
                    (this.LastSeen != null &&
                    this.LastSeen.Equals(input.LastSeen))
                ) && 
                (
                    this.DomainExists == input.DomainExists ||
                    this.DomainExists.Equals(input.DomainExists)
                ) && 
                (
                    this.DomainReputation == input.DomainReputation ||
                    (this.DomainReputation != null &&
                    this.DomainReputation.Equals(input.DomainReputation))
                ) && 
                (
                    this.NewDomain == input.NewDomain ||
                    this.NewDomain.Equals(input.NewDomain)
                ) && 
                (
                    this.DaysSinceDomainCreation == input.DaysSinceDomainCreation ||
                    this.DaysSinceDomainCreation.Equals(input.DaysSinceDomainCreation)
                ) && 
                (
                    this.SuspiciousTld == input.SuspiciousTld ||
                    this.SuspiciousTld.Equals(input.SuspiciousTld)
                ) && 
                (
                    this.Spam == input.Spam ||
                    this.Spam.Equals(input.Spam)
                ) && 
                (
                    this.FreeProvider == input.FreeProvider ||
                    this.FreeProvider.Equals(input.FreeProvider)
                ) && 
                (
                    this.Disposable == input.Disposable ||
                    this.Disposable.Equals(input.Disposable)
                ) && 
                (
                    this.Deliverable == input.Deliverable ||
                    this.Deliverable.Equals(input.Deliverable)
                ) && 
                (
                    this.AcceptAll == input.AcceptAll ||
                    this.AcceptAll.Equals(input.AcceptAll)
                ) && 
                (
                    this.ValidMx == input.ValidMx ||
                    this.ValidMx.Equals(input.ValidMx)
                ) && 
                (
                    this.PrimaryMx == input.PrimaryMx ||
                    (this.PrimaryMx != null &&
                    this.PrimaryMx.Equals(input.PrimaryMx))
                ) && 
                (
                    this.Spoofable == input.Spoofable ||
                    this.Spoofable.Equals(input.Spoofable)
                ) && 
                (
                    this.SpfStrict == input.SpfStrict ||
                    this.SpfStrict.Equals(input.SpfStrict)
                ) && 
                (
                    this.DmarcEnforced == input.DmarcEnforced ||
                    this.DmarcEnforced.Equals(input.DmarcEnforced)
                ) && 
                (
                    this.Profiles == input.Profiles ||
                    this.Profiles != null &&
                    input.Profiles != null &&
                    this.Profiles.SequenceEqual(input.Profiles)
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
                hashCode = (hashCode * 59) + this.Blacklisted.GetHashCode();
                hashCode = (hashCode * 59) + this.MaliciousActivity.GetHashCode();
                hashCode = (hashCode * 59) + this.MaliciousActivityRecent.GetHashCode();
                hashCode = (hashCode * 59) + this.CredentialsLeaked.GetHashCode();
                hashCode = (hashCode * 59) + this.CredentialsLeakedRecent.GetHashCode();
                hashCode = (hashCode * 59) + this.DataBreach.GetHashCode();
                if (this.FirstSeen != null)
                {
                    hashCode = (hashCode * 59) + this.FirstSeen.GetHashCode();
                }
                if (this.LastSeen != null)
                {
                    hashCode = (hashCode * 59) + this.LastSeen.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DomainExists.GetHashCode();
                if (this.DomainReputation != null)
                {
                    hashCode = (hashCode * 59) + this.DomainReputation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NewDomain.GetHashCode();
                hashCode = (hashCode * 59) + this.DaysSinceDomainCreation.GetHashCode();
                hashCode = (hashCode * 59) + this.SuspiciousTld.GetHashCode();
                hashCode = (hashCode * 59) + this.Spam.GetHashCode();
                hashCode = (hashCode * 59) + this.FreeProvider.GetHashCode();
                hashCode = (hashCode * 59) + this.Disposable.GetHashCode();
                hashCode = (hashCode * 59) + this.Deliverable.GetHashCode();
                hashCode = (hashCode * 59) + this.AcceptAll.GetHashCode();
                hashCode = (hashCode * 59) + this.ValidMx.GetHashCode();
                if (this.PrimaryMx != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryMx.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Spoofable.GetHashCode();
                hashCode = (hashCode * 59) + this.SpfStrict.GetHashCode();
                hashCode = (hashCode * 59) + this.DmarcEnforced.GetHashCode();
                if (this.Profiles != null)
                {
                    hashCode = (hashCode * 59) + this.Profiles.GetHashCode();
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
