using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kursach
{
    public class ExitWindow: Form
    {
        public bool exit;
        public ExitWindow()
        {
            exit = false;
            InitializeComponent();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы уверены что хотите завершить работу программы";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Нет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Да";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExitWindow
            // 
            this.ClientSize = new System.Drawing.Size(275, 236);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ExitWindow";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label1;

        private void button1_Click(object sender, EventArgs e)
        {
            exit = false;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exit = true;
            Close();
        }
    }
}