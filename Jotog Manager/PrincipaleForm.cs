using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jotog_Manager
{
    public partial class PrincipaleForm : Form
    {

        new string tableauDeBord = "";

        public PrincipaleForm()
        {
            InitializeComponent();

            BienvenueForm MyForm = new BienvenueForm();
            MyForm.TopLevel = false;
            MyForm.FormBorderStyle = FormBorderStyle.None;
            MyForm.Parent = panel1;
            MyForm.Top = 0;
            MyForm.Left = 0;
            MyForm.Size = panel1.ClientSize;
            MyForm.Dock = DockStyle.Fill;
            MyForm.BringToFront();
            MyForm.Show();
        }

        //Click sur le bouton "Projet Esthon"

        private void button1_Click(object sender, EventArgs e)
        {
            tableauDeBord = "Esthon";

            EsthonForm MyForm = new EsthonForm();
            MyForm.TopLevel = false;
            MyForm.FormBorderStyle = FormBorderStyle.None;
            MyForm.Parent = panel1;
            MyForm.Top = 0;
            MyForm.Left = 0;
            MyForm.Size = panel1.ClientSize;
            MyForm.Dock = DockStyle.Fill;
            MyForm.BringToFront();
            MyForm.Show();
        }

        //Click sur le bouton "HearthLuria"

        private void button2_Click(object sender, EventArgs e)
        {
            HearthLuriaForm MyForm = new HearthLuriaForm();
            MyForm.TopLevel = false;
            MyForm.FormBorderStyle = FormBorderStyle.None;
            MyForm.Parent = panel1;
            MyForm.Top = 0;
            MyForm.Left = 0;
            MyForm.Size = panel1.ClientSize;
            MyForm.Dock = DockStyle.Fill;
            MyForm.BringToFront();
            MyForm.Show();
        }

        //Click sur le bouton "Luria"

        private void button3_Click(object sender, EventArgs e)
        {
            tableauDeBord = "Luria";

            LuriaForm MyForm = new LuriaForm();
            MyForm.TopLevel = false;
            MyForm.FormBorderStyle = FormBorderStyle.None;
            MyForm.Parent = panel1;
            MyForm.Top = 0;
            MyForm.Left = 0;
            MyForm.Size = panel1.ClientSize;
            MyForm.Dock = DockStyle.Fill;
            MyForm.BringToFront();
            MyForm.Show();
        }

        //Click sur le bouton de fermeture de projet

        private void button4_Click(object sender, EventArgs e)
        {

            BienvenueForm MyForm = new BienvenueForm();
            MyForm.TopLevel = false;
            MyForm.FormBorderStyle = FormBorderStyle.None;
            MyForm.Parent = panel1;
            MyForm.Top = 0;
            MyForm.Left = 0;
            MyForm.Size = panel1.ClientSize;
            MyForm.Dock = DockStyle.Fill;
            MyForm.BringToFront();
            MyForm.Show();
        }

    }
}
