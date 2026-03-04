using AppSenAgriculture.Views.Parametre;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ferme tout les formulaires enfants ouverts
        /// </summary>
        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            //For each child form set the window state to Maximized 
            foreach (Form chform in charr)
            {
                //chform.WindowState = FormWindowState.Maximized;
                chform.Close();
            }

            // Masquer la liste d'accueil quand on ouvre un enfant
            if (this.dgProduits != null)
                this.dgProduits.Visible = false;
        }

        protected override void OnMdiChildActivate(EventArgs e)
        {
            base.OnMdiChildActivate(e);
            // Si aucun enfant n'est ouvert, on affiche la liste d'accueil
            if (this.MdiChildren.Length == 0 && this.dgProduits != null)
            {
                this.dgProduits.Visible = true;
            }
            else if (this.dgProduits != null)
            {
                this.dgProduits.Visible = false;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// se deconnecter de l application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion f= new frmConnexion();
            f.Show();
            this.Close();
        }
        /// <summary>
        /// Quitter l application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// ouvrir le formulaire produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProduit f = new frmProduit();
            f.MdiParent=this;
           f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// ouvrir le formulaire categorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cateorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmCategorie f=new frmCategorie();
            f.MdiParent=this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);

            // Charger la liste des produits avec leur catégorie dans le DataGridView principal
            try
            {
                using (var db = new Models.BdSenAgricultureContext())
                {
                    var produits = db.produits.Select(p => new
                    {
                        p.IdProduit,
                        p.LibelleProduit,
                        p.DescriptionProduit,
                        p.PrixUnitaireMin,
                        p.PrixUnitaireMax,
                        Categorie = p.Categorie.DescriptionCategorie
                    }).ToList();
                    if (this.dgProduits != null)
                    {
                        this.dgProduits.DataSource = produits;
                        this.dgProduits.Columns["IdProduit"].Visible = false;
                        this.dgProduits.Columns["LibelleProduit"].HeaderText = "Produit";
                        this.dgProduits.Columns["DescriptionProduit"].HeaderText = "Description";
                        this.dgProduits.Columns["PrixUnitaireMin"].HeaderText = "Prix Min";
                        this.dgProduits.Columns["PrixUnitaireMax"].HeaderText = "Prix Max";
                        this.dgProduits.Columns["Categorie"].HeaderText = "Catégorie";
                        this.dgProduits.Visible = true;
                    }
                }
            }
            catch { }
        }

        private void lieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmLieu f = new frmLieu();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
