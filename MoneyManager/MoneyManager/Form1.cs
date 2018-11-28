/// -------------------------------------------------------------
/// <copyright file="Form1.cs" company="DSH">
/// copyright (c) Dasha Karnaukh
/// All right are reserved.
/// </copyright>
/// -------------------------------------------------------------
namespace CSLesson6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using CSMoney;

    /// <summary>
    /// Class contains form events.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Amount money on account
        /// </summary>
        private double balance;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();

            this.balance = 0;
        }

        /// <summary>
        /// Adding a new transaction
        /// </summary>
        /// <param name="sender"> Object sender </param>
        /// <param name="e"> Button event </param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MoneyEntry me = new MoneyEntry();

            double income;
            double.TryParse(textBoxAmmount.Text, out income);

            me.Ammount = income;
            me.EntryDate = dtpDate.Value;
            me.Importance = (string)ImportanceBox.SelectedItem;
            me.Category = (string)CategoryBox.SelectedItem;

            this.AddEntry(me);
            this.UpdateBalance();
            this.ClearFields();
        }

        /// <summary>
        /// Updating balance
        /// </summary>
        private void UpdateBalance()
        {
            double balance = 0;

            foreach (DataGridViewRow row in dataGridViewEntries.Rows)
            {
                double income;
                double.TryParse((row.Cells[1].Value ?? "0").ToString(), out income);

                balance += income;
            }

            textBoxBalance.Text = balance.ToString();
        }

        /// <summary>
        /// Adding a new transaction
        /// </summary>
        /// <param name="me"> Adding class </param>
        private void AddEntry(MoneyEntry me)
        {
            dataGridViewEntries.Rows.Add(
                me.IsDebit ? "Income" : "Outcome",
                me.Ammount,
                me.EntryDate.ToShortDateString(),
                me.Importance,
                me.Category);
        }

        /// <summary>
        /// Clear all fields on form
        /// </summary>
        private void ClearFields()
        {
            textBoxAmmount.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
        }

        /// <summary>
        /// Update balance after changing table
        /// </summary>
        /// <param name="sender"> Object sender </param>
        /// /// <param name="e"> Table event </param>
        private void dataGridViewEntries_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridViewEntries.Rows.Count > 0)
            {
                double income;
                double.TryParse((dataGridViewEntries[e.ColumnIndex, e.RowIndex].Value ?? "0").ToString(), out income);

                dataGridViewEntries[0, e.RowIndex].Value = (income > 0) ? "Income" : "Outcome";

                this.UpdateBalance();
            }
        }

        /// <summary>
        /// Show welcome message 
        /// </summary>
        /// <param name="sender"> Object sender </param>
        /// /// <param name="e"> Form1 event </param>
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! Have a look at your finances.");
        }

        /// <summary>
        /// Show balance message 
        /// </summary>
        /// <param name="sender"> Object sender </param>
        /// /// <param name="e"> Form1 event </param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(string.Format("Your Balance is {0}", textBoxBalance.Text));
        }

        /// <summary>
        /// Form event
        /// </summary>
        /// <param name="sender"> Object sender </param>
        /// /// <param name="e"> Form1 event </param>
        private void textBoxAmmount_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Form event
        /// </summary>
        /// <param name="sender"> Object sender </param>
        /// /// <param name="e"> Form1 event </param>
        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Form event
        /// </summary>
        /// <param name="sender"> Object sender </param>
        /// /// <param name="e"> Form1 event </param>
        private void button1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Form event
        /// </summary>
        /// <param name="sender"> Object sender </param>
        /// /// <param name="e"> Form1 event </param>
        private void dataGridViewEntries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// Form event
        /// </summary>
        /// <param name="sender"> Object sender </param>
        /// /// <param name="e"> Form1 event </param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Form event
        /// </summary>
        /// <param name="sender"> Object sender </param>
        /// /// <param name="e"> Form1 event </param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
