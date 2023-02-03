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
    /// SendSmsResponseEntity
    /// </summary>
    [DataContract(Name = "SendSmsResponse_entity")]
    public partial class SendSmsResponseEntity : IEquatable<SendSmsResponseEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendSmsResponseEntity" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="mobile">mobile.</param>
        /// <param name="messageId">messageId.</param>
        /// <param name="batchId">batchId.</param>
        public SendSmsResponseEntity(bool status = default(bool), string mobile = default(string), string messageId = default(string), string batchId = default(string))
        {
            this.Status = status;
            this.Mobile = mobile;
            this.MessageId = messageId;
            this.BatchId = batchId;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public bool Status { get; set; }

        /// <summary>
        /// Gets or Sets Mobile
        /// </summary>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "message_id", EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets BatchId
        /// </summary>
        [DataMember(Name = "batch_id", EmitDefaultValue = false)]
        public string BatchId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SendSmsResponseEntity {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
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
            return this.Equals(input as SendSmsResponseEntity);
        }

        /// <summary>
        /// Returns true if SendSmsResponseEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of SendSmsResponseEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendSmsResponseEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Mobile != null)
                {
                    hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                }
                if (this.MessageId != null)
                {
                    hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                }
                if (this.BatchId != null)
                {
                    hashCode = (hashCode * 59) + this.BatchId.GetHashCode();
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
