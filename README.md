using System;
using System.Windows.Forms;

public class MainForm : Form
{
    private RadioButton radioPocztowka;
    private RadioButton radioList;
    private RadioButton radioPaczka;
    private Button buttonSprawdzCena;
    private PictureBox pictureBox;
    private Label labelCena;

    public MainForm()
    {
        radioPocztowka = new RadioButton() { Text = "Pocztówka", AutoSize = true, Top = 10, Left = 10 };
        radioList = new RadioButton() { Text = "List", AutoSize = true, Top = 40, Left = 10 };
        radioPaczka = new RadioButton() { Text = "Paczka", AutoSize = true, Top = 70, Left = 10 };
        
        buttonSprawdzCena = new Button() { Text = "Sprawdź cenę", Top = 100, Left = 10 };
        buttonSprawdzCena.Click += new EventHandler(ButtonSprawdzCena_Click);
        
        pictureBox = new PictureBox() { Top = 130, Left = 10, Width = 100, Height = 100 };
        labelCena = new Label() { Top = 240, Left = 10, AutoSize = true };
        
        this.Controls.Add(radioPocztowka);
        this.Controls.Add(radioList);
        this.Controls.Add(radioPaczka);
        this.Controls.Add(buttonSprawdzCena);
        this.Controls.Add(pictureBox);
        this.Controls.Add(labelCena);
        
        this.Text = "Aplikacja Ceny";
        this.AutoSize = true;
        this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    }

    private void ButtonSprawdzCena_Click(object sender, EventArgs e)
    {
        if (radioPocztowka.Checked)
        {
            pictureBox.Image = Image.FromFile("pocztowka.png");
            labelCena.Text = "Cena: 1 zł";
        }
        else if (radioList.Checked)
        {
            pictureBox.Image = Image.FromFile("list.png");
            labelCena.Text = "Cena: 1,5 zł";
        }
        else if (radioPaczka.Checked)
        {
            pictureBox.Image = Image.FromFile("paczka.png");
            labelCena.Text = "Cena: 10 zł";
        }
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}


https://github.com/Technikum-TEB-Edukacja-we-Wroclawiu/INF.04-rozwiazania/tree/main/INF.04-23.06/INF.04-01-23.06-SG
