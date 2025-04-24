using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            // willekeurige getallen genereren
            Random will = new Random();

            // Speler 1 aanmaken
            Speler speler1 = new Speler("Jelle", 100, will.Next(0, 500), will.Next(0, 500), true);

            //Speler 2 aanmaken
            Speler speler2 = new Speler("Fre",100, will.Next(0, 500), will.Next(0, 500),true);

            labelGezondheid1.Text = "Gezondheid: " + speler1.Gezondheid.ToString();
            labelGezondheid2.Text = "Gezondheid: " + speler2.Gezondheid.ToString();

            MessageBox.Show(speler1.Gezondheid.ToString(), "info ");

        }

        private void buttonGenees1_Click(object sender, EventArgs e)
        {
            // speler1.Genees(will.Next(0, 10));
            
        }

        private void buttonGenees2_Click(object sender, EventArgs e)
        {
            // speler2.Genees(will.Next(0, 10));
        }

        private void buttonValAan1_Click(object sender, EventArgs e)
        {
            //Speler2.Ontvangschade(will.Next(0, 10));
        }

        private void buttonValAan2_Click(object sender, EventArgs e)
        {
            //Speler2.Ontvangschade(will.Next(0, 10));
        }

        private void buttonToonPos_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Speler1: [" + speler1.PosX + speler1.PosY + "]" + "/t" + "Speler2: [" + speler2.PosX + speler2.PosY + "]");
        }
    }
}
