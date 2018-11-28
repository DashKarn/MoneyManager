/// -------------------------------------------------------------
/// <copyright file="Form1.Designer.cs" company="DSH">
/// copyright (c) Dasha Karnaukh
/// All right are reserved.
/// </copyright>
/// -------------------------------------------------------------
namespace CSLesson6
{
    /// <summary>
    /// Initialize the program window.
    /// </summary>
    public partial class Form1
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxAmmount = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewEntries = new System.Windows.Forms.DataGridView();
            this.GraphButton = new System.Windows.Forms.Button();
            this.ImportanceBox = new System.Windows.Forms.ComboBox();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImportance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAmmount
            // 
            this.textBoxAmmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAmmount.Location = new System.Drawing.Point(76, 6);
            this.textBoxAmmount.Name = "textBoxAmmount";
            this.textBoxAmmount.Size = new System.Drawing.Size(502, 20);
            this.textBoxAmmount.TabIndex = 0;
            this.textBoxAmmount.TextChanged += new System.EventHandler(this.textBoxAmmount_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(470, 114);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(12, 13);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(47, 13);
            this.labelSum.TabIndex = 2;
            this.labelSum.Text = "Сумма :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Баланс:";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBalance.Location = new System.Drawing.Point(67, 319);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(374, 20);
            this.textBoxBalance.TabIndex = 6;
            this.textBoxBalance.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(76, 32);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(502, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Важность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Категория:";
            // 
            // dataGridViewEntries
            // 
            this.dataGridViewEntries.AllowUserToAddRows = false;
            this.dataGridViewEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnType,
            this.ColumnAmmount,
            this.ColumnDate,
            this.ColumnImportance,
            this.ColumnCategory});
            this.dataGridViewEntries.Location = new System.Drawing.Point(15, 153);
            this.dataGridViewEntries.Name = "dataGridViewEntries";
            this.dataGridViewEntries.Size = new System.Drawing.Size(563, 151);
            this.dataGridViewEntries.TabIndex = 5;
            this.dataGridViewEntries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntries_CellContentClick);
            // 
            // GraphButton
            // 
            this.GraphButton.Location = new System.Drawing.Point(470, 316);
            this.GraphButton.Name = "GraphButton";
            this.GraphButton.Size = new System.Drawing.Size(108, 23);
            this.GraphButton.TabIndex = 11;
            this.GraphButton.Text = "График";
            this.GraphButton.UseVisualStyleBackColor = true;
            this.GraphButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImportanceBox
            // 
            this.ImportanceBox.FormattingEnabled = true;
            this.ImportanceBox.Items.AddRange(new object[] {
            "Очень",
            "Средне",
            "Нет"});
            this.ImportanceBox.Location = new System.Drawing.Point(76, 61);
            this.ImportanceBox.Name = "ImportanceBox";
            this.ImportanceBox.Size = new System.Drawing.Size(502, 21);
            this.ImportanceBox.TabIndex = 12;
            this.ImportanceBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Items.AddRange(new object[] {
            "Еда",
            "Одежда",
            "Транспорт",
            "Жильё",
            "Развлечения",
            "Другое"});
            this.CategoryBox.Location = new System.Drawing.Point(76, 88);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(502, 21);
            this.CategoryBox.TabIndex = 12;
            this.CategoryBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Тип записи";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnAmmount
            // 
            this.ColumnAmmount.HeaderText = "Сумма";
            this.ColumnAmmount.Name = "ColumnAmmount";
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.Name = "ColumnDate";
            // 
            // ColumnImportance
            // 
            this.ColumnImportance.HeaderText = "Важность";
            this.ColumnImportance.Name = "ColumnImportance";
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.HeaderText = "Категория";
            this.ColumnCategory.Name = "ColumnCategory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 351);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.ImportanceBox);
            this.Controls.Add(this.GraphButton);
            this.Controls.Add(this.dataGridViewEntries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAmmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Money Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAmmount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewEntries;
        private System.Windows.Forms.Button GraphButton;
        private System.Windows.Forms.ComboBox ImportanceBox;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImportance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
    }
}