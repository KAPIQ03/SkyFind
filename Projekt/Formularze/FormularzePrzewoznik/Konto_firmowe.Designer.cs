namespace Dashboard_Firmy.Formularze
{
    partial class Konto_firmowe
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
            this.ZapiszDane = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hasloTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NazwaPTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ZapiszDane
            // 
            this.ZapiszDane.Location = new System.Drawing.Point(396, 207);
            this.ZapiszDane.Margin = new System.Windows.Forms.Padding(2);
            this.ZapiszDane.Name = "ZapiszDane";
            this.ZapiszDane.Size = new System.Drawing.Size(84, 27);
            this.ZapiszDane.TabIndex = 14;
            this.ZapiszDane.Text = "zapisz dane";
            this.ZapiszDane.UseVisualStyleBackColor = true;
            this.ZapiszDane.Click += new System.EventHandler(this.ZapiszDane_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "hasło:";
            // 
            // hasloTextBox
            // 
            this.hasloTextBox.Location = new System.Drawing.Point(285, 174);
            this.hasloTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.hasloTextBox.Name = "hasloTextBox";
            this.hasloTextBox.Size = new System.Drawing.Size(197, 20);
            this.hasloTextBox.TabIndex = 12;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(285, 142);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(197, 20);
            this.loginTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "login:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(285, 112);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(197, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "e-mail:";
            // 
            // NazwaPTextBox
            // 
            this.NazwaPTextBox.Location = new System.Drawing.Point(285, 82);
            this.NazwaPTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NazwaPTextBox.Name = "NazwaPTextBox";
            this.NazwaPTextBox.Size = new System.Drawing.Size(197, 20);
            this.NazwaPTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "nazwa przewoźnika:";
            // 
            // Konto_firmowe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 442);
            this.Controls.Add(this.NazwaPTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ZapiszDane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hasloTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Konto_firmowe";
            this.Text = "Konto firmowe";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ZapiszDane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hasloTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NazwaPTextBox;
        private System.Windows.Forms.Label label4;
    }
}