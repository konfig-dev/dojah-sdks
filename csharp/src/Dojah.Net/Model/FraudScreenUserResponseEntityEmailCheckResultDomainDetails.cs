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
    /// FraudScreenUserResponseEntityEmailCheckResultDomainDetails
    /// </summary>
    [DataContract(Name = "FraudScreenUserResponse_entity_email_check_result_domain_details")]
    public partial class FraudScreenUserResponseEntityEmailCheckResultDomainDetails : IEquatable<FraudScreenUserResponseEntityEmailCheckResultDomainDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudScreenUserResponseEntityEmailCheckResultDomainDetails" /> class.
        /// </summary>
        /// <param name="domain">domain.</param>
        /// <param name="tld">tld.</param>
        /// <param name="registered">registered.</param>
        /// <param name="created">created.</param>
        /// <param name="updated">updated.</param>
        /// <param name="expires">expires.</param>
        /// <param name="registrarName">registrarName.</param>
        /// <param name="registeredTo">registeredTo.</param>
        /// <param name="disposable">disposable.</param>
        /// <param name="free">free.</param>
        /// <param name="custom">custom.</param>
        /// <param name="dmarcEnforced">dmarcEnforced.</param>
        /// <param name="spfStrict">spfStrict.</param>
        /// <param name="validMx">validMx.</param>
        /// <param name="acceptAll">acceptAll.</param>
        /// <param name="suspiciousTld">suspiciousTld.</param>
        /// <param name="websiteExists">websiteExists.</param>
        public FraudScreenUserResponseEntityEmailCheckResultDomainDetails(string domain = default(string), string tld = default(string), bool registered = default(bool), string created = default(string), string updated = default(string), string expires = default(string), string registrarName = default(string), string registeredTo = default(string), bool disposable = default(bool), bool free = default(bool), bool custom = default(bool), bool dmarcEnforced = default(bool), bool spfStrict = default(bool), bool validMx = default(bool), bool acceptAll = default(bool), bool suspiciousTld = default(bool), bool websiteExists = default(bool))
        {
            this.Domain = domain;
            this.Tld = tld;
            this.Registered = registered;
            this.Created = created;
            this.Updated = updated;
            this.Expires = expires;
            this.RegistrarName = registrarName;
            this.RegisteredTo = registeredTo;
            this.Disposable = disposable;
            this.Free = free;
            this.Custom = custom;
            this.DmarcEnforced = dmarcEnforced;
            this.SpfStrict = spfStrict;
            this.ValidMx = validMx;
            this.AcceptAll = acceptAll;
            this.SuspiciousTld = suspiciousTld;
            this.WebsiteExists = websiteExists;
        }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or Sets Tld
        /// </summary>
        [DataMember(Name = "tld", EmitDefaultValue = false)]
        public string Tld { get; set; }

        /// <summary>
        /// Gets or Sets Registered
        /// </summary>
        [DataMember(Name = "registered", EmitDefaultValue = true)]
        public bool Registered { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", EmitDefaultValue = false)]
        public string Updated { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        public string Expires { get; set; }

        /// <summary>
        /// Gets or Sets RegistrarName
        /// </summary>
        [DataMember(Name = "registrar_name", EmitDefaultValue = false)]
        public string RegistrarName { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredTo
        /// </summary>
        [DataMember(Name = "registered_to", EmitDefaultValue = false)]
        public string RegisteredTo { get; set; }

        /// <summary>
        /// Gets or Sets Disposable
        /// </summary>
        [DataMember(Name = "disposable", EmitDefaultValue = true)]
        public bool Disposable { get; set; }

        /// <summary>
        /// Gets or Sets Free
        /// </summary>
        [DataMember(Name = "free", EmitDefaultValue = true)]
        public bool Free { get; set; }

        /// <summary>
        /// Gets or Sets Custom
        /// </summary>
        [DataMember(Name = "custom", EmitDefaultValue = true)]
        public bool Custom { get; set; }

        /// <summary>
        /// Gets or Sets DmarcEnforced
        /// </summary>
        [DataMember(Name = "dmarc_enforced", EmitDefaultValue = true)]
        public bool DmarcEnforced { get; set; }

        /// <summary>
        /// Gets or Sets SpfStrict
        /// </summary>
        [DataMember(Name = "spf_strict", EmitDefaultValue = true)]
        public bool SpfStrict { get; set; }

        /// <summary>
        /// Gets or Sets ValidMx
        /// </summary>
        [DataMember(Name = "valid_mx", EmitDefaultValue = true)]
        public bool ValidMx { get; set; }

        /// <summary>
        /// Gets or Sets AcceptAll
        /// </summary>
        [DataMember(Name = "accept_all", EmitDefaultValue = true)]
        public bool AcceptAll { get; set; }

        /// <summary>
        /// Gets or Sets SuspiciousTld
        /// </summary>
        [DataMember(Name = "suspicious_tld", EmitDefaultValue = true)]
        public bool SuspiciousTld { get; set; }

        /// <summary>
        /// Gets or Sets WebsiteExists
        /// </summary>
        [DataMember(Name = "website_exists", EmitDefaultValue = true)]
        public bool WebsiteExists { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FraudScreenUserResponseEntityEmailCheckResultDomainDetails {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Tld: ").Append(Tld).Append("\n");
            sb.Append("  Registered: ").Append(Registered).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  RegistrarName: ").Append(RegistrarName).Append("\n");
            sb.Append("  RegisteredTo: ").Append(RegisteredTo).Append("\n");
            sb.Append("  Disposable: ").Append(Disposable).Append("\n");
            sb.Append("  Free: ").Append(Free).Append("\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
            sb.Append("  DmarcEnforced: ").Append(DmarcEnforced).Append("\n");
            sb.Append("  SpfStrict: ").Append(SpfStrict).Append("\n");
            sb.Append("  ValidMx: ").Append(ValidMx).Append("\n");
            sb.Append("  AcceptAll: ").Append(AcceptAll).Append("\n");
            sb.Append("  SuspiciousTld: ").Append(SuspiciousTld).Append("\n");
            sb.Append("  WebsiteExists: ").Append(WebsiteExists).Append("\n");
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
            return this.Equals(input as FraudScreenUserResponseEntityEmailCheckResultDomainDetails);
        }

        /// <summary>
        /// Returns true if FraudScreenUserResponseEntityEmailCheckResultDomainDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudScreenUserResponseEntityEmailCheckResultDomainDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudScreenUserResponseEntityEmailCheckResultDomainDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Tld == input.Tld ||
                    (this.Tld != null &&
                    this.Tld.Equals(input.Tld))
                ) && 
                (
                    this.Registered == input.Registered ||
                    this.Registered.Equals(input.Registered)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
                ) && 
                (
                    this.RegistrarName == input.RegistrarName ||
                    (this.RegistrarName != null &&
                    this.RegistrarName.Equals(input.RegistrarName))
                ) && 
                (
                    this.RegisteredTo == input.RegisteredTo ||
                    (this.RegisteredTo != null &&
                    this.RegisteredTo.Equals(input.RegisteredTo))
                ) && 
                (
                    this.Disposable == input.Disposable ||
                    this.Disposable.Equals(input.Disposable)
                ) && 
                (
                    this.Free == input.Free ||
                    this.Free.Equals(input.Free)
                ) && 
                (
                    this.Custom == input.Custom ||
                    this.Custom.Equals(input.Custom)
                ) && 
                (
                    this.DmarcEnforced == input.DmarcEnforced ||
                    this.DmarcEnforced.Equals(input.DmarcEnforced)
                ) && 
                (
                    this.SpfStrict == input.SpfStrict ||
                    this.SpfStrict.Equals(input.SpfStrict)
                ) && 
                (
                    this.ValidMx == input.ValidMx ||
                    this.ValidMx.Equals(input.ValidMx)
                ) && 
                (
                    this.AcceptAll == input.AcceptAll ||
                    this.AcceptAll.Equals(input.AcceptAll)
                ) && 
                (
                    this.SuspiciousTld == input.SuspiciousTld ||
                    this.SuspiciousTld.Equals(input.SuspiciousTld)
                ) && 
                (
                    this.WebsiteExists == input.WebsiteExists ||
                    this.WebsiteExists.Equals(input.WebsiteExists)
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
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
                }
                if (this.Tld != null)
                {
                    hashCode = (hashCode * 59) + this.Tld.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Registered.GetHashCode();
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Updated != null)
                {
                    hashCode = (hashCode * 59) + this.Updated.GetHashCode();
                }
                if (this.Expires != null)
                {
                    hashCode = (hashCode * 59) + this.Expires.GetHashCode();
                }
                if (this.RegistrarName != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrarName.GetHashCode();
                }
                if (this.RegisteredTo != null)
                {
                    hashCode = (hashCode * 59) + this.RegisteredTo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Disposable.GetHashCode();
                hashCode = (hashCode * 59) + this.Free.GetHashCode();
                hashCode = (hashCode * 59) + this.Custom.GetHashCode();
                hashCode = (hashCode * 59) + this.DmarcEnforced.GetHashCode();
                hashCode = (hashCode * 59) + this.SpfStrict.GetHashCode();
                hashCode = (hashCode * 59) + this.ValidMx.GetHashCode();
                hashCode = (hashCode * 59) + this.AcceptAll.GetHashCode();
                hashCode = (hashCode * 59) + this.SuspiciousTld.GetHashCode();
                hashCode = (hashCode * 59) + this.WebsiteExists.GetHashCode();
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
