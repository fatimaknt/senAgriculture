namespace AppSenAgriculture.Views.Parametre
{
    partial class frmProduit
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
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrixUMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrixUMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbUniteMesure = new System.Windows.Forms.ComboBox();
            this.cbbCategorie = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.dgProduit = new System.Windows.Forms.DataGridView();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.Rechercher = new System.Windows.Forms.GroupBox();
            this.txtRPrixUMin = new System.Windows.Forms.TextBox();
            this.txtRDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRLibelle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            this.Rechercher.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libelle";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(60, 70, 65);
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(16, 41);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(264, 20);
            this.txtLibelle.TabIndex = 1;
            this.txtLibelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(16, 104);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(264, 20);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtPrixUMin
            // 
            this.txtPrixUMin.Location = new System.Drawing.Point(16, 167);
            this.txtPrixUMin.Name = "txtPrixUMin";
            this.txtPrixUMin.Size = new System.Drawing.Size(264, 20);
            this.txtPrixUMin.TabIndex = 5;
            this.txtPrixUMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prix Unitaire Minimale";
            // 
            // txtPrixUMax
            // 
            this.txtPrixUMax.Location = new System.Drawing.Point(16, 230);
            this.txtPrixUMax.Name = "txtPrixUMax";
            this.txtPrixUMax.Size = new System.Drawing.Size(264, 20);
            this.txtPrixUMax.TabIndex = 7;
            this.txtPrixUMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prix Unitaire Maximale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unite De Mesure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categorie";
            // 
            // cbbUniteMesure
            // 
            this.cbbUniteMesure.FormattingEnabled = true;
            this.cbbUniteMesure.Location = new System.Drawing.Point(16, 293);
            this.cbbUniteMesure.Name = "cbbUniteMesure";
            this.cbbUniteMesure.Size = new System.Drawing.Size(261, 21);
            this.cbbUniteMesure.TabIndex = 12;
            this.cbbUniteMesure.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.FormattingEnabled = true;
            this.cbbCategorie.Location = new System.Drawing.Point(16, 357);
            this.cbbCategorie.Name = "cbbCategorie";
            this.cbbCategorie.Size = new System.Drawing.Size(261, 21);
            this.cbbCategorie.TabIndex = 13;
            this.cbbCategorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(191, 423);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 28);
            this.btnModifier.TabIndex = 16;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(220, 235, 230);
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(191, 452);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 28);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Tag = "";
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(240, 225, 225);
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(191, 394);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 28);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(200, 230, 210);
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(202, 7);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(75, 23);
            this.btnSelectionner.TabIndex = 17;
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // dgProduit
            // 
            this.dgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduit.Location = new System.Drawing.Point(309, 76);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.Size = new System.Drawing.Size(841, 438);
            this.dgProduit.TabIndex = 18;
            this.dgProduit.BackgroundColor = System.Drawing.Color.FromArgb(250, 251, 250);
            this.dgProduit.EnableHeadersVisualStyles = false;
            this.dgProduit.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 235, 233);
            this.dgProduit.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(50, 60, 55);
            var altStyle = new System.Windows.Forms.DataGridViewCellStyle();
            altStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 248);
            this.dgProduit.AlternatingRowsDefaultCellStyle = altStyle;
            // 
            // Rechercher
            // 
            this.Rechercher.BackColor = System.Drawing.Color.FromArgb(242, 245, 244);
            this.Rechercher.Controls.Add(this.btnRechercher);
            this.Rechercher.Controls.Add(this.txtRPrixUMin);
            this.Rechercher.Controls.Add(this.txtRDescription);
            this.Rechercher.Controls.Add(this.label9);
            this.Rechercher.Controls.Add(this.txtRLibelle);
            this.Rechercher.Controls.Add(this.label8);
            this.Rechercher.Controls.Add(this.label7);
            this.Rechercher.Location = new System.Drawing.Point(300, 7);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(841, 63);
            this.Rechercher.TabIndex = 19;
            this.Rechercher.TabStop = false;
            this.Rechercher.Text = "Recherche";
            // 
            // txtRPrixUMin
            // 
            this.txtRPrixUMin.Location = new System.Drawing.Point(415, 37);
            this.txtRPrixUMin.Name = "txtRPrixUMin";
            this.txtRPrixUMin.Size = new System.Drawing.Size(110, 20);
            this.txtRPrixUMin.TabIndex = 21;
            this.txtRPrixUMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // txtRDescription
            // 
            this.txtRDescription.Location = new System.Drawing.Point(229, 37);
            this.txtRDescription.Name = "txtRDescription";
            this.txtRDescription.Size = new System.Drawing.Size(110, 20);
            this.txtRDescription.TabIndex = 21;
            this.txtRDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Prix Unitaire Minimale";
            // 
            // txtRLibelle
            // 
            this.txtRLibelle.Location = new System.Drawing.Point(43, 37);
            this.txtRLibelle.Name = "txtRLibelle";
            this.txtRLibelle.Size = new System.Drawing.Size(110, 20);
            this.txtRLibelle.TabIndex = 21;
            this.txtRLibelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Libelle";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(577, 31);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(85, 26);
            this.btnRechercher.TabIndex = 20;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(200, 225, 210);
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // panelLeft
            // 
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(245, 246, 245);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(300, 492);
            this.panelLeft.TabIndex = 21;
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.txtLibelle);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.txtDescription);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.txtPrixUMin);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Controls.Add(this.txtPrixUMax);
            this.panelLeft.Controls.Add(this.label5);
            this.panelLeft.Controls.Add(this.cbbUniteMesure);
            this.panelLeft.Controls.Add(this.label6);
            this.panelLeft.Controls.Add(this.cbbCategorie);
            this.panelLeft.Controls.Add(this.btnAjouter);
            this.panelLeft.Controls.Add(this.btnModifier);
            this.panelLeft.Controls.Add(this.btnSupprimer);

            // panelMain
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(250, 251, 250);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(300, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(853, 492);
            this.panelMain.TabIndex = 22;
            this.Rechercher.Dock = System.Windows.Forms.DockStyle.Top;
            this.Rechercher.Height = 72;
            this.dgProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectionner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectionner.Location = new System.Drawing.Point(760, 10);
            this.panelMain.Controls.Add(this.dgProduit);
            this.panelMain.Controls.Add(this.Rechercher);
            this.panelMain.Controls.Add(this.btnSelectionner);

            // frmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 492);
            this.ControlBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(250, 251, 250);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.Name = "frmProduit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.frmProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            this.Rechercher.ResumeLayout(false);
            this.Rechercher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrixUMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrixUMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbUniteMesure;
        private System.Windows.Forms.ComboBox cbbCategorie;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.DataGridView dgProduit;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox Rechercher;
        private System.Windows.Forms.TextBox txtRLibelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRPrixUMin;
        private System.Windows.Forms.TextBox txtRDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRechercher;
    }
}