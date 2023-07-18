using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp.RevisoItems
{

    /// <summary>
    /// 
    /// </summary>
    public enum EnumAccountType
    {
        heading,
        headingStart,
        profitAndLoss,
        totalFrom,
        status,
        sumInterval,
        sumAlpha
    }



    /// <summary>
    /// 
    /// </summary>
    public enum EnumDebitCredit
    {
        debit,
        credit
    }



    /// <summary>
    /// 
    /// </summary>
    public class AccountCollection : RevisoBaseCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<Account> Collection { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Account : RevisoBaseObject
    {
        /// <summary>
        /// The category of the account.
        /// </summary>
        [JsonPropertyName("")]
        public AccountCategory AccountCategory { get; set; }

        /// <summary>
        /// A link to a list of accounting years for which the account is usable.
        /// </summary>
        [JsonPropertyName("accountingYears")]
        public Uri AccountingYears { get; set; }

        /// <summary>
        /// The type of account in the chart of accounts.
        /// </summary>
        [JsonPropertyName("accountType")]
        public string AccountType { get; set; }

        /// <summary>
        /// The current balance of the account.
        /// </summary>
        [JsonPropertyName("balance")]
        public decimal? Balance { get; set; }

        /// <summary>
        /// Shows if the account is barred from being used.
        /// </summary>
        [JsonPropertyName("barred")]
        public bool? Barred { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("blockDirectEntries")]
        public bool? BlockDirectEntries { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("contraAccount")]
        //public Account ContraAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("debitCredit")]
        // TODO ---
        public string DebitCredit { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("department")]
        //public Department Department { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("departmentalDistribution")]
        //// TODO ---
        //public Department DepartmentalDistribution { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("displayNumber")]
        //public string DisplayNumber { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("openingAccount")]
        //public Account OpeningAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("requireDepartmentalDistributionOnEntries")]
        public bool? RequireDepartmentalDistributionOnEntries { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("totalFromAccount")]
        //public Account TotalFromAccount { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonPropertyName("vatAccount")]
        //public Account VatAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("accountNumber")]
        public int? AccountNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

    }

}
