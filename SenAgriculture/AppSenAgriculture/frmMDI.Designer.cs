namespace AppSenAgriculture
{
    partial class frmMDI
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDeconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cateorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(240, 245, 244);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.parametreToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(462, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(235, 240, 238);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "&Action";
            this.actionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(55, 70, 65);
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.seDeconnecterToolStripMenuItem.Text = "&Se deconnecter";
            this.seDeconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click_1);
            // 
            // parametreToolStripMenuItem
            // 
            this.parametreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitToolStripMenuItem,
            this.cateorieToolStripMenuItem,
            this.lieuToolStripMenuItem});
            this.parametreToolStripMenuItem.Name = "parametreToolStripMenuItem";
            this.parametreToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.parametreToolStripMenuItem.Text = "Parametre";
            this.parametreToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(55, 70, 65);
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produitToolStripMenuItem.Text = "&Produit";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // cateorieToolStripMenuItem
            // 
            this.cateorieToolStripMenuItem.Name = "cateorieToolStripMenuItem";
            this.cateorieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cateorieToolStripMenuItem.Text = "&Categorie";
            this.cateorieToolStripMenuItem.Click += new System.EventHandler(this.cateorieToolStripMenuItem_Click);
            // 
            // lieuToolStripMenuItem
            // 
            this.lieuToolStripMenuItem.Name = "lieuToolStripMenuItem";
            this.lieuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lieuToolStripMenuItem.Text = "&Lieu";
            this.lieuToolStripMenuItem.Click += new System.EventHandler(this.lieuToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 249);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            // Ajout d'un DataGridView pour la liste des produits
            this.dgProduits = new System.Windows.Forms.DataGridView();
            this.dgProduits.Name = "dgProduits";
            this.dgProduits.Location = new System.Drawing.Point(20, 60);
            this.dgProduits.Size = new System.Drawing.Size(760, 400);
            this.dgProduits.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgProduits.BackgroundColor = System.Drawing.Color.FromArgb(250, 251, 250);
            this.dgProduits.EnableHeadersVisualStyles = false;
            this.dgProduits.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle { BackColor = System.Drawing.Color.FromArgb(235, 240, 238), ForeColor = System.Drawing.Color.FromArgb(50, 60, 55) };
            var altStyle = new System.Windows.Forms.DataGridViewCellStyle();
            altStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 248);
            this.dgProduits.AlternatingRowsDefaultCellStyle = altStyle;
            this.Controls.Add(this.dgProduits);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "Sen Agriculture ::";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDeconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cateorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lieuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgProduits;
    }
}