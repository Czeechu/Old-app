namespace FirstProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Witaj w tym programie\n";

            message += "Ulubione przedmioty: \n";

            if (checkBoxMathematics.Checked)
            {
                message += " * Matematyka \n";
            }

            if (checkBoxPoland.Checked)
            {
                message += " * Polski \n";
            }

            if (radioButtonPizzaYes.Checked)
            {
                message += "Lubiê pizze z ananasem\n";
            }

            else
            {
                message += "Nie lubiê pizze z ananasem\n";
            }

            message += "Twoje imiê to: " + textBoxName.Text + "\n";
            textBoxName.Text = " ";

              
            if(comboBoxFavouriteGame.SelectedIndex != -1)
            {
                message += "Ulubiona gra to "
                    + comboBoxFavouriteGame.Text + "\n";
            }


            MessageBox.Show("Witaj w tym programie",
                "Hello",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2
                );

        }
    }
}