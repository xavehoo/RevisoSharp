using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RevisoSharp
{

    public enum EnumAccountType
    {
        status
    }

    public enum EnumDebitCredit {
        debit,
        credit
    }

    public class AccountCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("collection")]
        public List<Account> Collection { get; set; }
    }
    public class Account
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
        public List<AccountingYear> AccountingYears { get; set; }

        /// <summary>
        /// The type of account in the chart of accounts.
        /// </summary>
        [JsonPropertyName("accountType")]
        public EnumAccountType AccountType { get; set; }

        /// <summary>
        /// Used to bar the account from being used - default is false.
        /// </summary>
        [JsonPropertyName("balance")]
        public int Balance { get; set; }

        /// <summary>
        /// Determines if the account can be manually updated with entries.
        /// </summary>
        [JsonPropertyName("barred")]
        public bool Barred { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("blockDirectEntries")]
        public bool BlockDirectEntries { get; set; }

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
        public EnumDebitCredit DebitCredit { get; set; }

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
        public bool RequireDepartmentalDistributionOnEntries { get; set; }

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
        public int AccountNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

    }
}
