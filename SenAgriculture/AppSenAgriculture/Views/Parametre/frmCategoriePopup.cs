using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Parametre
{
    public class frmCategoriePopup : Form
    {
        private TextBox txtCode;
        private TextBox txtLibelle;
        private Button btnOk;
        private Button btnCancel;

        public string Code => txtCode.Text.Trim();
        public string Libelle => txtLibelle.Text.Trim();

        public frmCategoriePopup()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Ajouter une catégorie";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(360, 180);
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            var lblCode = new Label() { Text = "Code", Left = 12, Top = 15, Width = 60 };
            txtCode = new TextBox() { Left = 80, Top = 12, Width = 260 };

            var lblLib = new Label() { Text = "Libelle", Left = 12, Top = 50, Width = 60 };
            txtLibelle = new TextBox() { Left = 80, Top = 47, Width = 260 };

            btnOk = new Button() { Text = "OK", Left = 170, Width = 80, Top = 90, DialogResult = DialogResult.OK };
            btnCancel = new Button() { Text = "Annuler", Left = 260, Width = 80, Top = 90, DialogResult = DialogResult.Cancel };

            btnOk.Click += BtnOk_Click;

            this.Controls.Add(lblCode);
            this.Controls.Add(txtCode);
            this.Controls.Add(lblLib);
            this.Controls.Add(txtLibelle);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Veuillez saisir le code.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
