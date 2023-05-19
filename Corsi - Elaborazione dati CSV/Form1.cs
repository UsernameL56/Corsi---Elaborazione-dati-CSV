using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Corsi___Elaborazione_dati_CSV
{
    public partial class Form1 : Form
    {
        StreamReader reader = null;
        StreamWriter writer = null;
        Random random;
        string file, appoggio;
        public Form1()
        {
            InitializeComponent();
            file = "corsi.csv";
            appoggio = "corsi2.csv";
            random = new Random();
        }

        private void punto1_Click(object sender, EventArgs e)
        {
            Aggiunta(file, appoggio, random);
        }

        private void punto2_Click(object sender, EventArgs e)
        {
            Campi(appoggio);
        }

        private void punto3_Click(object sender, EventArgs e)
        {
            Lunghezza(appoggio);
        }

        private void punto4_Click(object sender, EventArgs e)
        {
            Spaziatura(appoggio);
        }

        private void punto5_Click(object sender, EventArgs e)
        {
            RecordCoda(appoggio, textBox1.Text);
        }

        private void punto6_Click(object sender, EventArgs e)
        {
            TreCampi(appoggio);
        }

        //Funzione N.1
        public void Aggiunta(string file, string appoggio, Random random)
        {
            string line;
            int contatore = 0;
            StreamReader reader = new StreamReader(file);
            StreamWriter writer = new StreamWriter(appoggio);
            while ((line = reader.ReadLine()) != null)
            {
                if (contatore == 0)
                {
                    writer.WriteLine(line + ";miovalore;cancellazione logica");
                }
                else
                {
                    writer.WriteLine(line + ";" + random.Next(10, 21) + ";true");
                }
                contatore++;
            }
            reader.Close();
            writer.Close();
        }


        //Funzione N.2
        public void Campi(string appoggio)
        {
            string line;
            int n;
            StreamReader reader = new StreamReader(appoggio);
            line = reader.ReadLine();
            n = line.Split(';').Length;
            reader.Close();
            MessageBox.Show("Il numero di campi è " + n);
        }


        //Funzione N.3
        public void Lunghezza(string appoggio)
        {
            string line;
            int n, max = 0;
            StreamReader reader = new StreamReader(appoggio);
            while ((line = reader.ReadLine()) != null)
            {
                n = line.Length;
                if(n > max)
                {
                    max = n;
                }
            }
            reader.Close();
            MessageBox.Show("La lunghezza massima dei record presenti è " + max);
        }


        //Funzione N.4
        public void Spaziatura(string appoggio)
        {
            string line;
            int controllo = 0;
            StreamReader reader = new StreamReader(appoggio);
            StreamWriter writer = new StreamWriter("temp.csv");
            while ((line = reader.ReadLine()) != null)
            {
                if(controllo == 0)
                    writer.WriteLine(line);
                else
                    writer.WriteLine(line.PadRight(200)+"#");
                controllo++;
            }
            reader.Close();
            writer.Close();
        }


        //Funzione N.5
        public void RecordCoda(string appoggio, string stringa)
        {
            StreamWriter writer = new StreamWriter("temp.csv", true);
            writer.WriteLine(stringa);
            writer.Close();
        }


        //Funzione N.6
        public void TreCampi(string appoggio)
        {
            string line;
            StreamReader reader = new StreamReader(appoggio);
            while((line = reader.ReadLine()) != null)
            {
                string[] split = line.Split(';');
                listView1.Items.Add((split[0]+";"+split[3] + ";" + split[4]).PadRight(100));
            }
            reader.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
