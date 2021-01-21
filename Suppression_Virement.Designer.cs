namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    partial class Suppression_Virement
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
            this.NumVirement = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Quitter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComptedataGridView = new System.Windows.Forms.DataGridView();
            this.VirementdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirementdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NumVirement
            // 
            this.NumVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumVirement.FormattingEnabled = true;
            this.NumVirement.Location = new System.Drawing.Point(225, 49);
            this.NumVirement.Name = "NumVirement";
            this.NumVirement.Size = new System.Drawing.Size(148, 28);
            this.NumVirement.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 25);
            this.label5.TabIndex = 62;
            this.label5.Text = "Supprission Virement";
            // 
            // Quitter
            // 
            this.Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.Location = new System.Drawing.Point(587, 91);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(159, 40);
            this.Quitter.TabIndex = 60;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Location = new System.Drawing.Point(587, 33);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(159, 36);
            this.Supprimer.TabIndex = 59;
            this.Supprimer.Text = "Suppeimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Num Virement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(665, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Virement";
            // 
            // ComptedataGridView
            // 
            this.ComptedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComptedataGridView.Location = new System.Drawing.Point(186, 304);
            this.ComptedataGridView.Name = "ComptedataGridView";
            this.ComptedataGridView.Size = new System.Drawing.Size(560, 105);
            this.ComptedataGridView.TabIndex = 68;
            // 
            // VirementdataGridView
            // 
            this.VirementdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VirementdataGridView.Location = new System.Drawing.Point(186, 175);
            this.VirementdataGridView.Name = "VirementdataGridView";
            this.VirementdataGridView.Size = new System.Drawing.Size(560, 105);
            this.VirementdataGridView.TabIndex = 67;
            // 
            // Suppression_Virement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComptedataGridView);
            this.Controls.Add(this.VirementdataGridView);
            this.Controls.Add(this.NumVirement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Suppression_Virement";
            this.Text = "Suppression_Virement";
            this.Load += new System.EventHandler(this.Suppression_Virement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComptedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirementdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox NumVirement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ComptedataGridView;
        private System.Windows.Forms.DataGridView VirementdataGridView;
    }
}