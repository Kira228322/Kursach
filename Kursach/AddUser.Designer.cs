using System.ComponentModel;

namespace Kursach
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.UserSurname = new System.Windows.Forms.Label();
            this.UserSecondName = new System.Windows.Forms.Label();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.NumberOfSector = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.PricePerDay = new System.Windows.Forms.Label();
            this.Expenses = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxExpenses = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxDisease = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление нового пациента";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(12, 79);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(125, 40);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Фамилия";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserSurname
            // 
            this.UserSurname.Location = new System.Drawing.Point(12, 129);
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.Size = new System.Drawing.Size(86, 40);
            this.UserSurname.TabIndex = 2;
            this.UserSurname.Text = "Имя";
            this.UserSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserSecondName
            // 
            this.UserSecondName.Location = new System.Drawing.Point(12, 179);
            this.UserSecondName.Name = "UserSecondName";
            this.UserSecondName.Size = new System.Drawing.Size(125, 40);
            this.UserSecondName.TabIndex = 3;
            this.UserSecondName.Text = "Отчество";
            this.UserSecondName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(152, 88);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(151, 22);
            this.textBoxSurName.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(152, 138);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(152, 188);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(151, 22);
            this.textBoxSecondName.TabIndex = 6;
            // 
            // comboBoxNumber
            // 
            this.comboBoxNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            this.comboBoxNumber.Location = new System.Drawing.Point(152, 231);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(151, 24);
            this.comboBoxNumber.TabIndex = 7;
            this.comboBoxNumber.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // NumberOfSector
            // 
            this.NumberOfSector.Location = new System.Drawing.Point(12, 229);
            this.NumberOfSector.Name = "NumberOfSector";
            this.NumberOfSector.Size = new System.Drawing.Size(134, 26);
            this.NumberOfSector.TabIndex = 8;
            this.NumberOfSector.Text = "Номер отделения";
            this.NumberOfSector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(390, 129);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(175, 26);
            this.Duration.TabIndex = 9;
            this.Duration.Text = "Длительность лечения";
            this.Duration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PricePerDay
            // 
            this.PricePerDay.Location = new System.Drawing.Point(390, 179);
            this.PricePerDay.Name = "PricePerDay";
            this.PricePerDay.Size = new System.Drawing.Size(175, 26);
            this.PricePerDay.TabIndex = 10;
            this.PricePerDay.Text = "Цена одного дня лечения";
            this.PricePerDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Expenses
            // 
            this.Expenses.Location = new System.Drawing.Point(390, 229);
            this.Expenses.Name = "Expenses";
            this.Expenses.Size = new System.Drawing.Size(175, 26);
            this.Expenses.TabIndex = 11;
            this.Expenses.Text = "Расходы на лекарства";
            this.Expenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(571, 131);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(155, 22);
            this.textBoxDuration.TabIndex = 12;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(571, 179);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(155, 22);
            this.textBoxPrice.TabIndex = 13;
            // 
            // textBoxExpenses
            // 
            this.textBoxExpenses.Location = new System.Drawing.Point(571, 229);
            this.textBoxExpenses.Name = "textBoxExpenses";
            this.textBoxExpenses.Size = new System.Drawing.Size(155, 22);
            this.textBoxExpenses.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(583, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить пациента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxDisease
            // 
            this.TextBoxDisease.Location = new System.Drawing.Point(571, 85);
            this.TextBoxDisease.Name = "TextBoxDisease";
            this.TextBoxDisease.Size = new System.Drawing.Size(154, 22);
            this.TextBoxDisease.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(390, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Болезнь";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelID
            // 
            this.labelID.Enabled = false;
            this.labelID.Location = new System.Drawing.Point(380, 14);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(46, 24);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "ID";
            this.labelID.Visible = false;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(421, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(86, 22);
            this.textBoxID.TabIndex = 20;
            this.textBoxID.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(513, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 27);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Visible = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 431);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxDisease);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxExpenses);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.Expenses);
            this.Controls.Add(this.PricePerDay);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.NumberOfSector);
            this.Controls.Add(this.comboBoxNumber);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurName);
            this.Controls.Add(this.UserSecondName);
            this.Controls.Add(this.UserSurname);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUser_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.Label labelID;

        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.Button buttonSearch;

        private System.Windows.Forms.TextBox TextBoxDisease;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label NumberOfSector;

        private System.Windows.Forms.Label PricePerDay;

        public System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxExpenses;
        private System.Windows.Forms.ComboBox comboBoxNumber;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Expenses;

        private System.Windows.Forms.Label Duration;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.TextBox textBoxSecondName;

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserSurname;
        private System.Windows.Forms.Label UserSecondName;

        public System.Windows.Forms.Label label1;

        #endregion
    }
}