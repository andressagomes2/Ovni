namespace ovni
{
    partial class Gerenciador
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnligar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.grbtrip = new System.Windows.Forms.GroupBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.grbabdu = new System.Windows.Forms.GroupBox();
            this.btnremoveab = new System.Windows.Forms.Button();
            this.btnaddabdu = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.grbestatic = new System.Windows.Forms.GroupBox();
            this.lblgenpla = new System.Windows.Forms.Label();
            this.lblgenabdu = new System.Windows.Forms.Label();
            this.lblgentrip = new System.Windows.Forms.Label();
            this.grbpla = new System.Windows.Forms.GroupBox();
            this.cmbpla = new System.Windows.Forms.ComboBox();
            this.grbtrip.SuspendLayout();
            this.grbabdu.SuspendLayout();
            this.grbestatic.SuspendLayout();
            this.grbpla.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(69, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(646, 58);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Gerenciador de Ovni";
            // 
            // btnligar
            // 
            this.btnligar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnligar.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnligar.Location = new System.Drawing.Point(31, 117);
            this.btnligar.Name = "btnligar";
            this.btnligar.Size = new System.Drawing.Size(164, 93);
            this.btnligar.TabIndex = 10;
            this.btnligar.Text = "Ligar";
            this.btnligar.UseVisualStyleBackColor = false;
            // 
            // btnDesligar
            // 
            this.btnDesligar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDesligar.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.Location = new System.Drawing.Point(216, 117);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(165, 93);
            this.btnDesligar.TabIndex = 11;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = false;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnadd.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(6, 19);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(158, 49);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Adicionar";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // grbtrip
            // 
            this.grbtrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbtrip.Controls.Add(this.btnremove);
            this.grbtrip.Controls.Add(this.btnadd);
            this.grbtrip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbtrip.Location = new System.Drawing.Point(31, 240);
            this.grbtrip.Name = "grbtrip";
            this.grbtrip.Size = new System.Drawing.Size(174, 137);
            this.grbtrip.TabIndex = 12;
            this.grbtrip.TabStop = false;
            this.grbtrip.Text = "Tripulação";
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnremove.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(6, 85);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(158, 49);
            this.btnremove.TabIndex = 13;
            this.btnremove.Text = "Remover";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // grbabdu
            // 
            this.grbabdu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbabdu.Controls.Add(this.btnremoveab);
            this.grbabdu.Controls.Add(this.btnaddabdu);
            this.grbabdu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbabdu.Location = new System.Drawing.Point(216, 240);
            this.grbabdu.Name = "grbabdu";
            this.grbabdu.Size = new System.Drawing.Size(174, 137);
            this.grbabdu.TabIndex = 13;
            this.grbabdu.TabStop = false;
            this.grbabdu.Text = "Abduzidos";
            // 
            // btnremoveab
            // 
            this.btnremoveab.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnremoveab.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveab.Location = new System.Drawing.Point(3, 88);
            this.btnremoveab.Name = "btnremoveab";
            this.btnremoveab.Size = new System.Drawing.Size(165, 43);
            this.btnremoveab.TabIndex = 13;
            this.btnremoveab.Text = "Remover";
            this.btnremoveab.UseVisualStyleBackColor = false;
            this.btnremoveab.Click += new System.EventHandler(this.btnremoveab_Click);
            // 
            // btnaddabdu
            // 
            this.btnaddabdu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnaddabdu.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddabdu.Location = new System.Drawing.Point(3, 19);
            this.btnaddabdu.Name = "btnaddabdu";
            this.btnaddabdu.Size = new System.Drawing.Size(165, 49);
            this.btnaddabdu.TabIndex = 12;
            this.btnaddabdu.Text = "Adicionar";
            this.btnaddabdu.UseVisualStyleBackColor = false;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(6, 26);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(139, 19);
            this.lblstatus.TabIndex = 3;
            this.lblstatus.Text = "Status: Ligado";
            // 
            // grbestatic
            // 
            this.grbestatic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbestatic.Controls.Add(this.lblgenpla);
            this.grbestatic.Controls.Add(this.lblgenabdu);
            this.grbestatic.Controls.Add(this.lblgentrip);
            this.grbestatic.Controls.Add(this.lblstatus);
            this.grbestatic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbestatic.Location = new System.Drawing.Point(418, 117);
            this.grbestatic.Name = "grbestatic";
            this.grbestatic.Size = new System.Drawing.Size(263, 159);
            this.grbestatic.TabIndex = 14;
            this.grbestatic.TabStop = false;
            this.grbestatic.Text = "Estatisticas";
            // 
            // lblgenpla
            // 
            this.lblgenpla.AutoSize = true;
            this.lblgenpla.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenpla.Location = new System.Drawing.Point(6, 123);
            this.lblgenpla.Name = "lblgenpla";
            this.lblgenpla.Size = new System.Drawing.Size(165, 19);
            this.lblgenpla.TabIndex = 6;
            this.lblgenpla.Text = "Planeta atual: ----";
            // 
            // lblgenabdu
            // 
            this.lblgenabdu.AutoSize = true;
            this.lblgenabdu.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenabdu.Location = new System.Drawing.Point(6, 90);
            this.lblgenabdu.Name = "lblgenabdu";
            this.lblgenabdu.Size = new System.Drawing.Size(120, 19);
            this.lblgenabdu.TabIndex = 5;
            this.lblgenabdu.Text = "Abduzidos: 0";
            // 
            // lblgentrip
            // 
            this.lblgentrip.AutoSize = true;
            this.lblgentrip.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgentrip.Location = new System.Drawing.Point(6, 59);
            this.lblgentrip.Name = "lblgentrip";
            this.lblgentrip.Size = new System.Drawing.Size(127, 19);
            this.lblgentrip.TabIndex = 4;
            this.lblgentrip.Text = "Tripulantes: 1";
            // 
            // grbpla
            // 
            this.grbpla.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbpla.Controls.Add(this.cmbpla);
            this.grbpla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbpla.Location = new System.Drawing.Point(418, 301);
            this.grbpla.Name = "grbpla";
            this.grbpla.Size = new System.Drawing.Size(275, 76);
            this.grbpla.TabIndex = 15;
            this.grbpla.TabStop = false;
            this.grbpla.Text = "Planeta";
            // 
            // cmbpla
            // 
            this.cmbpla.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpla.FormattingEnabled = true;
            this.cmbpla.Location = new System.Drawing.Point(10, 24);
            this.cmbpla.Name = "cmbpla";
            this.cmbpla.Size = new System.Drawing.Size(237, 36);
            this.cmbpla.TabIndex = 0;
            this.cmbpla.SelectedIndexChanged += new System.EventHandler(this.cmbpla_SelectedIndexChanged);
            this.cmbpla.SelectionChangeCommitted += new System.EventHandler(this.cmbpla_SelectionChangeCommitted);
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbpla);
            this.Controls.Add(this.grbestatic);
            this.Controls.Add(this.grbabdu);
            this.Controls.Add(this.grbtrip);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnligar);
            this.Controls.Add(this.lbl1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Gerenciador";
            this.Text = "Gerenciador";
            this.grbtrip.ResumeLayout(false);
            this.grbabdu.ResumeLayout(false);
            this.grbestatic.ResumeLayout(false);
            this.grbestatic.PerformLayout();
            this.grbpla.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnligar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox grbtrip;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.GroupBox grbabdu;
        private System.Windows.Forms.Button btnremoveab;
        private System.Windows.Forms.Button btnaddabdu;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.GroupBox grbestatic;
        private System.Windows.Forms.Label lblgenpla;
        private System.Windows.Forms.Label lblgenabdu;
        private System.Windows.Forms.Label lblgentrip;
        private System.Windows.Forms.GroupBox grbpla;
        private System.Windows.Forms.ComboBox cmbpla;
    }
}