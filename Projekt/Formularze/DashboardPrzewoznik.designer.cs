namespace Dashboard_Firmy
{
    partial class DashboardPrzewoznik
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPrzewoznik));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.DodajL = new FontAwesome.Sharp.IconButton();
            this.Listal = new FontAwesome.Sharp.IconButton();
            this.Kontof = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTytul = new System.Windows.Forms.Panel();
            this.panelborderlm = new System.Windows.Forms.Panel();
            this.panelWybraneTytul = new System.Windows.Forms.Label();
            this.iconWybrany = new FontAwesome.Sharp.IconPictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelborderld = new System.Windows.Forms.Panel();
            this.panelborderg = new System.Windows.Forms.Panel();
            this.EdytujL = new FontAwesome.Sharp.IconButton();
            this.UsunL = new FontAwesome.Sharp.IconButton();
            this.Wyloguj = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTytul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconWybrany)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.Wyloguj);
            this.panelMenu.Controls.Add(this.UsunL);
            this.panelMenu.Controls.Add(this.EdytujL);
            this.panelMenu.Controls.Add(this.DodajL);
            this.panelMenu.Controls.Add(this.Listal);
            this.panelMenu.Controls.Add(this.Kontof);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 675);
            this.panelMenu.TabIndex = 0;
            // 
            // DodajL
            // 
            this.DodajL.BackColor = System.Drawing.Color.White;
            this.DodajL.Dock = System.Windows.Forms.DockStyle.Top;
            this.DodajL.FlatAppearance.BorderSize = 0;
            this.DodajL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajL.ForeColor = System.Drawing.Color.Black;
            this.DodajL.IconChar = FontAwesome.Sharp.IconChar.PlaneCircleCheck;
            this.DodajL.IconColor = System.Drawing.Color.Orange;
            this.DodajL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DodajL.IconSize = 32;
            this.DodajL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DodajL.Location = new System.Drawing.Point(0, 320);
            this.DodajL.Margin = new System.Windows.Forms.Padding(4);
            this.DodajL.Name = "DodajL";
            this.DodajL.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.DodajL.Size = new System.Drawing.Size(293, 74);
            this.DodajL.TabIndex = 3;
            this.DodajL.Text = "Dodaj lot";
            this.DodajL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DodajL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DodajL.UseVisualStyleBackColor = false;
            this.DodajL.Click += new System.EventHandler(this.Dodajl_Click);
            // 
            // Listal
            // 
            this.Listal.BackColor = System.Drawing.Color.White;
            this.Listal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Listal.FlatAppearance.BorderSize = 0;
            this.Listal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Listal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Listal.ForeColor = System.Drawing.Color.Black;
            this.Listal.IconChar = FontAwesome.Sharp.IconChar.PlaneUp;
            this.Listal.IconColor = System.Drawing.Color.Orange;
            this.Listal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Listal.IconSize = 32;
            this.Listal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Listal.Location = new System.Drawing.Point(0, 246);
            this.Listal.Margin = new System.Windows.Forms.Padding(4);
            this.Listal.Name = "Listal";
            this.Listal.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Listal.Size = new System.Drawing.Size(293, 74);
            this.Listal.TabIndex = 2;
            this.Listal.Text = "Lista lotów";
            this.Listal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Listal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Listal.UseVisualStyleBackColor = false;
            this.Listal.Click += new System.EventHandler(this.Listal_Click);
            // 
            // Kontof
            // 
            this.Kontof.BackColor = System.Drawing.Color.White;
            this.Kontof.Dock = System.Windows.Forms.DockStyle.Top;
            this.Kontof.FlatAppearance.BorderSize = 0;
            this.Kontof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kontof.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kontof.ForeColor = System.Drawing.Color.Black;
            this.Kontof.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.Kontof.IconColor = System.Drawing.Color.Orange;
            this.Kontof.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Kontof.IconSize = 32;
            this.Kontof.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kontof.Location = new System.Drawing.Point(0, 172);
            this.Kontof.Margin = new System.Windows.Forms.Padding(4);
            this.Kontof.Name = "Kontof";
            this.Kontof.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Kontof.Size = new System.Drawing.Size(293, 74);
            this.Kontof.TabIndex = 1;
            this.Kontof.Text = "Konto firmowe";
            this.Kontof.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kontof.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Kontof.UseVisualStyleBackColor = false;
            this.Kontof.Click += new System.EventHandler(this.Kontof_Click);
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
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // panelTytul
            // 
            this.panelTytul.BackColor = System.Drawing.Color.White;
            this.panelTytul.Controls.Add(this.panelborderlm);
            this.panelTytul.Controls.Add(this.panelWybraneTytul);
            this.panelTytul.Controls.Add(this.iconWybrany);
            this.panelTytul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTytul.Location = new System.Drawing.Point(293, 0);
            this.panelTytul.Margin = new System.Windows.Forms.Padding(4);
            this.panelTytul.Name = "panelTytul";
            this.panelTytul.Size = new System.Drawing.Size(990, 98);
            this.panelTytul.TabIndex = 1;
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
            this.panelWybraneTytul.Location = new System.Drawing.Point(82, 36);
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
            this.iconWybrany.Location = new System.Drawing.Point(31, 27);
            this.iconWybrany.Margin = new System.Windows.Forms.Padding(4);
            this.iconWybrany.Name = "iconWybrany";
            this.iconWybrany.Size = new System.Drawing.Size(43, 39);
            this.iconWybrany.TabIndex = 0;
            this.iconWybrany.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(293, 98);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(990, 577);
            this.panelMain.TabIndex = 2;
            // 
            // panelborderld
            // 
            this.panelborderld.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelborderld.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelborderld.Location = new System.Drawing.Point(293, 98);
            this.panelborderld.Margin = new System.Windows.Forms.Padding(4);
            this.panelborderld.Name = "panelborderld";
            this.panelborderld.Size = new System.Drawing.Size(3, 577);
            this.panelborderld.TabIndex = 3;
            // 
            // panelborderg
            // 
            this.panelborderg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelborderg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelborderg.Location = new System.Drawing.Point(296, 98);
            this.panelborderg.Margin = new System.Windows.Forms.Padding(4);
            this.panelborderg.Name = "panelborderg";
            this.panelborderg.Size = new System.Drawing.Size(987, 2);
            this.panelborderg.TabIndex = 4;
            // 
            // EdytujL
            // 
            this.EdytujL.BackColor = System.Drawing.Color.White;
            this.EdytujL.Dock = System.Windows.Forms.DockStyle.Top;
            this.EdytujL.FlatAppearance.BorderSize = 0;
            this.EdytujL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EdytujL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdytujL.ForeColor = System.Drawing.Color.Black;
            this.EdytujL.IconChar = FontAwesome.Sharp.IconChar.PlaneCircleExclamation;
            this.EdytujL.IconColor = System.Drawing.Color.Orange;
            this.EdytujL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EdytujL.IconSize = 32;
            this.EdytujL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EdytujL.Location = new System.Drawing.Point(0, 394);
            this.EdytujL.Margin = new System.Windows.Forms.Padding(4);
            this.EdytujL.Name = "EdytujL";
            this.EdytujL.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.EdytujL.Size = new System.Drawing.Size(293, 72);
            this.EdytujL.TabIndex = 6;
            this.EdytujL.Text = "Edytuj lot";
            this.EdytujL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EdytujL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EdytujL.UseVisualStyleBackColor = false;
            this.EdytujL.Click += new System.EventHandler(this.Edytujl_Click_1);
            // 
            // UsunL
            // 
            this.UsunL.BackColor = System.Drawing.Color.White;
            this.UsunL.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsunL.FlatAppearance.BorderSize = 0;
            this.UsunL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsunL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsunL.ForeColor = System.Drawing.Color.Black;
            this.UsunL.IconChar = FontAwesome.Sharp.IconChar.PlaneCircleXmark;
            this.UsunL.IconColor = System.Drawing.Color.Orange;
            this.UsunL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsunL.IconSize = 32;
            this.UsunL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsunL.Location = new System.Drawing.Point(0, 466);
            this.UsunL.Margin = new System.Windows.Forms.Padding(4);
            this.UsunL.Name = "UsunL";
            this.UsunL.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.UsunL.Size = new System.Drawing.Size(293, 72);
            this.UsunL.TabIndex = 7;
            this.UsunL.Text = "Usuń lot";
            this.UsunL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsunL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UsunL.UseVisualStyleBackColor = false;
            this.UsunL.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Wyloguj
            // 
            this.Wyloguj.BackColor = System.Drawing.Color.White;
            this.Wyloguj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Wyloguj.FlatAppearance.BorderSize = 0;
            this.Wyloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wyloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyloguj.ForeColor = System.Drawing.Color.Black;
            this.Wyloguj.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.Wyloguj.IconColor = System.Drawing.Color.Orange;
            this.Wyloguj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Wyloguj.IconSize = 32;
            this.Wyloguj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wyloguj.Location = new System.Drawing.Point(0, 601);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Wyloguj.Size = new System.Drawing.Size(293, 74);
            this.Wyloguj.TabIndex = 8;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wyloguj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Wyloguj.UseVisualStyleBackColor = false;
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click);
            // 
            // DashboardPrzewoznik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.panelborderg);
            this.Controls.Add(this.panelborderld);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTytul);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardPrzewoznik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przewoźnik";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTytul.ResumeLayout(false);
            this.panelTytul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconWybrany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton Kontof;
        private FontAwesome.Sharp.IconButton DodajL;
        private FontAwesome.Sharp.IconButton Listal;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelTytul;
        private FontAwesome.Sharp.IconPictureBox iconWybrany;
        private System.Windows.Forms.Label panelWybraneTytul;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelborderld;
        private System.Windows.Forms.Panel panelborderg;
        private System.Windows.Forms.Panel panelborderlm;
        private FontAwesome.Sharp.IconButton Wyloguj;
        private FontAwesome.Sharp.IconButton UsunL;
        private FontAwesome.Sharp.IconButton EdytujL;
    }
}

