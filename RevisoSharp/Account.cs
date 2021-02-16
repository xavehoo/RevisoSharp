using System;
using System.Collections.Generic;
using System.Text;

namespace RevisoSharp
{
    class Account
    {
        /// <summary>
        /// The category of the account.
        /// </summary>
        public AccountCategory AccountCategory { get; set; }

        /// <summary>
        /// A link to a list of accounting years for which the account is usable.
        /// </summary>
        public AccountingYear AccountingYears { get; set; }

        /// <summary>
        /// The type of account in the chart of accounts.
        /// </summary>
        public EnumAccountType AccountType { get; set; }

        /// <summary>
        /// Used to bar the account from being used - default is false.
        /// </summary>
        public int Balance { get; set; }

        /// <summary>
        /// Determines if the account can be manually updated with entries.
        /// </summary>
        public bool Barred { get; set; }

        public bool BlockDirectEntries { get; set; }

        public Account ContraAccount { get; set; }

        // TODO ---
        public EnumDebitCredit DebitCredit { get; set; }

        public Department Department { get; set; }
        // TODO ---
        public Department DepartmentalDistribution { get; set; }

        public string DisplayNumber { get; set; }

        public Account OpeningAccount { get; set; }

        public bool RequireDepartmentalDistributionOnEntries { get; set; }

        public Account TotalFromAccount { get; set; }

        public Account VatAccount { get; set; }

        public int AccountNumber { get; set; }
        public string Name { get; set }

    }
}
