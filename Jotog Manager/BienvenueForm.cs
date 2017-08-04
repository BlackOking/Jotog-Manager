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
    public partial class BienvenueForm : Form
    {
        public BienvenueForm()
        {
            InitializeComponent();

            if(DateTime.Now.Hour <= 19)
            {
                this.label1.Text = "Bonsoir " + Environment.UserName + " !";
            }

            else
            {
                if(DateTime.Now.Hour == 12)
                {
                    this.label1.Text = "Bon appétit " + Environment.UserName + " !";
                }

                else
                {
                    this.label1.Text = "Bonjour " + Environment.UserName + " !";
                }
            }

        }

    }
}
