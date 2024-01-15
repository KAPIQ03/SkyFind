using System.Drawing;

namespace Projekt.Formularze
{
    partial class DashboardUzytkownik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUzytkownik));
            this.WyszukajL = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTytul = new System.Windows.Forms.Panel();
            this.panelborderlm = new System.Windows.Forms.Panel();
            this.panelWybraneTytul = new System.Windows.Forms.Label();
            this.iconWybrany = new FontAwesome.Sharp.IconPictureBox();
            this.panelborderg = new System.Windows.Forms.Panel();
            this.panelborderld = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Wyloguj = new FontAwesome.Sharp.IconButton();
            this.MojeB = new FontAwesome.Sharp.IconButton();
            this.DaneK = new FontAwesome.Sharp.IconButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTytul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconWybrany)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // WyszukajL
            // 
            this.WyszukajL.BackColor = System.Drawing.Color.White;
            this.WyszukajL.Dock = System.Windows.Forms.DockStyle.Top;
            this.WyszukajL.FlatAppearance.BorderSize = 0;
            this.WyszukajL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WyszukajL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WyszukajL.ForeColor = System.Drawing.Color.Black;
            this.WyszukajL.IconChar = FontAwesome.Sharp.IconChar.PlaneUp;
            this.WyszukajL.IconColor = System.Drawing.Color.Orange;
            this.WyszukajL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.WyszukajL.IconSize = 32;
            this.WyszukajL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WyszukajL.Location = new System.Drawing.Point(0, 172);
            this.WyszukajL.Margin = new System.Windows.Forms.Padding(4);
            this.WyszukajL.Name = "WyszukajL";
            this.WyszukajL.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.WyszukajL.Size = new System.Drawing.Size(293, 74);
            this.WyszukajL.TabIndex = 1;
            this.WyszukajL.Text = "Pokaż loty";
            this.WyszukajL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WyszukajL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WyszukajL.UseVisualStyleBackColor = false;
            this.WyszukajL.Click += new System.EventHandler(this.WyszukajL_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 172);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(293, 172);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelTytul
            // 
            this.panelTytul.BackColor = System.Drawing.Color.White;
            this.panelTytul.Controls.Add(this.panelborderlm);
            this.panelTytul.Controls.Add(this.panelWybraneTytul);
            this.panelTytul.Controls.Add(this.iconWybrany);
            this.panelTytul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTytul.Location = new System.Drawing.Point(296, 2);
            this.panelTytul.Margin = new System.Windows.Forms.Padding(4);
            this.panelTytul.Name = "panelTytul";
            this.panelTytul.Size = new System.Drawing.Size(987, 98);
            this.panelTytul.TabIndex = 6;
            // 
            // panelborderlm
            // 
            this.panelborderlm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelborderlm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelborderlm.Location = new System.Drawing.Point(0, 0);
            this.panelborderlm.Margin = new System.Windows.Forms.Padding(4);
            this.panelborderlm.Name = "panelborderlm";
            this.panelborderlm.Size = new System.Drawing.Size(3, 98);
            this.panelborderlm.TabIndex = 0;
            // 
            // panelWybraneTytul
            // 
            this.panelWybraneTytul.AutoSize = true;
            this.panelWybraneTytul.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelWybraneTytul.ForeColor = System.Drawing.Color.DimGray;
            this.panelWybraneTytul.Location = new System.Drawing.Point(83, 36);
            this.panelWybraneTytul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelWybraneTytul.Name = "panelWybraneTytul";
            this.panelWybraneTytul.Size = new System.Drawing.Size(65, 24);
            this.panelWybraneTytul.TabIndex = 1;
            this.panelWybraneTytul.Text = "Home";
            // 
            // iconWybrany
            // 
            this.iconWybrany.BackColor = System.Drawing.Color.Transparent;
            this.iconWybrany.ForeColor = System.Drawing.Color.Orange;
            this.iconWybrany.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconWybrany.IconColor = System.Drawing.Color.Orange;
            this.iconWybrany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconWybrany.IconSize = 39;
            this.iconWybrany.Location = new System.Drawing.Point(32, 29);
            this.iconWybrany.Margin = new System.Windows.Forms.Padding(4);
            this.iconWybrany.Name = "iconWybrany";
            this.iconWybrany.Size = new System.Drawing.Size(43, 39);
            this.iconWybrany.TabIndex = 0;
            this.iconWybrany.TabStop = false;
            // 
            // panelborderg
            // 
            this.panelborderg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelborderg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelborderg.Location = new System.Drawing.Point(296, 0);
            this.panelborderg.Margin = new System.Windows.Forms.Padding(4);
            this.panelborderg.Name = "panelborderg";
            this.panelborderg.Size = new System.Drawing.Size(987, 2);
            this.panelborderg.TabIndex = 9;
            // 
            // panelborderld
            // 
            this.panelborderld.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelborderld.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelborderld.Location = new System.Drawing.Point(293, 0);
            this.panelborderld.Margin = new System.Windows.Forms.Padding(4);
            this.panelborderld.Name = "panelborderld";
            this.panelborderld.Size = new System.Drawing.Size(3, 675);
            this.panelborderld.TabIndex = 8;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.Wyloguj);
            this.panelMenu.Controls.Add(this.MojeB);
            this.panelMenu.Controls.Add(this.DaneK);
            this.panelMenu.Controls.Add(this.WyszukajL);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 675);
            this.panelMenu.TabIndex = 5;
            // 
            // Wyloguj
            // 
            this.Wyloguj.BackColor = System.Drawing.Color.White;
            this.Wyloguj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Wyloguj.FlatAppearance.BorderSize = 0;
            this.Wyloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wyloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyloguj.ForeColor = System.Drawing.Color.Black;
            this.Wyloguj.IconChar = FontAwesome.Sharp.IconChar.PlaneUp;
            this.Wyloguj.IconColor = System.Drawing.Color.Orange;
            this.Wyloguj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Wyloguj.IconSize = 32;
            this.Wyloguj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wyloguj.Location = new System.Drawing.Point(0, 601);
            this.Wyloguj.Margin = new System.Windows.Forms.Padding(4);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Wyloguj.Size = new System.Drawing.Size(293, 74);
            this.Wyloguj.TabIndex = 5;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wyloguj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Wyloguj.UseVisualStyleBackColor = false;
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click);
            // 
            // MojeB
            // 
            this.MojeB.BackColor = System.Drawing.Color.White;
            this.MojeB.Dock = System.Windows.Forms.DockStyle.Top;
            this.MojeB.FlatAppearance.BorderSize = 0;
            this.MojeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MojeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MojeB.ForeColor = System.Drawing.Color.Black;
            this.MojeB.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.MojeB.IconColor = System.Drawing.Color.Orange;
            this.MojeB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MojeB.IconSize = 32;
            this.MojeB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MojeB.Location = new System.Drawing.Point(0, 320);
            this.MojeB.Margin = new System.Windows.Forms.Padding(4);
            this.MojeB.Name = "MojeB";
            this.MojeB.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.MojeB.Size = new System.Drawing.Size(293, 74);
            this.MojeB.TabIndex = 3;
            this.MojeB.Text = "Moje bilety";
            this.MojeB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MojeB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MojeB.UseVisualStyleBackColor = false;
            this.MojeB.Click += new System.EventHandler(this.MojeB_Click);
            // 
            // DaneK
            // 
            this.DaneK.BackColor = System.Drawing.Color.White;
            this.DaneK.Dock = System.Windows.Forms.DockStyle.Top;
            this.DaneK.FlatAppearance.BorderSize = 0;
            this.DaneK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DaneK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DaneK.ForeColor = System.Drawing.Color.Black;
            this.DaneK.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.DaneK.IconColor = System.Drawing.Color.Orange;
            this.DaneK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DaneK.IconSize = 32;
            this.DaneK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DaneK.Location = new System.Drawing.Point(0, 246);
            this.DaneK.Margin = new System.Windows.Forms.Padding(4);
            this.DaneK.Name = "DaneK";
            this.DaneK.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.DaneK.Size = new System.Drawing.Size(293, 74);
            this.DaneK.TabIndex = 2;
            this.DaneK.Text = "Dane konta";
            this.DaneK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DaneK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DaneK.UseVisualStyleBackColor = false;
            this.DaneK.Click += new System.EventHandler(this.DaneK_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(296, 100);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(987, 575);
            this.panelMain.TabIndex = 7;
            // 
            // DashboardUzytkownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTytul);
            this.Controls.Add(this.panelborderg);
            this.Controls.Add(this.panelborderld);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashboardUzytkownik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uzytkownik";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTytul.ResumeLayout(false);
            this.panelTytul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconWybrany)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton WyszukajL;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelTytul;
        private System.Windows.Forms.Panel panelborderlm;
        private System.Windows.Forms.Label panelWybraneTytul;
        private FontAwesome.Sharp.IconPictureBox iconWybrany;
        private System.Windows.Forms.Panel panelborderg;
        private System.Windows.Forms.Panel panelborderld;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton MojeB;
        private FontAwesome.Sharp.IconButton DaneK;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton Wyloguj;
    }
}