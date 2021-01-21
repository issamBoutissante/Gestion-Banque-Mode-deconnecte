namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    partial class Ajout_Mouvement
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
            this.label5 = new System.Windows.Forms.Label();
            this.MouvementsdataGridView = new System.Windows.Forms.DataGridView();
            this.EnregistrerClient = new System.Windows.Forms.Button();
            this.AjouterClient = new System.Windows.Forms.Button();
            this.TypeMouvement = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comptesdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumCompte = new System.Windows.Forms.ComboBox();
            this.Montant = new System.Windows.Forms.TextBox();
            this.Solde = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MouvementsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ajout Mouvement";
            // 
            // MouvementsdataGridView
            // 
            this.MouvementsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MouvementsdataGridView.Location = new System.Drawing.Point(133, 217);
            this.MouvementsdataGridView.Name = "MouvementsdataGridView";
            this.MouvementsdataGridView.Size = new System.Drawing.Size(560, 105);
            this.MouvementsdataGridView.TabIndex = 34;
            // 
            // EnregistrerClient
            // 
            this.EnregistrerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnregistrerClient.Location = new System.Drawing.Point(534, 117);
            this.EnregistrerClient.Name = "EnregistrerClient";
            this.EnregistrerClient.Size = new System.Drawing.Size(159, 57);
            this.EnregistrerClient.TabIndex = 33;
            this.EnregistrerClient.Text = "Enregistrer et Quitter";
            this.EnregistrerClient.UseVisualStyleBackColor = true;
            this.EnregistrerClient.Click += new System.EventHandler(this.EnregistrerClient_Click);
            // 
            // AjouterClient
            // 
            this.AjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterClient.Location = new System.Drawing.Point(534, 59);
            this.AjouterClient.Name = "AjouterClient";
            this.AjouterClient.Size = new System.Drawing.Size(159, 36);
            this.AjouterClient.TabIndex = 32;
            this.AjouterClient.Text = "Ajout Mouvement";
            this.AjouterClient.UseVisualStyleBackColor = true;
            this.AjouterClient.Click += new System.EventHandler(this.AjouterClient_Click);
            // 
            // TypeMouvement
            // 
            this.TypeMouvement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeMouvement.FormattingEnabled = true;
            this.TypeMouvement.Items.AddRange(new object[] {
            "dépôt",
            "retrait"});
            this.TypeMouvement.Location = new System.Drawing.Point(286, 132);
            this.TypeMouvement.Name = "TypeMouvement";
            this.TypeMouvement.Size = new System.Drawing.Size(148, 28);
            this.TypeMouvement.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Type Movement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Solde De Compte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(129, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Montant Mouvement";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Num Compte";
            // 
            // comptesdataGridView
            // 
            this.comptesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comptesdataGridView.Location = new System.Drawing.Point(133, 346);
            this.comptesdataGridView.Name = "comptesdataGridView";
            this.comptesdataGridView.Size = new System.Drawing.Size(560, 105);
            this.comptesdataGridView.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mouvements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Comptes";
            // 
            // NumCompte
            // 
            this.NumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCompte.FormattingEnabled = true;
            this.NumCompte.Location = new System.Drawing.Point(286, 49);
            this.NumCompte.Name = "NumCompte";
            this.NumCompte.Size = new System.Drawing.Size(148, 28);
            this.NumCompte.TabIndex = 48;
            this.NumCompte.SelectedIndexChanged += new System.EventHandler(this.NumCompte_SelectedIndexChanged);
            // 
            // Montant
            // 
            this.Montant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montant.Location = new System.Drawing.Point(286, 176);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(148, 26);
            this.Montant.TabIndex = 49;
            // 
            // Solde
            // 
            this.Solde.Enabled = false;
            this.Solde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solde.Location = new System.Drawing.Point(286, 92);
            this.Solde.Name = "Solde";
            this.Solde.Size = new System.Drawing.Size(148, 26);
            this.Solde.TabIndex = 41;
            // 
            // Ajout_Mouvement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.NumCompte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comptesdataGridView);
            this.Controls.Add(this.TypeMouvement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Solde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MouvementsdataGridView);
            this.Controls.Add(this.EnregistrerClient);
            this.Controls.Add(this.AjouterClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajout_Mouvement";
            this.Text = "Ajout_Mouvement";
            this.Load += new System.EventHandler(this.Ajout_Mouvement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MouvementsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView MouvementsdataGridView;
        private System.Windows.Forms.Button EnregistrerClient;
        private System.Windows.Forms.Button AjouterClient;
        private System.Windows.Forms.ComboBox TypeMouvement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView comptesdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NumCompte;
        private System.Windows.Forms.TextBox Montant;
        private System.Windows.Forms.TextBox Solde;
    }
}