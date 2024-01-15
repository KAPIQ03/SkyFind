namespace Projekt
{
    partial class Moje_bilety
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
            this.idLotu = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lbDodano = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewLoty = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.idLotu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLotu
            // 
            this.idLotu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.idLotu.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLotu.Location = new System.Drawing.Point(38, 59);
            this.idLotu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idLotu.Name = "idLotu";
            this.idLotu.Size = new System.Drawing.Size(131, 31);
            this.idLotu.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(228, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dodaj lot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbDodano
            // 
            this.lbDodano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDodano.AutoSize = true;
            this.lbDodano.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDodano.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDodano.Location = new System.Drawing.Point(624, 61);
            this.lbDodano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDodano.Name = "lbDodano";
            this.lbDodano.Size = new System.Drawing.Size(172, 24);
            this.lbDodano.TabIndex = 6;
            this.lbDodano.Text = "Pomyślnie dodano ";
            this.lbDodano.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(34, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Podaj Id lotu";
            // 
            // listViewLoty
            // 
            this.listViewLoty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewLoty.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewLoty.HideSelection = false;
            this.listViewLoty.Location = new System.Drawing.Point(0, 140);
            this.listViewLoty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewLoty.Name = "listViewLoty";
            this.listViewLoty.Size = new System.Drawing.Size(969, 388);
            this.listViewLoty.TabIndex = 8;
            this.listViewLoty.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.idLotu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbDodano);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 136);
            this.panel1.TabIndex = 9;
            // 
            // Moje_bilety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewLoty);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Moje_bilety";
            this.Text = "Moje bilety";
            ((System.ComponentModel.ISupportInitialize)(this.idLotu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.NumericUpDown idLotu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbDodano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewLoty;
        private System.Windows.Forms.Panel panel1;
    }
}