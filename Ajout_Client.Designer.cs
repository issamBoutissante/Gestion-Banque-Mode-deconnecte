namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    partial class Ajout_Client
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
            this.ClientdataGridView = new System.Windows.Forms.DataGridView();
            this.EnregistrerClient = new System.Windows.Forms.Button();
            this.AjouterClient = new System.Windows.Forms.Button();
            this.PrenomClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NomClient = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ajout Client";
            // 
            // ClientdataGridView
            // 
            this.ClientdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientdataGridView.Location = new System.Drawing.Point(105, 274);
            this.ClientdataGridView.Name = "ClientdataGridView";
            this.ClientdataGridView.Size = new System.Drawing.Size(594, 150);
            this.ClientdataGridView.TabIndex = 24;
            // 
            // EnregistrerClient
            // 
            this.EnregistrerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnregistrerClient.Location = new System.Drawing.Point(540, 156);
            this.EnregistrerClient.Name = "EnregistrerClient";
            this.EnregistrerClient.Size = new System.Drawing.Size(159, 57);
            this.EnregistrerClient.TabIndex = 23;
            this.EnregistrerClient.Text = "Enregistrer et Quitter";
            this.EnregistrerClient.UseVisualStyleBackColor = true;
            this.EnregistrerClient.Click += new System.EventHandler(this.EnregistrerClient_Click);
            // 
            // AjouterClient
            // 
            this.AjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterClient.Location = new System.Drawing.Point(540, 98);
            this.AjouterClient.Name = "AjouterClient";
            this.AjouterClient.Size = new System.Drawing.Size(159, 36);
            this.AjouterClient.TabIndex = 22;
            this.AjouterClient.Text = "Ajouter Client";
            this.AjouterClient.UseVisualStyleBackColor = true;
            this.AjouterClient.Click += new System.EventHandler(this.AjouterClient_Click);
            // 
            // PrenomClient
            // 
            this.PrenomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenomClient.Location = new System.Drawing.Point(222, 176);
            this.PrenomClient.Name = "PrenomClient";
            this.PrenomClient.Size = new System.Drawing.Size(148, 26);
            this.PrenomClient.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Prenom Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nom Client";
            // 
            // NumClient
            // 
            this.NumClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumClient.Location = new System.Drawing.Point(222, 98);
            this.NumClient.Name = "NumClient";
            this.NumClient.Size = new System.Drawing.Size(148, 26);
            this.NumClient.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Num Client";
            // 
            // NomClient
            // 
            this.NomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomClient.Location = new System.Drawing.Point(222, 140);
            this.NomClient.Name = "NomClient";
            this.NomClient.Size = new System.Drawing.Size(148, 26);
            this.NomClient.TabIndex = 26;
            // 
            // Ajout_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NomClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClientdataGridView);
            this.Controls.Add(this.EnregistrerClient);
            this.Controls.Add(this.AjouterClient);
            this.Controls.Add(this.PrenomClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumClient);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajout_Client";
            this.Text = "Ajout_Client";
            this.Load += new System.EventHandler(this.Ajout_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ClientdataGridView;
        private System.Windows.Forms.Button EnregistrerClient;
        private System.Windows.Forms.Button AjouterClient;
        private System.Windows.Forms.TextBox PrenomClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomClient;
    }
}