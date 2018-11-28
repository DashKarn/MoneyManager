/// -------------------------------------------------------------
/// <copyright file="MoneyEntry.cs" company="DSH">
/// copyright (c) Dasha Karnaukh
/// All right are reserved.
/// </copyright>
/// -------------------------------------------------------------
namespace CSMoney
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class contains info about transaction.
    /// </summary>
    public class MoneyEntry
    {
        /// <summary>
        /// Amount of income and expenses
        /// </summary>
        private double ammount;

        /// <summary>
        /// Gets or sets a value indicating the amount of transaction
        /// </summary>
        public double Ammount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the date of transaction
        /// </summary>
        public DateTime EntryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the importance of transaction
        /// </summary>
        public string Importance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the category of transaction
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the type of the transaction
        /// </summary>
        public bool IsDebit
        {
            get => this.ammount >= 0;
            set
            {
                if (value && this.ammount < 0)
                {
                    this.ammount = -this.ammount;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyEntry"/> class
        /// </summary>
        public MoneyEntry()
        {
            this.ammount = 0;
            this.EntryDate = DateTime.Now;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyEntry"/> class
        /// </summary>
        /// <param name="ammount"> Amount of transaction</param>
        /// <param name="date"> Date of transaction </param>
        public MoneyEntry(double ammount, DateTime date)
        {
            this.ammount = ammount;
            this.EntryDate = date;
        }

        /// <summary>
        /// Initialization transaction date
        /// </summary>
        /// <param name="ammount"> Amount of transaction</param>
        /// <param name="date"> Date of transaction </param>
        public void InitWithString(string ammount, string date)
        {
            double.TryParse(ammount, out this.ammount);

            DateTime dt;
            DateTime.TryParse(date, out dt);
            this.EntryDate = dt;
        }

        /// <summary>
        /// Format date to string
        /// </summary>
        /// <returns>The string.</returns>
        public override string ToString()
        {
            return string.Format("{0} to {1}", this.ammount, this.EntryDate.Date);
        }
    }
}
