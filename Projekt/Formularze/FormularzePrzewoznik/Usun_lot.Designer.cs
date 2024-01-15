namespace Dashboard_Firmy.Formularze
{
    partial class Usun_lot
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
            this.UsunLotButt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IdLotuNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdLotuNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // UsunLotButt
            // 
            this.UsunLotButt.Location = new System.Drawing.Point(445, 251);
            this.UsunLotButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsunLotButt.Name = "UsunLotButt";
            this.UsunLotButt.Size = new System.Drawing.Size(112, 33);
            this.UsunLotButt.TabIndex = 14;
            this.UsunLotButt.Text = "Usuń lot";
            this.UsunLotButt.UseVisualStyleBackColor = true;
            this.UsunLotButt.Click += new System.EventHandler(this.UsuńLotButt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id Lotu do usunęcia:";
            // 
            // IdLotuNumber
            // 
            this.IdLotuNumber.Location = new System.Drawing.Point(420, 223);
            this.IdLotuNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdLotuNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.IdLotuNumber.Name = "IdLotuNumber";
            this.IdLotuNumber.Size = new System.Drawing.Size(160, 22);
            this.IdLotuNumber.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usunięto lot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Visible = false;
            // 
            // Usun_lot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdLotuNumber);
            this.Controls.Add(this.UsunLotButt);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Usun_lot";
            this.Text = "Usuń lot";
            ((System.ComponentModel.ISupportInitialize)(this.IdLotuNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UsunLotButt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown IdLotuNumber;
        private System.Windows.Forms.Label label1;
    }
}