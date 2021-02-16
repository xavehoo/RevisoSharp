using System;

namespace RevisoSharp
{
    public class AccountingYear
    {
        /// <summary>
        /// Determines if the accounting year is closed for further transactions.
        /// </summary>
        public bool Closed { get; set; }

        /// <summary>
        /// A link to a collection of all entries booked in the accounting year.
        /// </summary>
        public string Entries { get; set; }

        // ! Required
        // ! Format: full-date (yyyy-MM-dd)
        /// <summary>
        /// The first date in the accounting year in the format YYYY-MM-DD. 
        /// Except for the first accounting year on an agreement, it must be the date immediately following the previous accounting year, and thus must be the first day of a month. 
        /// The first accounting year on an agreement can begin on any day of the month.
        /// </summary>
        public string FromDate { get; set; }

        /// <summary>
        /// A link to the collection of accounting year periods on an agreement.
        /// </summary>
        public string Periods { get; set; }

        // ! Required
        // ! Format: full-date (yyyy-MM-dd)
        /// <summary>
        /// The last date in the accounting year in the format YYYY-MM-DD. 
        /// It must be the last date in the last month of the accounting year. An accounting year can at most have a duration of 18 months.
        /// </summary>
        public string ToDate { get; set; }

        /// <summary>
        /// A link to the chart of accounts with the years total in base currency.
        /// </summary>
        public string Totals { get; set; }

        /// <summary>
        /// A link to a collection of vouchers created in the accounting year.
        /// </summary>
        public string Vouchers { get; set; }

        /// <summary>
        /// The calendar year or years spanned by the accounting year in the format YYYY or YYYY/YYYY.
        /// </summary>
        public string Year { get; set; }

    }
}
