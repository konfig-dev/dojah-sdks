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
    /// GetAccountAnalysisResponseEntityFundsManagement
    /// </summary>
    [DataContract(Name = "GetAccountAnalysisResponse_entity_fundsManagement")]
    public partial class GetAccountAnalysisResponseEntityFundsManagement : IEquatable<GetAccountAnalysisResponseEntityFundsManagement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountAnalysisResponseEntityFundsManagement" /> class.
        /// </summary>
        /// <param name="accountActivity">accountActivity.</param>
        /// <param name="accountSweep">accountSweep.</param>
        /// <param name="averageMonthlyLoanAmount">averageMonthlyLoanAmount.</param>
        /// <param name="averageMonthlyLoanRepaymentAmount">averageMonthlyLoanRepaymentAmount.</param>
        /// <param name="gamblingRate">gamblingRate.</param>
        /// <param name="gamblingStatus">gamblingStatus.</param>
        /// <param name="loanInflowAmount">loanInflowAmount.</param>
        /// <param name="loanRepaymentToInflowAmount">loanRepaymentToInflowAmount.</param>
        /// <param name="monthToMonthInflowToOutflowAmount">monthToMonthInflowToOutflowAmount.</param>
        /// <param name="numberOfCreditLoanTransactions">numberOfCreditLoanTransactions.</param>
        /// <param name="numberOfDebitRepaymentTransactions">numberOfDebitRepaymentTransactions.</param>
        /// <param name="overallInflowToOutflowAmount">overallInflowToOutflowAmount.</param>
        /// <param name="percentOfInflowIrregularity">percentOfInflowIrregularity.</param>
        /// <param name="totalLoanAmount">totalLoanAmount.</param>
        /// <param name="totalLoanRepaymentAmount">totalLoanRepaymentAmount.</param>
        public GetAccountAnalysisResponseEntityFundsManagement(decimal accountActivity = default(decimal), string accountSweep = default(string), decimal averageMonthlyLoanAmount = default(decimal), decimal averageMonthlyLoanRepaymentAmount = default(decimal), decimal gamblingRate = default(decimal), string gamblingStatus = default(string), string loanInflowAmount = default(string), decimal loanRepaymentToInflowAmount = default(decimal), string monthToMonthInflowToOutflowAmount = default(string), string numberOfCreditLoanTransactions = default(string), string numberOfDebitRepaymentTransactions = default(string), string overallInflowToOutflowAmount = default(string), decimal percentOfInflowIrregularity = default(decimal), decimal totalLoanAmount = default(decimal), decimal totalLoanRepaymentAmount = default(decimal))
        {
            this.AccountActivity = accountActivity;
            this.AccountSweep = accountSweep;
            this.AverageMonthlyLoanAmount = averageMonthlyLoanAmount;
            this.AverageMonthlyLoanRepaymentAmount = averageMonthlyLoanRepaymentAmount;
            this.GamblingRate = gamblingRate;
            this.GamblingStatus = gamblingStatus;
            this.LoanInflowAmount = loanInflowAmount;
            this.LoanRepaymentToInflowAmount = loanRepaymentToInflowAmount;
            this.MonthToMonthInflowToOutflowAmount = monthToMonthInflowToOutflowAmount;
            this.NumberOfCreditLoanTransactions = numberOfCreditLoanTransactions;
            this.NumberOfDebitRepaymentTransactions = numberOfDebitRepaymentTransactions;
            this.OverallInflowToOutflowAmount = overallInflowToOutflowAmount;
            this.PercentOfInflowIrregularity = percentOfInflowIrregularity;
            this.TotalLoanAmount = totalLoanAmount;
            this.TotalLoanRepaymentAmount = totalLoanRepaymentAmount;
        }

        /// <summary>
        /// Gets or Sets AccountActivity
        /// </summary>
        [DataMember(Name = "accountActivity", EmitDefaultValue = false)]
        public decimal AccountActivity { get; set; }

        /// <summary>
        /// Gets or Sets AccountSweep
        /// </summary>
        [DataMember(Name = "accountSweep", EmitDefaultValue = false)]
        public string AccountSweep { get; set; }

        /// <summary>
        /// Gets or Sets AverageMonthlyLoanAmount
        /// </summary>
        [DataMember(Name = "averageMonthlyLoanAmount", EmitDefaultValue = false)]
        public decimal AverageMonthlyLoanAmount { get; set; }

        /// <summary>
        /// Gets or Sets AverageMonthlyLoanRepaymentAmount
        /// </summary>
        [DataMember(Name = "averageMonthlyLoanRepaymentAmount", EmitDefaultValue = false)]
        public decimal AverageMonthlyLoanRepaymentAmount { get; set; }

        /// <summary>
        /// Gets or Sets GamblingRate
        /// </summary>
        [DataMember(Name = "gamblingRate", EmitDefaultValue = false)]
        public decimal GamblingRate { get; set; }

        /// <summary>
        /// Gets or Sets GamblingStatus
        /// </summary>
        [DataMember(Name = "gamblingStatus", EmitDefaultValue = false)]
        public string GamblingStatus { get; set; }

        /// <summary>
        /// Gets or Sets LoanInflowAmount
        /// </summary>
        [DataMember(Name = "loanInflowAmount", EmitDefaultValue = true)]
        public string LoanInflowAmount { get; set; }

        /// <summary>
        /// Gets or Sets LoanRepaymentToInflowAmount
        /// </summary>
        [DataMember(Name = "loanRepaymentToInflowAmount", EmitDefaultValue = false)]
        public decimal LoanRepaymentToInflowAmount { get; set; }

        /// <summary>
        /// Gets or Sets MonthToMonthInflowToOutflowAmount
        /// </summary>
        [DataMember(Name = "monthToMonthInflowToOutflowAmount", EmitDefaultValue = false)]
        public string MonthToMonthInflowToOutflowAmount { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfCreditLoanTransactions
        /// </summary>
        [DataMember(Name = "numberOfCreditLoanTransactions", EmitDefaultValue = true)]
        public string NumberOfCreditLoanTransactions { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfDebitRepaymentTransactions
        /// </summary>
        [DataMember(Name = "numberOfDebitRepaymentTransactions", EmitDefaultValue = true)]
        public string NumberOfDebitRepaymentTransactions { get; set; }

        /// <summary>
        /// Gets or Sets OverallInflowToOutflowAmount
        /// </summary>
        [DataMember(Name = "overallInflowToOutflowAmount", EmitDefaultValue = false)]
        public string OverallInflowToOutflowAmount { get; set; }

        /// <summary>
        /// Gets or Sets PercentOfInflowIrregularity
        /// </summary>
        [DataMember(Name = "percentOfInflowIrregularity", EmitDefaultValue = false)]
        public decimal PercentOfInflowIrregularity { get; set; }

        /// <summary>
        /// Gets or Sets TotalLoanAmount
        /// </summary>
        [DataMember(Name = "totalLoanAmount", EmitDefaultValue = false)]
        public decimal TotalLoanAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalLoanRepaymentAmount
        /// </summary>
        [DataMember(Name = "totalLoanRepaymentAmount", EmitDefaultValue = false)]
        public decimal TotalLoanRepaymentAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAccountAnalysisResponseEntityFundsManagement {\n");
            sb.Append("  AccountActivity: ").Append(AccountActivity).Append("\n");
            sb.Append("  AccountSweep: ").Append(AccountSweep).Append("\n");
            sb.Append("  AverageMonthlyLoanAmount: ").Append(AverageMonthlyLoanAmount).Append("\n");
            sb.Append("  AverageMonthlyLoanRepaymentAmount: ").Append(AverageMonthlyLoanRepaymentAmount).Append("\n");
            sb.Append("  GamblingRate: ").Append(GamblingRate).Append("\n");
            sb.Append("  GamblingStatus: ").Append(GamblingStatus).Append("\n");
            sb.Append("  LoanInflowAmount: ").Append(LoanInflowAmount).Append("\n");
            sb.Append("  LoanRepaymentToInflowAmount: ").Append(LoanRepaymentToInflowAmount).Append("\n");
            sb.Append("  MonthToMonthInflowToOutflowAmount: ").Append(MonthToMonthInflowToOutflowAmount).Append("\n");
            sb.Append("  NumberOfCreditLoanTransactions: ").Append(NumberOfCreditLoanTransactions).Append("\n");
            sb.Append("  NumberOfDebitRepaymentTransactions: ").Append(NumberOfDebitRepaymentTransactions).Append("\n");
            sb.Append("  OverallInflowToOutflowAmount: ").Append(OverallInflowToOutflowAmount).Append("\n");
            sb.Append("  PercentOfInflowIrregularity: ").Append(PercentOfInflowIrregularity).Append("\n");
            sb.Append("  TotalLoanAmount: ").Append(TotalLoanAmount).Append("\n");
            sb.Append("  TotalLoanRepaymentAmount: ").Append(TotalLoanRepaymentAmount).Append("\n");
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
            return this.Equals(input as GetAccountAnalysisResponseEntityFundsManagement);
        }

        /// <summary>
        /// Returns true if GetAccountAnalysisResponseEntityFundsManagement instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAccountAnalysisResponseEntityFundsManagement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAccountAnalysisResponseEntityFundsManagement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountActivity == input.AccountActivity ||
                    this.AccountActivity.Equals(input.AccountActivity)
                ) && 
                (
                    this.AccountSweep == input.AccountSweep ||
                    (this.AccountSweep != null &&
                    this.AccountSweep.Equals(input.AccountSweep))
                ) && 
                (
                    this.AverageMonthlyLoanAmount == input.AverageMonthlyLoanAmount ||
                    this.AverageMonthlyLoanAmount.Equals(input.AverageMonthlyLoanAmount)
                ) && 
                (
                    this.AverageMonthlyLoanRepaymentAmount == input.AverageMonthlyLoanRepaymentAmount ||
                    this.AverageMonthlyLoanRepaymentAmount.Equals(input.AverageMonthlyLoanRepaymentAmount)
                ) && 
                (
                    this.GamblingRate == input.GamblingRate ||
                    this.GamblingRate.Equals(input.GamblingRate)
                ) && 
                (
                    this.GamblingStatus == input.GamblingStatus ||
                    (this.GamblingStatus != null &&
                    this.GamblingStatus.Equals(input.GamblingStatus))
                ) && 
                (
                    this.LoanInflowAmount == input.LoanInflowAmount ||
                    (this.LoanInflowAmount != null &&
                    this.LoanInflowAmount.Equals(input.LoanInflowAmount))
                ) && 
                (
                    this.LoanRepaymentToInflowAmount == input.LoanRepaymentToInflowAmount ||
                    this.LoanRepaymentToInflowAmount.Equals(input.LoanRepaymentToInflowAmount)
                ) && 
                (
                    this.MonthToMonthInflowToOutflowAmount == input.MonthToMonthInflowToOutflowAmount ||
                    (this.MonthToMonthInflowToOutflowAmount != null &&
                    this.MonthToMonthInflowToOutflowAmount.Equals(input.MonthToMonthInflowToOutflowAmount))
                ) && 
                (
                    this.NumberOfCreditLoanTransactions == input.NumberOfCreditLoanTransactions ||
                    (this.NumberOfCreditLoanTransactions != null &&
                    this.NumberOfCreditLoanTransactions.Equals(input.NumberOfCreditLoanTransactions))
                ) && 
                (
                    this.NumberOfDebitRepaymentTransactions == input.NumberOfDebitRepaymentTransactions ||
                    (this.NumberOfDebitRepaymentTransactions != null &&
                    this.NumberOfDebitRepaymentTransactions.Equals(input.NumberOfDebitRepaymentTransactions))
                ) && 
                (
                    this.OverallInflowToOutflowAmount == input.OverallInflowToOutflowAmount ||
                    (this.OverallInflowToOutflowAmount != null &&
                    this.OverallInflowToOutflowAmount.Equals(input.OverallInflowToOutflowAmount))
                ) && 
                (
                    this.PercentOfInflowIrregularity == input.PercentOfInflowIrregularity ||
                    this.PercentOfInflowIrregularity.Equals(input.PercentOfInflowIrregularity)
                ) && 
                (
                    this.TotalLoanAmount == input.TotalLoanAmount ||
                    this.TotalLoanAmount.Equals(input.TotalLoanAmount)
                ) && 
                (
                    this.TotalLoanRepaymentAmount == input.TotalLoanRepaymentAmount ||
                    this.TotalLoanRepaymentAmount.Equals(input.TotalLoanRepaymentAmount)
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
                hashCode = (hashCode * 59) + this.AccountActivity.GetHashCode();
                if (this.AccountSweep != null)
                {
                    hashCode = (hashCode * 59) + this.AccountSweep.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AverageMonthlyLoanAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.AverageMonthlyLoanRepaymentAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.GamblingRate.GetHashCode();
                if (this.GamblingStatus != null)
                {
                    hashCode = (hashCode * 59) + this.GamblingStatus.GetHashCode();
                }
                if (this.LoanInflowAmount != null)
                {
                    hashCode = (hashCode * 59) + this.LoanInflowAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LoanRepaymentToInflowAmount.GetHashCode();
                if (this.MonthToMonthInflowToOutflowAmount != null)
                {
                    hashCode = (hashCode * 59) + this.MonthToMonthInflowToOutflowAmount.GetHashCode();
                }
                if (this.NumberOfCreditLoanTransactions != null)
                {
                    hashCode = (hashCode * 59) + this.NumberOfCreditLoanTransactions.GetHashCode();
                }
                if (this.NumberOfDebitRepaymentTransactions != null)
                {
                    hashCode = (hashCode * 59) + this.NumberOfDebitRepaymentTransactions.GetHashCode();
                }
                if (this.OverallInflowToOutflowAmount != null)
                {
                    hashCode = (hashCode * 59) + this.OverallInflowToOutflowAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PercentOfInflowIrregularity.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalLoanAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalLoanRepaymentAmount.GetHashCode();
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
