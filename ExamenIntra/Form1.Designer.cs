namespace ExamenIntra
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.btnAjouterEMP = new System.Windows.Forms.Button();
            this.btnAfficherEMP = new System.Windows.Forms.Button();
            this.btnAfficherEMPinfo = new System.Windows.Forms.Button();
            this.btnAfficherEMPSerCli = new System.Windows.Forms.Button();
            this.btnAfficherCommandesAttentes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumEMP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommande = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnCommander = new System.Windows.Forms.Button();
            this.btnRecevoirFacture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(13, 13);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(599, 363);
            this.rtbResults.TabIndex = 0;
            this.rtbResults.Text = "";
            // 
            // btnAjouterEMP
            // 
            this.btnAjouterEMP.Location = new System.Drawing.Point(13, 392);
            this.btnAjouterEMP.Name = "btnAjouterEMP";
            this.btnAjouterEMP.Size = new System.Drawing.Size(97, 36);
            this.btnAjouterEMP.TabIndex = 1;
            this.btnAjouterEMP.Text = "Ajouter Employé";
            this.btnAjouterEMP.UseVisualStyleBackColor = true;
            this.btnAjouterEMP.Click += new System.EventHandler(this.btnAjouterEMP_Click);
            // 
            // btnAfficherEMP
            // 
            this.btnAfficherEMP.Location = new System.Drawing.Point(116, 392);
            this.btnAfficherEMP.Name = "btnAfficherEMP";
            this.btnAfficherEMP.Size = new System.Drawing.Size(97, 36);
            this.btnAfficherEMP.TabIndex = 1;
            this.btnAfficherEMP.Text = "Afficher tous les employés";
            this.btnAfficherEMP.UseVisualStyleBackColor = true;
            this.btnAfficherEMP.Click += new System.EventHandler(this.btnAfficherEMP_Click);
            // 
            // btnAfficherEMPinfo
            // 
            this.btnAfficherEMPinfo.Location = new System.Drawing.Point(219, 392);
            this.btnAfficherEMPinfo.Name = "btnAfficherEMPinfo";
            this.btnAfficherEMPinfo.Size = new System.Drawing.Size(127, 36);
            this.btnAfficherEMPinfo.TabIndex = 1;
            this.btnAfficherEMPinfo.Text = "Afficher les employé informatique\r\n";
            this.btnAfficherEMPinfo.UseVisualStyleBackColor = true;
            this.btnAfficherEMPinfo.Click += new System.EventHandler(this.btnAfficherEMPinfo_Click);
            // 
            // btnAfficherEMPSerCli
            // 
            this.btnAfficherEMPSerCli.Location = new System.Drawing.Point(352, 392);
            this.btnAfficherEMPSerCli.Name = "btnAfficherEMPSerCli";
            this.btnAfficherEMPSerCli.Size = new System.Drawing.Size(127, 36);
            this.btnAfficherEMPSerCli.TabIndex = 1;
            this.btnAfficherEMPSerCli.Text = "Afficher les employé Service clientèle";
            this.btnAfficherEMPSerCli.UseVisualStyleBackColor = true;
            this.btnAfficherEMPSerCli.Click += new System.EventHandler(this.btnAfficherEMPSerCli_Click);
            // 
            // btnAfficherCommandesAttentes
            // 
            this.btnAfficherCommandesAttentes.Location = new System.Drawing.Point(485, 392);
            this.btnAfficherCommandesAttentes.Name = "btnAfficherCommandesAttentes";
            this.btnAfficherCommandesAttentes.Size = new System.Drawing.Size(127, 36);
            this.btnAfficherCommandesAttentes.TabIndex = 1;
            this.btnAfficherCommandesAttentes.Text = "Afficher les commandes en attentes";
            this.btnAfficherCommandesAttentes.UseVisualStyleBackColor = true;
            this.btnAfficherCommandesAttentes.Click += new System.EventHandler(this.btnAfficherCommandesAttentes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Num employé:";
            // 
            // txtNumEMP
            // 
            this.txtNumEMP.Location = new System.Drawing.Point(93, 432);
            this.txtNumEMP.Name = "txtNumEMP";
            this.txtNumEMP.Size = new System.Drawing.Size(100, 20);
            this.txtNumEMP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Commande:";
            // 
            // txtCommande
            // 
            this.txtCommande.Location = new System.Drawing.Point(288, 432);
            this.txtCommande.Name = "txtCommande";
            this.txtCommande.Size = new System.Drawing.Size(100, 20);
            this.txtCommande.TabIndex = 3;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(16, 466);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(97, 466);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnCommander
            // 
            this.btnCommander.Location = new System.Drawing.Point(271, 466);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(75, 23);
            this.btnCommander.TabIndex = 5;
            this.btnCommander.Text = "Commander";
            this.btnCommander.UseVisualStyleBackColor = true;
            this.btnCommander.Click += new System.EventHandler(this.btnCommander_Click);
            // 
            // btnRecevoirFacture
            // 
            this.btnRecevoirFacture.Location = new System.Drawing.Point(352, 466);
            this.btnRecevoirFacture.Name = "btnRecevoirFacture";
            this.btnRecevoirFacture.Size = new System.Drawing.Size(127, 23);
            this.btnRecevoirFacture.TabIndex = 5;
            this.btnRecevoirFacture.Text = "Recevoir la facture";
            this.btnRecevoirFacture.UseVisualStyleBackColor = true;
            this.btnRecevoirFacture.Click += new System.EventHandler(this.btnRecevoirFacture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 592);
            this.Controls.Add(this.btnRecevoirFacture);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnCommander);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCommande);
            this.Controls.Add(this.txtNumEMP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfficherCommandesAttentes);
            this.Controls.Add(this.btnAfficherEMPSerCli);
            this.Controls.Add(this.btnAfficherEMPinfo);
            this.Controls.Add(this.btnAfficherEMP);
            this.Controls.Add(this.btnAjouterEMP);
            this.Controls.Add(this.rtbResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Button btnAjouterEMP;
        private System.Windows.Forms.Button btnAfficherEMP;
        private System.Windows.Forms.Button btnAfficherEMPinfo;
        private System.Windows.Forms.Button btnAfficherEMPSerCli;
        private System.Windows.Forms.Button btnAfficherCommandesAttentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumEMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCommande;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnCommander;
        private System.Windows.Forms.Button btnRecevoirFacture;
    }
}

