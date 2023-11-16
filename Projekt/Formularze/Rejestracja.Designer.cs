namespace Projekt
{
    partial class Rejestracja
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPowrot = new FontAwesome.Sharp.IconButton();
            this.btnUtwoz = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbValidation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRodzaj = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPowtorzHaslo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnPowrot);
            this.panel1.Location = new System.Drawing.Point(-104, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 214);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(303, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 48);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rejestracja";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = global::Projekt.Properties.Resources.OIG_wQoiCHCAr;
            this.pictureBox2.Image = global::Projekt.Properties.Resources.OIG_wQoiCHCAr;
            this.pictureBox2.Location = new System.Drawing.Point(325, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnPowrot
            // 
            this.btnPowrot.FlatAppearance.BorderSize = 0;
            this.btnPowrot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowrot.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnPowrot.IconColor = System.Drawing.Color.Black;
            this.btnPowrot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPowrot.Location = new System.Drawing.Point(105, 2);
            this.btnPowrot.Margin = new System.Windows.Forms.Padding(4);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(75, 59);
            this.btnPowrot.TabIndex = 11;
            this.btnPowrot.UseVisualStyleBackColor = true;
            this.btnPowrot.Click += new System.EventHandler(this.btnPowrot_Click);
            // 
            // btnUtwoz
            // 
            this.btnUtwoz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnUtwoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(227)))));
            this.btnUtwoz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUtwoz.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUtwoz.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUtwoz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUtwoz.Location = new System.Drawing.Point(225, 470);
            this.btnUtwoz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUtwoz.Name = "btnUtwoz";
            this.btnUtwoz.Size = new System.Drawing.Size(369, 49);
            this.btnUtwoz.TabIndex = 0;
            this.btnUtwoz.Text = "Utwórz konto";
            this.btnUtwoz.UseVisualStyleBackColor = false;
            this.btnUtwoz.Click += new System.EventHandler(this.btnUtwoz_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbLogin.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.Location = new System.Drawing.Point(225, 44);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(367, 35);
            this.tbLogin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(235, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login:";
            // 
            // lbValidation
            // 
            this.lbValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbValidation.AutoSize = true;
            this.lbValidation.Font = new System.Drawing.Font("Lato", 9F);
            this.lbValidation.ForeColor = System.Drawing.Color.Red;
            this.lbValidation.Location = new System.Drawing.Point(323, 329);
            this.lbValidation.Name = "lbValidation";
            this.lbValidation.Size = new System.Drawing.Size(163, 18);
            this.lbValidation.TabIndex = 8;
            this.lbValidation.Text = "Hasła nie są takie same";
            this.lbValidation.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(235, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasło: ";
            // 
            // tbHaslo
            // 
            this.tbHaslo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbHaslo.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHaslo.Location = new System.Drawing.Point(225, 206);
            this.tbHaslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '·';
            this.tbHaslo.Size = new System.Drawing.Size(368, 35);
            this.tbHaslo.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbRodzaj);
            this.panel2.Controls.Add(this.lbEmail);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbLogin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbValidation);
            this.panel2.Controls.Add(this.btnUtwoz);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbPowtorzHaslo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbHaslo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbEmail);
            this.panel2.Location = new System.Drawing.Point(-104, 210);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 570);
            this.panel2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(233, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rodzaj konta:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbRodzaj
            // 
            this.cbRodzaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRodzaj.Font = new System.Drawing.Font("Lato", 13.8F);
            this.cbRodzaj.FormattingEnabled = true;
            this.cbRodzaj.Items.AddRange(new object[] {
            "Użytkownik",
            "Przewoźnik"});
            this.cbRodzaj.Location = new System.Drawing.Point(227, 384);
            this.cbRodzaj.Margin = new System.Windows.Forms.Padding(4);
            this.cbRodzaj.Name = "cbRodzaj";
            this.cbRodzaj.Size = new System.Drawing.Size(367, 36);
            this.cbRodzaj.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 9F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(331, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nazwa jest już zajęta";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(235, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Powtórz hasło: ";
            // 
            // tbPowtorzHaslo
            // 
            this.tbPowtorzHaslo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbPowtorzHaslo.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPowtorzHaslo.Location = new System.Drawing.Point(225, 289);
            this.tbPowtorzHaslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPowtorzHaslo.Name = "tbPowtorzHaslo";
            this.tbPowtorzHaslo.PasswordChar = '·';
            this.tbPowtorzHaslo.Size = new System.Drawing.Size(368, 35);
            this.tbPowtorzHaslo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(233, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "E-mail:";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbEmail.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail.Location = new System.Drawing.Point(224, 124);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(368, 35);
            this.tbEmail.TabIndex = 10;
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Lato", 9F);
            this.lbEmail.ForeColor = System.Drawing.Color.Red;
            this.lbEmail.Location = new System.Drawing.Point(331, 161);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(141, 18);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "E-mail nie poprawny";
            this.lbEmail.Visible = false;
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 780);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rejestracja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUtwoz;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbValidation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnPowrot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPowtorzHaslo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbRodzaj;
        private System.Windows.Forms.Label lbEmail;
    }
}