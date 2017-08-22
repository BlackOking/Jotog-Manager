using Alpagua_Manager;
using MySql.Data.MySqlClient;
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
        private MySqlConnection connexion;
        private string server;
        private string database;
        private string uid;
        private string passwordsql;

        public PrincipaleForm()
        {
            Application.Exit();

            InitializeComponent();

            tlabelAlphaAvertVersion.Text = "Vous possédez une version Beta du programme (0.1.1)";
            tlabelAlphaAvertVersion.ForeColor = Color.Orange;

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

            //Vérification du statut du serveur MySQL

            server = "127.0.0.1";
            database = "admin";
            uid = "root";
            passwordsql = "JotogManager-2017";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={passwordsql};";

            connexion = new MySqlConnection(connString);

            try
            {
                connexion.Open();
                toolStripStatusLabel1.Text = "Connecté";
                toolStripStatusLabel1.ForeColor = Color.Green;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Non connecté";
                toolStripStatusLabel1.ForeColor = Color.Red;
            }

        }

        //Click sur le bouton "Projet Esthon"

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void garryButton_Click(object sender, EventArgs e)
        {
            GarryForm MyForm = new GarryForm();
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
