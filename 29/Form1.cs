using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioEsBelepes
{
    public partial class Form1 : Form
    {
        string nev, jelszo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Belépés_Click(object sender, EventArgs e)
        {
            nev = Felhasználónév.Text;
            jelszo = Jelszó.Text;

            TextReader tr = File.OpenText("regisztracio.txt");
            string szoveg = tr.ReadLine();
            string[] szamTomb = szoveg.Split(',');
            if (szamTomb[0] == nev && szamTomb[1] == jelszo)
                MessageBox.Show("Udvozollek " + nev + "!");
            else
                MessageBox.Show("On meg nem regisztralt!");
            tr.Close();
        }

        private void Regisztráció_Click(object sender, EventArgs e)
        {
            nev = Felhasználónév.Text;
            jelszo = Jelszó.Text;
            FileStream fs = File.Create("regisztracio.txt");
            StreamWriter sw = new StreamWriter(fs);

            sw.Write(nev);
            sw.Write(',');
            sw.Write(jelszo);

            sw.Close();
            fs.Close();
        }

        private void Kilépés_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
