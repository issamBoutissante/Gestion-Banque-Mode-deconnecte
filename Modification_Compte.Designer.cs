namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    partial class Modification_Compte
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
            this.ComptedataGridView = new System.Windows.Forms.DataGridView();
            this.Quitter = new System.Windows.Forms.Button();
            this.ModifierCompte = new System.Windows.Forms.Button();
            this.TypeCompte = new System.Windows.Forms.ComboBox();
            this.NumClient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Solde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.compteModifieddataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumCompte = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteModifieddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Modification Compte";
            // 
            // ComptedataGridView
            // 
            this.ComptedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComptedataGridView.Location = new System.Drawing.Point(267, 193);
            this.ComptedataGridView.Name = "ComptedataGridView";
            this.ComptedataGridView.Size = new System.Drawing.Size(477, 132);
            this.ComptedataGridView.TabIndex = 24;
            // 
            // Quitter
            // 
            this.Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.Location = new System.Drawing.Point(585, 98);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(159, 40);
            this.Quitter.TabIndex = 23;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // ModifierCompte
            // 
            this.ModifierCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierCompte.Location = new System.Drawing.Point(585, 40);
            this.ModifierCompte.Name = "ModifierCompte";
            this.ModifierCompte.Size = new System.Drawing.Size(159, 36);
            this.ModifierCompte.TabIndex = 22;
            this.ModifierCompte.Text = "Modifier Compte";
            this.ModifierCompte.UseVisualStyleBackColor = true;
            this.ModifierCompte.Click += new System.EventHandler(this.ModifierCompte_Click);
            // 
            // TypeCompte
            // 
            this.TypeCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCompte.FormattingEnabled = true;
            this.TypeCompte.Items.AddRange(new object[] {
            "education ",
            "prof"});
            this.TypeCompte.Location = new System.Drawing.Point(267, 159);
            this.TypeCompte.Name = "TypeCompte";
            this.TypeCompte.Size = new System.Drawing.Size(148, 28);
            this.TypeCompte.TabIndex = 21;
            // 
            // NumClient
            // 
            this.NumClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumClient.FormattingEnabled = true;
            this.NumClient.Location = new System.Drawing.Point(267, 82);
            this.NumClient.Name = "NumClient";
            this.NumClient.Size = new System.Drawing.Size(148, 28);
            this.NumClient.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Type Compte";
            // 
            // Solde
            // 
            this.Solde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solde.Location = new System.Drawing.Point(267, 118);
            this.Solde.Name = "Solde";
            this.Solde.ReadOnly = true;
            this.Solde.Size = new System.Drawing.Size(148, 26);
            this.Solde.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Solde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Num Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Num Compte";
            // 
            // compteModifieddataGridView
            // 
            this.compteModifieddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compteModifieddataGridView.Location = new System.Drawing.Point(267, 344);
            this.compteModifieddataGridView.Name = "compteModifieddataGridView";
            this.compteModifieddataGridView.Size = new System.Drawing.Size(477, 84);
            this.compteModifieddataGridView.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tous Les enregistrements";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Les enregistrements modifiers";
            // 
            // NumCompte
            // 
            this.NumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCompte.FormattingEnabled = true;
            this.NumCompte.Location = new System.Drawing.Point(267, 43);
            this.NumCompte.Name = "NumCompte";
            this.NumCompte.Size = new System.Drawing.Size(148, 28);
            this.NumCompte.TabIndex = 29;
            this.NumCompte.SelectedIndexChanged += new System.EventHandler(this.NumCompte_SelectedIndexChanged);
            // 
            // Modification_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumCompte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.compteModifieddataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComptedataGridView);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.ModifierCompte);
            this.Controls.Add(this.TypeCompte);
            this.Controls.Add(this.NumClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Solde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modification_Compte";
            this.Text = "Modification_Compte";
            this.Load += new System.EventHandler(this.Modification_Compte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteModifieddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ComptedataGridView;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button ModifierCompte;
        private System.Windows.Forms.ComboBox TypeCompte;
        private System.Windows.Forms.ComboBox NumClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Solde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView compteModifieddataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox NumCompte;
    }
}