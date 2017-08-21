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

namespace Jotog_Manager
{
    public partial class LoginForm : Form
    {

        private MySqlConnection connexion;
        private string server;
        private string port;
        private string database;
        private string uid;
        private string passwordsql;

        private string user;
        private string mdp;

        public LoginForm()
        {
            server = "mysql-alpagua.alwaysdata.net";
            port = "3306";
            database = "alpagua_manager";
            uid = "alpagua";
            passwordsql = "JotogManager-2017";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={passwordsql};";

            connexion = new MySqlConnection(connString);

            try
            {
                connexion.Open();
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue lors de la connexion à la base MySQL", "Erreur de connexion au serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = tbUser.Text;
            mdp = tbPassword.Text;

            using (connexion = new MySqlConnection($"SERVER={server};DATABASE={database};UID={uid};PASSWORD={passwordsql};"))
            {

                using (MySqlCommand cmd = new MySqlCommand("", connexion))
                {

                    connexion.Open();
                    MySqlCommand SelectCommand = new MySqlCommand("SELECT * from users where Username='" + this.tbUser.Text + "' and Password='" + this.tbPassword.Text +"' ;", connexion);
                    MySqlDataReader users;

                    users = SelectCommand.ExecuteReader();
                    int count = 0;
                    while (users.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        PrincipaleForm pForm = new PrincipaleForm();

                        System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirPrincipale));
                        monthread.Start();
                        this.Close();
                    }
                    else if (count > 1)
                    {
                        MessageBox.Show("Le nom d'utilisateur et le mot de passe sont dupliqués... Accès refusé. Veuillez contacter l'administrateur de la base.");
                    }
                    else
                    {
                        MessageBox.Show("Vos identifiants sont incorrects, veuillez réessayer...", "Echec de l'identification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        connexion.Close();
                    }

                }
            }
        }

        public static void ouvrirPrincipale()
        {
            Application.Run(new PrincipaleForm());
        }

    }

}
