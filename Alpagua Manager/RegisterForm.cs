using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Alpagua_Manager
{
    public partial class RegisterForm : Form
    {
        private MySqlConnection connexion;
        private string server;
        private string database;
        private string uid;
        private string passwordsql;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server = "mysql-alpagua.alwaysdata.net";
            database = "alpagua_manager";
            uid = "alpagua";
            passwordsql = "Alpagua-2018";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={passwordsql};";

            connexion = new MySqlConnection(connString);

            if (usernametBox.Text == "" || passwordtBox.Text == "" || cpasswordtBox.Text == "" || nametBox.Text == "")
            {
                MessageBox.Show("Veuillez remplir l'ensemble des champs");
            }
            else if (passwordtBox.Text != cpasswordtBox.Text)
            {
                MessageBox.Show("Le mot de passe et la confirmation de mot de passe ne sont pas identiques. Veuillez vérifier votre mot de passe.");
            }
            else
            {

                ChargementForm chargForm = new ChargementForm();
                chargForm.Show();

                using (connexion = new MySqlConnection($"SERVER={server};DATABASE={database};UID={uid};PASSWORD={passwordsql};"))
                {

                    using (MySqlCommand cmd = new MySqlCommand("", connexion))
                    {
                        connexion.Open();
                        MySqlCommand command = new MySqlCommand("INSERT INTO users(pseudo,mdp,name,perm) VALUES('" + usernametBox.Text + "',MD5('" + passwordtBox.Text + "'), '" + nametBox.Text + "','1')", connexion);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Votre compte à bien été créé, veuillez maintenant vous connecter");
                        this.Close();
                        }
                    }
                }
            }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }
