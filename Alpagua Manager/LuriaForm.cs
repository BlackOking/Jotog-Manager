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
    public partial class LuriaForm : Form
    {

        private MySqlConnection connexion;
        private string server;
        private string database;
        private string uid;
        private string passwordsql;

        public LuriaForm()
        {
            InitializeComponent();

            server = "localhost";
            database = "version";
            uid = "root";
            passwordsql = "AlpaguaManager-2017";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={passwordsql};";

            connexion = new MySqlConnection(connString);

            try
            {
                connexion.Open();
            }
            catch
            {
                labelLuriaPublicVersion.Text = "Non connecté";
                labelLuriaPublicVersion.ForeColor = Color.Red;
                labelLuriaDevVersion.Text = "Non connecté";
                labelLuriaDevVersion.ForeColor = Color.Red;
            }

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Les serveurs du jeu sont inexistants. Les commandes de serveur sont donc inutilisable.", "Aucun serveur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
