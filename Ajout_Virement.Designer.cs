namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    partial class Ajout_Virement
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
            this.ComptedataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.VirementdataGridView = new System.Windows.Forms.DataGridView();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.NumeroCrediteur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Numero_Debiteur = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirementdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Compte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Virement";
            // 
            // ComptedataGridView
            // 
            this.ComptedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComptedataGridView.Location = new System.Drawing.Point(118, 328);
            this.ComptedataGridView.Name = "ComptedataGridView";
            this.ComptedataGridView.Size = new System.Drawing.Size(560, 105);
            this.ComptedataGridView.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ajout Virement";
            // 
            // VirementdataGridView
            // 
            this.VirementdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VirementdataGridView.Location = new System.Drawing.Point(118, 199);
            this.VirementdataGridView.Name = "VirementdataGridView";
            this.VirementdataGridView.Size = new System.Drawing.Size(560, 105);
            this.VirementdataGridView.TabIndex = 52;
            // 
            // Enregistrer
            // 
            this.Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregistrer.Location = new System.Drawing.Point(519, 106);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(159, 57);
            this.Enregistrer.TabIndex = 51;
            this.Enregistrer.Text = "Enregistrer et Quitter";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(519, 48);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(159, 36);
            this.Ajouter.TabIndex = 50;
            this.Ajouter.Text = "Ajout Virement";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // NumeroCrediteur
            // 
            this.NumeroCrediteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NumeroCrediteur.FormattingEnabled = true;
            this.NumeroCrediteur.Location = new System.Drawing.Point(274, 54);
            this.NumeroCrediteur.Name = "NumeroCrediteur";
            this.NumeroCrediteur.Size = new System.Drawing.Size(102, 28);
            this.NumeroCrediteur.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(116, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Numero Crediteur";
            // 
            // Numero_Debiteur
            // 
            this.Numero_Debiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Numero_Debiteur.FormattingEnabled = true;
            this.Numero_Debiteur.Location = new System.Drawing.Point(276, 96);
            this.Numero_Debiteur.Name = "Numero_Debiteur";
            this.Numero_Debiteur.Size = new System.Drawing.Size(102, 28);
            this.Numero_Debiteur.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(118, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Montant";
            // 
            // Montant
            // 
            this.Montant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Montant.Location = new System.Drawing.Point(276, 142);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(102, 26);
            this.Montant.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(118, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 65;
            this.label10.Text = "Numero Debiteur";
            // 
            // Ajout_Virement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumeroCrediteur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Numero_Debiteur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComptedataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VirementdataGridView);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajout_Virement";
            this.Text = "Ajout_Virement";
            this.Load += new System.EventHandler(this.Ajout_Virement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirementdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ComptedataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView VirementdataGridView;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.ComboBox NumeroCrediteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Numero_Debiteur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Montant;
        private System.Windows.Forms.Label label10;
    }
}