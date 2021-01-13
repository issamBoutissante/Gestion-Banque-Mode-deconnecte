namespace AT9_Gestion_Banque_Mode_Deconnecte
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouvementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutMouvementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionMovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutVirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionVirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comptesToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comptesToolStripMenuItem
            // 
            this.comptesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem,
            this.ajoutCompteToolStripMenuItem,
            this.modificationCompteToolStripMenuItem,
            this.suppressionCompteToolStripMenuItem});
            this.comptesToolStripMenuItem.Name = "comptesToolStripMenuItem";
            this.comptesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comptesToolStripMenuItem.Text = "Comptes";
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.navigationToolStripMenuItem.Text = "Navigation";
            this.navigationToolStripMenuItem.Click += new System.EventHandler(this.navigationToolStripMenuItem_Click);
            // 
            // ajoutCompteToolStripMenuItem
            // 
            this.ajoutCompteToolStripMenuItem.Name = "ajoutCompteToolStripMenuItem";
            this.ajoutCompteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ajoutCompteToolStripMenuItem.Text = "Ajout Compte";
            this.ajoutCompteToolStripMenuItem.Click += new System.EventHandler(this.ajoutCompteToolStripMenuItem_Click);
            // 
            // modificationCompteToolStripMenuItem
            // 
            this.modificationCompteToolStripMenuItem.Name = "modificationCompteToolStripMenuItem";
            this.modificationCompteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.modificationCompteToolStripMenuItem.Text = "Modification Compte";
            this.modificationCompteToolStripMenuItem.Click += new System.EventHandler(this.modificationCompteToolStripMenuItem_Click);
            // 
            // suppressionCompteToolStripMenuItem
            // 
            this.suppressionCompteToolStripMenuItem.Name = "suppressionCompteToolStripMenuItem";
            this.suppressionCompteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.suppressionCompteToolStripMenuItem.Text = "Suppression Compte";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem1,
            this.ajoutClientToolStripMenuItem,
            this.modificationClientToolStripMenuItem,
            this.suppressionClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // navigationToolStripMenuItem1
            // 
            this.navigationToolStripMenuItem1.Name = "navigationToolStripMenuItem1";
            this.navigationToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.navigationToolStripMenuItem1.Text = "Navigation";
            // 
            // ajoutClientToolStripMenuItem
            // 
            this.ajoutClientToolStripMenuItem.Name = "ajoutClientToolStripMenuItem";
            this.ajoutClientToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ajoutClientToolStripMenuItem.Text = "Ajout Client";
            // 
            // modificationClientToolStripMenuItem
            // 
            this.modificationClientToolStripMenuItem.Name = "modificationClientToolStripMenuItem";
            this.modificationClientToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.modificationClientToolStripMenuItem.Text = "Modification Client";
            // 
            // suppressionClientToolStripMenuItem
            // 
            this.suppressionClientToolStripMenuItem.Name = "suppressionClientToolStripMenuItem";
            this.suppressionClientToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.suppressionClientToolStripMenuItem.Text = "Suppression Client";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouvementToolStripMenuItem,
            this.virementToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // mouvementToolStripMenuItem
            // 
            this.mouvementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutMouvementToolStripMenuItem,
            this.suppressionMovementToolStripMenuItem});
            this.mouvementToolStripMenuItem.Name = "mouvementToolStripMenuItem";
            this.mouvementToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.mouvementToolStripMenuItem.Text = "Mouvement";
            // 
            // ajoutMouvementToolStripMenuItem
            // 
            this.ajoutMouvementToolStripMenuItem.Name = "ajoutMouvementToolStripMenuItem";
            this.ajoutMouvementToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ajoutMouvementToolStripMenuItem.Text = "Ajout Mouvement";
            // 
            // suppressionMovementToolStripMenuItem
            // 
            this.suppressionMovementToolStripMenuItem.Name = "suppressionMovementToolStripMenuItem";
            this.suppressionMovementToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.suppressionMovementToolStripMenuItem.Text = "Suppression Movement";
            // 
            // virementToolStripMenuItem
            // 
            this.virementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutVirementToolStripMenuItem,
            this.suppressionVirementToolStripMenuItem});
            this.virementToolStripMenuItem.Name = "virementToolStripMenuItem";
            this.virementToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.virementToolStripMenuItem.Text = "Virement";
            // 
            // ajoutVirementToolStripMenuItem
            // 
            this.ajoutVirementToolStripMenuItem.Name = "ajoutVirementToolStripMenuItem";
            this.ajoutVirementToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ajoutVirementToolStripMenuItem.Text = "Ajout Virement";
            // 
            // suppressionVirementToolStripMenuItem
            // 
            this.suppressionVirementToolStripMenuItem.Name = "suppressionVirementToolStripMenuItem";
            this.suppressionVirementToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.suppressionVirementToolStripMenuItem.Text = "Suppression Virement";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajoutClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouvementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutMouvementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionMovementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutVirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionVirementToolStripMenuItem;
    }
}

