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
        private string database;
        private string uid;
        private string passwordsql;

        private string user;
        private string mdp;

        public LoginForm()
        {
            server = "localhost";
            database = "admin";
            uid = "root";
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
                //MessageBox.Show("Une erreur est survenue lors de la connexion à la base MySQL", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MySqlCommand SelectCommand = new MySqlCommand("SELECT count(*) from users where Username=@Username and Password=@Password;", connexion);
                    MySqlDataReader users;
                    SelectCommand.Parameters.AddWithValue("@Username", this.tbUser.Text);
                    SelectCommand.Parameters.AddWithValue("@Password", this.tbPassword.Text);
                    cmd.Connection = connexion;

                    string login;

                    users = SelectCommand.ExecuteReader();

                    using (users)
                    {

                        if (users.Read() == true)
                        {
                            login = "true";
                            this.Hide();
                        }
                        else
                        {
                            if (users.Read() == false)
                            {
                                login = "false";
                                MessageBox.Show("Erreur d'authentification");
                            }
                        }
                    }
                }
            }
        }
    }

}
