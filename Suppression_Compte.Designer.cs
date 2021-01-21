namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    partial class Suppression_Compte
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
            this.NumCompte = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.compteSupprimedataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.ComptedataGridView = new System.Windows.Forms.DataGridView();
            this.Quitter = new System.Windows.Forms.Button();
            this.SupprimerCompte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compteSupprimedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NumCompte
            // 
            this.NumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCompte.FormattingEnabled = true;
            this.NumCompte.Location = new System.Drawing.Point(216, 48);
            this.NumCompte.Name = "NumCompte";
            this.NumCompte.Size = new System.Drawing.Size(148, 28);
            this.NumCompte.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Les enregistrements supprime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tous Les enregistrements";
            // 
            // compteSupprimedataGridView
            // 
            this.compteSupprimedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compteSupprimedataGridView.Location = new System.Drawing.Point(271, 313);
            this.compteSupprimedataGridView.Name = "compteSupprimedataGridView";
            this.compteSupprimedataGridView.Size = new System.Drawing.Size(477, 84);
            this.compteSupprimedataGridView.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Supprission Compte";
            // 
            // ComptedataGridView
            // 
            this.ComptedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComptedataGridView.Location = new System.Drawing.Point(271, 162);
            this.ComptedataGridView.Name = "ComptedataGridView";
            this.ComptedataGridView.Size = new System.Drawing.Size(477, 132);
            this.ComptedataGridView.TabIndex = 39;
            // 
            // Quitter
            // 
            this.Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.Location = new System.Drawing.Point(589, 98);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(159, 40);
            this.Quitter.TabIndex = 38;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // SupprimerCompte
            // 
            this.SupprimerCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerCompte.Location = new System.Drawing.Point(589, 40);
            this.SupprimerCompte.Name = "SupprimerCompte";
            this.SupprimerCompte.Size = new System.Drawing.Size(159, 36);
            this.SupprimerCompte.TabIndex = 37;
            this.SupprimerCompte.Text = "Supprimer Compte";
            this.SupprimerCompte.UseVisualStyleBackColor = true;
            this.SupprimerCompte.Click += new System.EventHandler(this.SupprimerCompte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Num Compte";
            // 
            // Suppression_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumCompte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.compteSupprimedataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComptedataGridView);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.SupprimerCompte);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Suppression_Compte";
            this.Text = "Suppression_Compte";
            this.Load += new System.EventHandler(this.Suppression_Compte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compteSupprimedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NumCompte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView compteSupprimedataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ComptedataGridView;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button SupprimerCompte;
        private System.Windows.Forms.Label label1;
    }
}