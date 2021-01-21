namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    partial class Navigation_Client
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComptedataGridView = new System.Windows.Forms.DataGridView();
            this.NumClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Comptes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Client - Comptes";
            // 
            // ComptedataGridView
            // 
            this.ComptedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComptedataGridView.Location = new System.Drawing.Point(161, 172);
            this.ComptedataGridView.Name = "ComptedataGridView";
            this.ComptedataGridView.Size = new System.Drawing.Size(477, 132);
            this.ComptedataGridView.TabIndex = 48;
            // 
            // NumClient
            // 
            this.NumClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumClient.FormattingEnabled = true;
            this.NumClient.Location = new System.Drawing.Point(286, 62);
            this.NumClient.Name = "NumClient";
            this.NumClient.Size = new System.Drawing.Size(148, 28);
            this.NumClient.TabIndex = 52;
            this.NumClient.SelectedIndexChanged += new System.EventHandler(this.NumClient_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Num Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nom Client";
            // 
            // Nom
            // 
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Nom.Location = new System.Drawing.Point(286, 97);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(148, 26);
            this.Nom.TabIndex = 54;
            // 
            // Navigation_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComptedataGridView);
            this.Name = "Navigation_Client";
            this.Text = "Navigation_Client";
            this.Load += new System.EventHandler(this.Navigation_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ComptedataGridView;
        private System.Windows.Forms.ComboBox NumClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nom;
    }
}