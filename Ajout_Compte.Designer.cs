namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    partial class Ajout_Compte
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumCompte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Solde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumClient = new System.Windows.Forms.ComboBox();
            this.TypeCompte = new System.Windows.Forms.ComboBox();
            this.AjouterCompte = new System.Windows.Forms.Button();
            this.EnregistrerCompte = new System.Windows.Forms.Button();
            this.ComptedataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num Compte";
            // 
            // NumCompte
            // 
            this.NumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCompte.Location = new System.Drawing.Point(212, 92);
            this.NumCompte.Name = "NumCompte";
            this.NumCompte.Size = new System.Drawing.Size(148, 26);
            this.NumCompte.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num Client";
            // 
            // Solde
            // 
            this.Solde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solde.Location = new System.Drawing.Point(212, 170);
            this.Solde.Name = "Solde";
            this.Solde.Size = new System.Drawing.Size(148, 26);
            this.Solde.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Solde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type Compte";
            // 
            // NumClient
            // 
            this.NumClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumClient.FormattingEnabled = true;
            this.NumClient.Location = new System.Drawing.Point(212, 134);
            this.NumClient.Name = "NumClient";
            this.NumClient.Size = new System.Drawing.Size(148, 28);
            this.NumClient.TabIndex = 8;
            // 
            // TypeCompte
            // 
            this.TypeCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCompte.FormattingEnabled = true;
            this.TypeCompte.Items.AddRange(new object[] {
            "education ",
            "prof"});
            this.TypeCompte.Location = new System.Drawing.Point(212, 211);
            this.TypeCompte.Name = "TypeCompte";
            this.TypeCompte.Size = new System.Drawing.Size(148, 28);
            this.TypeCompte.TabIndex = 9;
            // 
            // AjouterCompte
            // 
            this.AjouterCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterCompte.Location = new System.Drawing.Point(530, 92);
            this.AjouterCompte.Name = "AjouterCompte";
            this.AjouterCompte.Size = new System.Drawing.Size(159, 36);
            this.AjouterCompte.TabIndex = 10;
            this.AjouterCompte.Text = "Ajouter Compte";
            this.AjouterCompte.UseVisualStyleBackColor = true;
            this.AjouterCompte.Click += new System.EventHandler(this.AjouterCompte_Click);
            // 
            // EnregistrerCompte
            // 
            this.EnregistrerCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnregistrerCompte.Location = new System.Drawing.Point(530, 150);
            this.EnregistrerCompte.Name = "EnregistrerCompte";
            this.EnregistrerCompte.Size = new System.Drawing.Size(159, 40);
            this.EnregistrerCompte.TabIndex = 11;
            this.EnregistrerCompte.Text = "Enregistrer et Quitter";
            this.EnregistrerCompte.UseVisualStyleBackColor = true;
            this.EnregistrerCompte.Click += new System.EventHandler(this.EnregistrerCompte_Click);
            // 
            // ComptedataGridView
            // 
            this.ComptedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComptedataGridView.Location = new System.Drawing.Point(95, 268);
            this.ComptedataGridView.Name = "ComptedataGridView";
            this.ComptedataGridView.Size = new System.Drawing.Size(594, 150);
            this.ComptedataGridView.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ajout Compte";
            // 
            // Ajout_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComptedataGridView);
            this.Controls.Add(this.EnregistrerCompte);
            this.Controls.Add(this.AjouterCompte);
            this.Controls.Add(this.TypeCompte);
            this.Controls.Add(this.NumClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Solde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumCompte);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajout_Compte";
            this.Text = "Navigation_Comptes";
            this.Load += new System.EventHandler(this.Navigation_Comptes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumCompte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Solde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NumClient;
        private System.Windows.Forms.ComboBox TypeCompte;
        private System.Windows.Forms.Button AjouterCompte;
        private System.Windows.Forms.Button EnregistrerCompte;
        private System.Windows.Forms.DataGridView ComptedataGridView;
        private System.Windows.Forms.Label label5;
    }
}