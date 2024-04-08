using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Egzamin_2021_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
           
        private void buttonAccept_Click(object sender, EventArgs e)
        { 

            string email = textBoxEmail.Text;
            string haslo = textBoxHaslo.Text;
            string powtorzoneHaslo = textBoxPowtorzoneHaslo.Text;

            if(!email.Contains("@"))
            {
                label.Text = "Nieprawidłowy adres e-mail";
            }
            else if(haslo != powtorzoneHaslo)
            {
                label.Text = "Hasła się różnią";
            }
            else
            {
                label.Text = "Witaj " + email;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label.Text = "";
        }

    }
}
