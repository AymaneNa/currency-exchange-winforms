namespace Projet_Fin_de_session
{
    partial class FrmChange
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTauxActuelles = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDevversCAD = new System.Windows.Forms.Label();
            this.lblCADversDev = new System.Windows.Forms.Label();
            this.radDevversCAD = new System.Windows.Forms.RadioButton();
            this.radCADversDev = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnReccomencer = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblDevise = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboChoixPays = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bureau De Change International";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "BANQUE DE TORONTO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.lblTauxActuelles);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnFermer);
            this.groupBox1.Controls.Add(this.btnReccomencer);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cboChoixPays);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 626);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTauxActuelles
            // 
            this.lblTauxActuelles.BackColor = System.Drawing.Color.LightGreen;
            this.lblTauxActuelles.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTauxActuelles.Location = new System.Drawing.Point(333, 91);
            this.lblTauxActuelles.Name = "lblTauxActuelles";
            this.lblTauxActuelles.Size = new System.Drawing.Size(357, 107);
            this.lblTauxActuelles.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox2.Controls.Add(this.lblDevversCAD);
            this.groupBox2.Controls.Add(this.lblCADversDev);
            this.groupBox2.Controls.Add(this.radDevversCAD);
            this.groupBox2.Controls.Add(this.radCADversDev);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 123);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Types De Conversion ";
            // 
            // lblDevversCAD
            // 
            this.lblDevversCAD.AutoSize = true;
            this.lblDevversCAD.ForeColor = System.Drawing.Color.Red;
            this.lblDevversCAD.Location = new System.Drawing.Point(79, 76);
            this.lblDevversCAD.Name = "lblDevversCAD";
            this.lblDevversCAD.Size = new System.Drawing.Size(0, 23);
            this.lblDevversCAD.TabIndex = 10;
            // 
            // lblCADversDev
            // 
            this.lblCADversDev.AutoSize = true;
            this.lblCADversDev.ForeColor = System.Drawing.Color.Red;
            this.lblCADversDev.Location = new System.Drawing.Point(75, 29);
            this.lblCADversDev.Name = "lblCADversDev";
            this.lblCADversDev.Size = new System.Drawing.Size(0, 23);
            this.lblCADversDev.TabIndex = 9;
            // 
            // radDevversCAD
            // 
            this.radDevversCAD.AutoSize = true;
            this.radDevversCAD.Location = new System.Drawing.Point(36, 77);
            this.radDevversCAD.Name = "radDevversCAD";
            this.radDevversCAD.Size = new System.Drawing.Size(21, 20);
            this.radDevversCAD.TabIndex = 8;
            this.radDevversCAD.TabStop = true;
            this.radDevversCAD.UseVisualStyleBackColor = true;
            // 
            // radCADversDev
            // 
            this.radCADversDev.AutoSize = true;
            this.radCADversDev.Location = new System.Drawing.Point(36, 30);
            this.radCADversDev.Name = "radCADversDev";
            this.radCADversDev.Size = new System.Drawing.Size(21, 20);
            this.radCADversDev.TabIndex = 7;
            this.radCADversDev.TabStop = true;
            this.radCADversDev.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 4;
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(373, 570);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(146, 36);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnReccomencer
            // 
            this.btnReccomencer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReccomencer.Location = new System.Drawing.Point(146, 570);
            this.btnReccomencer.Name = "btnReccomencer";
            this.btnReccomencer.Size = new System.Drawing.Size(146, 36);
            this.btnReccomencer.TabIndex = 8;
            this.btnReccomencer.Text = "Reccomencer";
            this.btnReccomencer.UseVisualStyleBackColor = true;
            this.btnReccomencer.Click += new System.EventHandler(this.btnReccomencer_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(142, 62);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 23);
            this.lblDate.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox3.Controls.Add(this.lblResultat);
            this.groupBox3.Controls.Add(this.btnConvertir);
            this.groupBox3.Controls.Add(this.lblDevise);
            this.groupBox3.Controls.Add(this.txtMontant);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 421);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 123);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Apply The Conversion";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(216, 88);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 23);
            this.lblResultat.TabIndex = 6;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(64, 81);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(146, 36);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir>>";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblDevise
            // 
            this.lblDevise.AutoSize = true;
            this.lblDevise.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevise.Location = new System.Drawing.Point(365, 41);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(0, 23);
            this.lblDevise.TabIndex = 4;
            // 
            // txtMontant
            // 
            this.txtMontant.ForeColor = System.Drawing.Color.Red;
            this.txtMontant.Location = new System.Drawing.Point(231, 38);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(128, 30);
            this.txtMontant.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Entrez le montant:";
            // 
            // cboChoixPays
            // 
            this.cboChoixPays.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChoixPays.FormattingEnabled = true;
            this.cboChoixPays.Location = new System.Drawing.Point(43, 151);
            this.cboChoixPays.Name = "cboChoixPays";
            this.cboChoixPays.Size = new System.Drawing.Size(190, 31);
            this.cboChoixPays.TabIndex = 2;
            this.cboChoixPays.SelectedIndexChanged += new System.EventHandler(this.cboChoixPays_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Choisir Votre Pays";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Programme De Change Avec Le Dollar Canadien";
            // 
            // FrmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(758, 760);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmChange";
            this.Text = "FrmChange";
            this.Load += new System.EventHandler(this.FrmChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboChoixPays;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblDevise;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnReccomencer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDevversCAD;
        private System.Windows.Forms.Label lblCADversDev;
        private System.Windows.Forms.RadioButton radDevversCAD;
        private System.Windows.Forms.RadioButton radCADversDev;
        private System.Windows.Forms.Label lblTauxActuelles;
    }
}