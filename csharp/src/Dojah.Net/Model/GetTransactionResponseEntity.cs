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
    /// GetTransactionResponseEntity
    /// </summary>
    [DataContract(Name = "GetTransactionResponse_entity")]
    public partial class GetTransactionResponseEntity : IEquatable<GetTransactionResponseEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionResponseEntity" /> class.
        /// </summary>
        /// <param name="walletId">walletId.</param>
        /// <param name="transactionAmount">transactionAmount.</param>
        /// <param name="transactionType">transactionType.</param>
        /// <param name="recipientAccountNumber">recipientAccountNumber.</param>
        /// <param name="senderAccountNumber">senderAccountNumber.</param>
        /// <param name="transactionRemarks">transactionRemarks.</param>
        /// <param name="transactionReason">transactionReason.</param>
        /// <param name="transactionId">transactionId.</param>
        /// <param name="transactionStatus">transactionStatus.</param>
        /// <param name="dateCreated">dateCreated.</param>
        public GetTransactionResponseEntity(string walletId = default(string), decimal transactionAmount = default(decimal), string transactionType = default(string), string recipientAccountNumber = default(string), string senderAccountNumber = default(string), string transactionRemarks = default(string), string transactionReason = default(string), string transactionId = default(string), string transactionStatus = default(string), string dateCreated = default(string))
        {
            this.WalletId = walletId;
            this.TransactionAmount = transactionAmount;
            this.TransactionType = transactionType;
            this.RecipientAccountNumber = recipientAccountNumber;
            this.SenderAccountNumber = senderAccountNumber;
            this.TransactionRemarks = transactionRemarks;
            this.TransactionReason = transactionReason;
            this.TransactionId = transactionId;
            this.TransactionStatus = transactionStatus;
            this.DateCreated = dateCreated;
        }

        /// <summary>
        /// Gets or Sets WalletId
        /// </summary>
        [DataMember(Name = "wallet_id", EmitDefaultValue = false)]
        public string WalletId { get; set; }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name = "transaction_amount", EmitDefaultValue = false)]
        public decimal TransactionAmount { get; set; }

        /// <summary>
        /// Gets or Sets TransactionType
        /// </summary>
        [DataMember(Name = "transaction_type", EmitDefaultValue = false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or Sets RecipientAccountNumber
        /// </summary>
        [DataMember(Name = "recipient_account_number", EmitDefaultValue = false)]
        public string RecipientAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets SenderAccountNumber
        /// </summary>
        [DataMember(Name = "sender_account_number", EmitDefaultValue = false)]
        public string SenderAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets TransactionRemarks
        /// </summary>
        [DataMember(Name = "transaction_remarks", EmitDefaultValue = false)]
        public string TransactionRemarks { get; set; }

        /// <summary>
        /// Gets or Sets TransactionReason
        /// </summary>
        [DataMember(Name = "transaction_reason", EmitDefaultValue = true)]
        public string TransactionReason { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name = "transaction_id", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets TransactionStatus
        /// </summary>
        [DataMember(Name = "transaction_status", EmitDefaultValue = false)]
        public string TransactionStatus { get; set; }

        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name = "date_created", EmitDefaultValue = false)]
        public string DateCreated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionResponseEntity {\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  RecipientAccountNumber: ").Append(RecipientAccountNumber).Append("\n");
            sb.Append("  SenderAccountNumber: ").Append(SenderAccountNumber).Append("\n");
            sb.Append("  TransactionRemarks: ").Append(TransactionRemarks).Append("\n");
            sb.Append("  TransactionReason: ").Append(TransactionReason).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
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
            return this.Equals(input as GetTransactionResponseEntity);
        }

        /// <summary>
        /// Returns true if GetTransactionResponseEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionResponseEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionResponseEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    this.TransactionAmount.Equals(input.TransactionAmount)
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) && 
                (
                    this.RecipientAccountNumber == input.RecipientAccountNumber ||
                    (this.RecipientAccountNumber != null &&
                    this.RecipientAccountNumber.Equals(input.RecipientAccountNumber))
                ) && 
                (
                    this.SenderAccountNumber == input.SenderAccountNumber ||
                    (this.SenderAccountNumber != null &&
                    this.SenderAccountNumber.Equals(input.SenderAccountNumber))
                ) && 
                (
                    this.TransactionRemarks == input.TransactionRemarks ||
                    (this.TransactionRemarks != null &&
                    this.TransactionRemarks.Equals(input.TransactionRemarks))
                ) && 
                (
                    this.TransactionReason == input.TransactionReason ||
                    (this.TransactionReason != null &&
                    this.TransactionReason.Equals(input.TransactionReason))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    (this.TransactionStatus != null &&
                    this.TransactionStatus.Equals(input.TransactionStatus))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
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
                if (this.WalletId != null)
                {
                    hashCode = (hashCode * 59) + this.WalletId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TransactionAmount.GetHashCode();
                if (this.TransactionType != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionType.GetHashCode();
                }
                if (this.RecipientAccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RecipientAccountNumber.GetHashCode();
                }
                if (this.SenderAccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SenderAccountNumber.GetHashCode();
                }
                if (this.TransactionRemarks != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionRemarks.GetHashCode();
                }
                if (this.TransactionReason != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionReason.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.TransactionStatus != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionStatus.GetHashCode();
                }
                if (this.DateCreated != null)
                {
                    hashCode = (hashCode * 59) + this.DateCreated.GetHashCode();
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
