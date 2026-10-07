using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_1_Click(object sender, EventArgs e)
        {
            string password;
            for (int i = 1; i < 4;)
            { password = Convert.ToString(txt_1.Text);
                if (password == "Cyber2026")
                {
                    i = 4;
                    MessageBox.Show("Password corretta");
                }
                else if (i < 3)
                {
                    i++;
                    MessageBox.Show("Password errata, riprova");
                }
                else
                {
                    MessageBox.Show("Accesso Negato");
                }
                

            }

        }
    }
}
