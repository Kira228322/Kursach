namespace Kursach
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтрочкиСMinСтоимостьюЛеченияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияСТаблицейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОБолезниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаДанногоОтделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСтоимостьЛеченияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.DeleteUser = new System.Windows.Forms.Label();
            this.textBoxDeleteUser = new System.Windows.Forms.TextBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*.xlsx";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.менюToolStripMenuItem, this.редактированиеТаблицыToolStripMenuItem, this.действияСТаблицейToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.открытьToolStripMenuItem, this.выходИзПрограммыToolStripMenuItem });
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            this.выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            this.выходИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.выходИзПрограммыToolStripMenuItem.Text = "Выход";
            this.выходИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // редактированиеТаблицыToolStripMenuItem
            // 
            this.редактированиеТаблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.добавитьПациентаToolStripMenuItem, this.изменитьПациентаToolStripMenuItem, this.удалитьПациентаToolStripMenuItem, this.удалитьСтрочкиСMinСтоимостьюЛеченияToolStripMenuItem });
            this.редактированиеТаблицыToolStripMenuItem.Enabled = false;
            this.редактированиеТаблицыToolStripMenuItem.Name = "редактированиеТаблицыToolStripMenuItem";
            this.редактированиеТаблицыToolStripMenuItem.Size = new System.Drawing.Size(223, 27);
            this.редактированиеТаблицыToolStripMenuItem.Text = "Редактирование таблицы";
            // 
            // добавитьПациентаToolStripMenuItem
            // 
            this.добавитьПациентаToolStripMenuItem.Name = "добавитьПациентаToolStripMenuItem";
            this.добавитьПациентаToolStripMenuItem.Size = new System.Drawing.Size(351, 28);
            this.добавитьПациентаToolStripMenuItem.Text = "Добавить пациента";
            this.добавитьПациентаToolStripMenuItem.Click += new System.EventHandler(this.AddUserToolStripMenuItem_Click);
            // 
            // изменитьПациентаToolStripMenuItem
            // 
            this.изменитьПациентаToolStripMenuItem.Name = "изменитьПациентаToolStripMenuItem";
            this.изменитьПациентаToolStripMenuItem.Size = new System.Drawing.Size(351, 28);
            this.изменитьПациентаToolStripMenuItem.Text = "Изменить пациента";
            this.изменитьПациентаToolStripMenuItem.Click += new System.EventHandler(this.ChangeUserToolStripMenuItem_Click);
            // 
            // удалитьПациентаToolStripMenuItem
            // 
            this.удалитьПациентаToolStripMenuItem.Name = "удалитьПациентаToolStripMenuItem";
            this.удалитьПациентаToolStripMenuItem.Size = new System.Drawing.Size(351, 28);
            this.удалитьПациентаToolStripMenuItem.Text = "Удалить пациента";
            this.удалитьПациентаToolStripMenuItem.Click += new System.EventHandler(this.DeleteUserToolStripMenuItem_Click);
            // 
            // удалитьСтрочкиСMinСтоимостьюЛеченияToolStripMenuItem
            // 
            this.удалитьСтрочкиСMinСтоимостьюЛеченияToolStripMenuItem.Name = "удалитьСтрочкиСMinСтоимостьюЛеченияToolStripMenuItem";
            this.удалитьСтрочкиСMinСтоимостьюЛеченияToolStripMenuItem.Size = new System.Drawing.Size(351, 28);
            this.удалитьСтрочкиСMinСтоимостьюЛеченияToolStripMenuItem.Text = "Удалить строчки с min стоим. леч.";
            this.удалитьСтрочкиСMinСтоимостьюЛеченияToolStripMenuItem.Click += new System.EventHandler(this.RemoveRowsWithMinPriceToolStripMenuItem_Click);
            // 
            // действияСТаблицейToolStripMenuItem
            // 
            this.действияСТаблицейToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.информацияОБолезниToolStripMenuItem, this.таблицаДанногоОтделенияToolStripMenuItem, this.изменитьСтоимостьЛеченияToolStripMenuItem });
            this.действияСТаблицейToolStripMenuItem.Enabled = false;
            this.действияСТаблицейToolStripMenuItem.Name = "действияСТаблицейToolStripMenuItem";
            this.действияСТаблицейToolStripMenuItem.Size = new System.Drawing.Size(188, 27);
            this.действияСТаблицейToolStripMenuItem.Text = "Действия с таблицей";
            // 
            // информацияОБолезниToolStripMenuItem
            // 
            this.информацияОБолезниToolStripMenuItem.Name = "информацияОБолезниToolStripMenuItem";
            this.информацияОБолезниToolStripMenuItem.Size = new System.Drawing.Size(315, 28);
            this.информацияОБолезниToolStripMenuItem.Text = "Информация о болезни";
            this.информацияОБолезниToolStripMenuItem.Click += new System.EventHandler(this.InfoDiseaseToolStripMenuItem_Click);
            // 
            // таблицаДанногоОтделенияToolStripMenuItem
            // 
            this.таблицаДанногоОтделенияToolStripMenuItem.Name = "таблицаДанногоОтделенияToolStripMenuItem";
            this.таблицаДанногоОтделенияToolStripMenuItem.Size = new System.Drawing.Size(315, 28);
            this.таблицаДанногоОтделенияToolStripMenuItem.Text = "Таблица данного отделения";
            this.таблицаДанногоОтделенияToolStripMenuItem.Click += new System.EventHandler(this.SecondTableViewToolStripMenuItem_Click);
            // 
            // изменитьСтоимостьЛеченияToolStripMenuItem
            // 
            this.изменитьСтоимостьЛеченияToolStripMenuItem.Name = "изменитьСтоимостьЛеченияToolStripMenuItem";
            this.изменитьСтоимостьЛеченияToolStripMenuItem.Size = new System.Drawing.Size(315, 28);
            this.изменитьСтоимостьЛеченияToolStripMenuItem.Text = "Изменить стоимость лечения";
            this.изменитьСтоимостьЛеченияToolStripMenuItem.Click += new System.EventHandler(this.ChangePriceToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 375);
            this.dataGridView1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripLabel1, this.toolStripComboBox1 });
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(854, 31);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 28);
            this.toolStripLabel1.Text = "Лист";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 31);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Enabled = false;
            this.DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteUser.Location = new System.Drawing.Point(13, 459);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(273, 50);
            this.DeleteUser.TabIndex = 5;
            this.DeleteUser.Text = "Для удаления пользователя введите его ID";
            this.DeleteUser.Visible = false;
            // 
            // textBoxDeleteUser
            // 
            this.textBoxDeleteUser.Enabled = false;
            this.textBoxDeleteUser.Location = new System.Drawing.Point(290, 469);
            this.textBoxDeleteUser.Name = "textBoxDeleteUser";
            this.textBoxDeleteUser.Size = new System.Drawing.Size(187, 22);
            this.textBoxDeleteUser.TabIndex = 6;
            this.textBoxDeleteUser.Visible = false;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Enabled = false;
            this.buttonDeleteUser.Location = new System.Drawing.Point(483, 464);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(143, 32);
            this.buttonDeleteUser.TabIndex = 7;
            this.buttonDeleteUser.Text = "УДАЛИТЬ";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Visible = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(854, 518);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.textBoxDeleteUser);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Работа с пациентами";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem удалитьСтрочкиСMinСтоимостьюЛеченияToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem изменитьПациентаToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem изменитьСтоимостьЛеченияToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem таблицаДанногоОтделенияToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem информацияОБолезниToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem действияСТаблицейToolStripMenuItem;

        private System.Windows.Forms.Button buttonDeleteUser;

        private System.Windows.Forms.Label DeleteUser;
        private System.Windows.Forms.TextBox textBoxDeleteUser;

        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem редактированиеТаблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПациентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПациентаToolStripMenuItem;

        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;

        #endregion
    }
}