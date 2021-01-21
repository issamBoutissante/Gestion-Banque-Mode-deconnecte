namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    partial class Suppression_Client
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
            this.NumClient = new System.Windows.Forms.ComboBox();
            this.ClientdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clientSuppremedataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Quitter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientSuppremedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NumClient
            // 
            this.NumClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumClient.FormattingEnabled = true;
            this.NumClient.Location = new System.Drawing.Point(241, 70);
            this.NumClient.Name = "NumClient";
            this.NumClient.Size = new System.Drawing.Size(148, 28);
            this.NumClient.TabIndex = 64;
            // 
            // ClientdataGridView
            // 
            this.ClientdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientdataGridView.Location = new System.Drawing.Point(241, 188);
            this.ClientdataGridView.Name = "ClientdataGridView";
            this.ClientdataGridView.Size = new System.Drawing.Size(477, 135);
            this.ClientdataGridView.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Num Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-14, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "Les enregistrements modifiers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Tous Les enregistrements";
            // 
            // clientSuppremedataGridView
            // 
            this.clientSuppremedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientSuppremedataGridView.Location = new System.Drawing.Point(241, 344);
            this.clientSuppremedataGridView.Name = "clientSuppremedataGridView";
            this.clientSuppremedataGridView.Size = new System.Drawing.Size(477, 84);
            this.clientSuppremedataGridView.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Suppression Client";
            // 
            // Quitter
            // 
            this.Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.Location = new System.Drawing.Point(559, 98);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(159, 40);
            this.Quitter.TabIndex = 53;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Location = new System.Drawing.Point(559, 40);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(159, 36);
            this.Supprimer.TabIndex = 52;
            this.Supprimer.Text = "supprimer Client";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Suppression_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumClient);
            this.Controls.Add(this.ClientdataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clientSuppremedataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Supprimer);
            this.Name = "Suppression_Client";
            this.Text = "Suppression_Client";
            this.Load += new System.EventHandler(this.Suppression_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientSuppremedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NumClient;
        private System.Windows.Forms.DataGridView ClientdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView clientSuppremedataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button Supprimer;
    }
}