namespace ovni
{
    partial class Inicializador
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbltrip = new System.Windows.Forms.Label();
            this.lblabdu = new System.Windows.Forms.Label();
            this.txbtrip = new System.Windows.Forms.NumericUpDown();
            this.txbabdu = new System.Windows.Forms.NumericUpDown();
            this.lblpla = new System.Windows.Forms.Label();
            this.cmbpla = new System.Windows.Forms.ComboBox();
            this.btncriar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbtrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbabdu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ovni.Properties.Resources.uninteneded_concept_52FZ4cO78Ns_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(50, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(187, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(359, 32);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Gerenciador de Ovni";
            // 
            // lbltrip
            // 
            this.lbltrip.AutoSize = true;
            this.lbltrip.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrip.Location = new System.Drawing.Point(301, 90);
            this.lbltrip.Name = "lbltrip";
            this.lbltrip.Size = new System.Drawing.Size(250, 19);
            this.lbltrip.TabIndex = 2;
            this.lbltrip.Text = "Capacidade de Tripulantes:";
            // 
            // lblabdu
            // 
            this.lblabdu.AutoSize = true;
            this.lblabdu.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblabdu.Location = new System.Drawing.Point(301, 129);
            this.lblabdu.Name = "lblabdu";
            this.lblabdu.Size = new System.Drawing.Size(237, 19);
            this.lblabdu.TabIndex = 3;
            this.lblabdu.Text = "Capacidade de Abduzidos:";
            // 
            // txbtrip
            // 
            this.txbtrip.Location = new System.Drawing.Point(571, 92);
            this.txbtrip.Name = "txbtrip";
            this.txbtrip.Size = new System.Drawing.Size(120, 20);
            this.txbtrip.TabIndex = 4;
            // 
            // txbabdu
            // 
            this.txbabdu.Location = new System.Drawing.Point(571, 131);
            this.txbabdu.Name = "txbabdu";
            this.txbabdu.Size = new System.Drawing.Size(120, 20);
            this.txbabdu.TabIndex = 5;
            // 
            // lblpla
            // 
            this.lblpla.AutoSize = true;
            this.lblpla.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpla.Location = new System.Drawing.Point(301, 171);
            this.lblpla.Name = "lblpla";
            this.lblpla.Size = new System.Drawing.Size(175, 19);
            this.lblpla.TabIndex = 7;
            this.lblpla.Text = "Planeta de origem:";
            // 
            // cmbpla
            // 
            this.cmbpla.FormattingEnabled = true;
            this.cmbpla.Location = new System.Drawing.Point(571, 168);
            this.cmbpla.Name = "cmbpla";
            this.cmbpla.Size = new System.Drawing.Size(121, 21);
            this.cmbpla.TabIndex = 8;
            // 
            // btncriar
            // 
            this.btncriar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncriar.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncriar.Location = new System.Drawing.Point(411, 214);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(162, 62);
            this.btncriar.TabIndex = 9;
            this.btncriar.Text = "Criar nave";
            this.btncriar.UseVisualStyleBackColor = false;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(730, 326);
            this.Controls.Add(this.btncriar);
            this.Controls.Add(this.cmbpla);
            this.Controls.Add(this.lblpla);
            this.Controls.Add(this.txbabdu);
            this.Controls.Add(this.txbtrip);
            this.Controls.Add(this.lblabdu);
            this.Controls.Add(this.lbltrip);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Inicializador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbtrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbabdu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbltrip;
        private System.Windows.Forms.Label lblabdu;
        private System.Windows.Forms.NumericUpDown txbtrip;
        private System.Windows.Forms.NumericUpDown txbabdu;
        private System.Windows.Forms.Label lblpla;
        private System.Windows.Forms.ComboBox cmbpla;
        private System.Windows.Forms.Button btncriar;
    }
}