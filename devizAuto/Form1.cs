using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devizAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public companie compania = new companie(1, "gf", "cui342378497293", "compania1.jpg", 1);
        public persoana mecanicauto = new persoana(1, "clau", "tr", "sibiu", "0754332243", "em@c.ro", "C.I. SB-2233445");
        public persoana clientul = new persoana(2, "tib", "mar", "esp", "087493332243", "kx@b.com", "C.I. SB-445589");
        public masina fordespzr32v2345 = new masina(1,"suzuki", Color.Red, "autoturism", 2);

        public void setup()
        {
            compania.devize.Add(new deviz(1, DateTime.Now, "deviz estimatic masina 1", 2, 1));
            compania.devize[0].theextendedlist.recordsdevizextended.Add(
                new recorddevizextended(1, "diagnosticare masina", 0, 30, 119, 19));
            compania.devize[0].theextendedlist.recordsdevizextended.Add(
                new recorddevizextended(2, "schimbare ulei", 1, 0, 200, 38));
            compania.devize[0].theextendedlist.recordsdevizextended.Add(
                new recorddevizextended(3, "schimbare apa parbriz", 0, 30, 119, 19));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setup();

            float fcost = 0.0f;
            float ftva = 0.0f;

            for (int i = 0;  i < compania.devize[0].theextendedlist.recordsdevizextended.Count; i++)
            {
                fcost += compania.devize[0].theextendedlist.recordsdevizextended[i].cost;
                ftva += compania.devize[0].theextendedlist.recordsdevizextended[i].tva;
            }
            this.Text = "Cost total deviz estimativ nr 1 din data de " + DateTime.Now.ToString() + " = "; 
            this.Text += fcost.ToString() + " : si tva " + ftva.ToString();
            this.Text += " Total deviz cu tva = " + (fcost + ftva).ToString() + " Lei";
        }
    }
}
