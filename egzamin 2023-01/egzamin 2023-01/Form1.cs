using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin_2023_01
{
    public partial class Form1 : Form
    {
        const string SmallLetters = "abcdefghijklmnoprstwxyz";
        const string BigLetters = "ABCDEFGHIJKLMNOPRSTWSXYZ";
        const string Numbers = "0123456789";
        const string SpecialChars = "!@#$%^&*()_+="; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Dane pracownika: ";
            string password = "Hasło: "; 


            if (checkBoxLetters.Checked)
            {
                password += SmallLetters;
            }
            if (checkBoxNum.Checked)
            {
                password += Numbers;
            }
            if (checkBoxCharacters.Checked)
            {
                password += SpecialChars;
            }

            message += textBoxName.Text + " ";
            textBoxName.Text = "";
            message += textBoxSurname.Text;
            textBoxSurname.Text = "";



            if (comboBoxStand.SelectedIndex != -1)
            {
                message += " "
                    + comboBoxStand.Text;
            }

            MessageBox.Show(message,
                "",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2
                );

        }
    }
}
