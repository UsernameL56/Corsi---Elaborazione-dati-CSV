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
        string file, appoggio, appoggio2;
        int controllo;
        public Form1()
        {
            InitializeComponent();
            file = "corsi.csv";
            appoggio = "corsi2.csv";
            appoggio2 = "corsi3.csv";
            random = new Random();
            CampoUnivoco();
            File.Delete("Spaziatura.csv");
            controllo = 0;
        }

        
        

        private void close1_Click(object sender, EventArgs e)
        {
            tabControl1.Hide();
            controllo = 0;
        }
        private void close2_Click(object sender, EventArgs e)
        {
            textBoxRicerca.Clear();
            tabControl1.Hide();
            controllo = 0;
        }
        private void close3_Click(object sender, EventArgs e)
        {
            textBoxCampo.Clear();
            textBoxOriginale.Clear();
            textBoxNuovo.Clear();
            tabControl1.Hide();
            controllo = 0;
        }
        private void close4_Click(object sender, EventArgs e)
        {
            textBoxCancellazione.Clear();
            tabControl1.Hide();
        }
        private void close5_Click(object sender, EventArgs e)
        {
            tabControl1.Hide();
            controllo = 0;
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); 
            textBox6.Clear(); textBox7.Clear(); textBox8.Clear(); textBox9.Clear();
        }


        //Funzione N.1
        public void Aggiunta(string appoggio, string appoggio2, Random random)
        {
            string line;
            int contatore = 0;
            File.Delete("corsi2.csv");
            CampoUnivoco();
            StreamReader reader = new StreamReader(appoggio);
            StreamWriter writer = new StreamWriter(appoggio2);
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

            Sostituzione(appoggio2, appoggio);
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
            MessageBox.Show("Il numero di campi è " + n, "Info");
        }


        //Funzione N.3
        public int Lunghezza(string appoggio)
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
            return max;
        }


        //Funzione N.4
        public void Spaziatura(string appoggio)
        {
            string line;
            int controllo = 0;
            StreamReader reader = new StreamReader(appoggio);
            StreamWriter writer = new StreamWriter("Spaziatura.csv");
            int max = Lunghezza("corsi2.csv");
            while ((line = reader.ReadLine()) != null)
            {
                if(controllo == 0)
                    writer.WriteLine(line);
                else
                    writer.WriteLine(line.PadRight(max+10)+"#");
                controllo++;
            }
            reader.Close();
            writer.Close();
        }


        //Funzione N.5
        public void RecordCoda(string appoggio)
        {
            string sep = ";", stringa = textBox1.Text + sep + textBox2.Text + sep + textBox3.Text + sep + textBox4.Text + sep + textBox5.Text + sep + textBox6.Text + sep + textBox7.Text + sep + textBox8.Text + sep + textBox9.Text;
            StreamWriter writer = new StreamWriter("corsi2.csv", true);
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


        //Funzione N.7
        public void Ricerca(string appoggio)
        {
            string line;
            int controllo = 0;
            StreamReader reader = new StreamReader(appoggio);
            
            while ((line = reader.ReadLine()) != null)
            {
                string[] split = line.Split(';');
                    if (split[6] == textBoxRicerca.Text)
                    {
                        MessageBox.Show("Numero trovato nella riga N." + (controllo + 1), "Info");
                        controllo = 0;
                        break;
                    }
                controllo++;
            }
            if (controllo != 0)
                MessageBox.Show("Numero non trovato", "Info");

            reader.Close();
        }


        //Funzione N.8
        public void Modifica(string appoggio, string univoco, string input, string modifica)
        {
            string line;
            int temp, controllo = 0, presenza = 0;
            int n;
            StreamReader reader = new StreamReader(appoggio);
            line = reader.ReadLine();
            n = line.Split(';').Length;
            reader.Close();

            reader = new StreamReader(appoggio);
            StreamWriter writer = new StreamWriter("temp.csv");

            while ((line = reader.ReadLine()) != null)
            {
                string[] split = line.Split(';');
                if (controllo != 0)
                {
                    if (split[6] == univoco)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if (split[i] == input && i == 0)
                            {
                                writer.Write(modifica);
                                presenza = 1;
                            }else if (split[i] == input && i == n - 1)
                            {
                                writer.Write(modifica);
                                presenza = 1;
                            }else
                                writer.Write(split[i]);
                            if(i<n-1)
                                writer.Write(";");
                        }
                        writer.Write("\n");
                    }
                    else
                        writer.WriteLine(line);
                }else
                    writer.WriteLine(line);

                controllo++;
            }

            if (presenza == 0)
                MessageBox.Show("Parola non trovata all'interno del campo", "Info");
            else
                MessageBox.Show("Parola modificata correttamente!", "Info");

            writer.Close();
            reader.Close();
            Sostituzione("temp.csv", appoggio);
        }


        //Funzione N.9
        public void Cancellazione(string appoggio, string univoco)
        {
            string line;
            int controllo = 0, presenza = 0;
            int n;
            StreamReader reader = new StreamReader(appoggio);
            line = reader.ReadLine();
            n = line.Split(';').Length;
            reader.Close();

            reader = new StreamReader(appoggio);
            StreamWriter writer = new StreamWriter("temp.csv");

            while ((line = reader.ReadLine()) != null)
            {
                string[] split = line.Split(';');
                if (controllo != 0)
                {
                    if (split[6] == univoco)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if (split[i] == "true")
                                writer.Write("false");
                            else
                                writer.Write(split[i]);
                            if (i < n - 1)
                                writer.Write(";");
                        }
                        writer.Write("\n");
                        presenza = 1;
                    }
                    else
                        writer.WriteLine(line);
                }
                else
                    writer.WriteLine(line);

                controllo++;
            }

            if (presenza == 0)
                MessageBox.Show("Numero unico non trovato", "Info");
            else
                MessageBox.Show("Cancellazione logica eseguita correttamente!", "Info");

            writer.Close();
            reader.Close();

            Sostituzione("temp.csv", appoggio);
        }

        public void CampoUnivoco()
        {
            string line, file = "corsi.csv", appoggio = "corsi2.csv";
            int contatore = 0;
            StreamReader reader = new StreamReader(file);
            StreamWriter writer = new StreamWriter(appoggio);
            while ((line = reader.ReadLine()) != null)
            {
                if (contatore == 0)
                {
                    writer.WriteLine(line + ";campoUnivoco");
                }
                else
                {
                    writer.WriteLine(line + ";" + contatore);
                }
                contatore++;
            }
            reader.Close();
            writer.Close();
        }

        
                                                                                ////Funzione Aggiunta
        private void aggiuntaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aggiunta(appoggio, appoggio2, random);
            MessageBox.Show("operazione completata con successo!", "Info");
        }

        //Funzioni Hover aggiunta   
        private void aggiuntaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            info1.Show();
        }
        private void aggiuntaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            info1.Hide();
        }
            
                                                                                ////Funzione nCampi
        private void nCampiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campi(appoggio);
        }

        //Funzioni Hover nCampi
        private void nCampiToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            info2.Show();
        }
        private void nCampiToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            info2.Hide();
        }
            
                                                                                ////Funzione lunghezzaMax
        private void lunghezzaMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int max = Lunghezza(appoggio);
            MessageBox.Show("La lunghezza massima dei record presenti è " + max, "Info");
        }

        //Funzioni Hover lunghezzaMax
        private void lunghezzaMaxToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            info3.Show();
        }
        private void lunghezzaMaxToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            info3.Hide();
        }
            
                                                                                ////Funzione spaziatura
        private void spaziaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spaziatura(appoggio);
            MessageBox.Show("operazione completata con successo!", "Info");
        }

        //Funzioni Hover spaziatura
        private void spaziaturaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            info4.Show();
        }
        private void spaziaturaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            info4.Hide();
        }

                                                                                ////Funzione aggiuntaRCoda
        private void aggiuntaRCodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Show();
            tabControl1.SelectTab(0);
        }
        private void invio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text))
                MessageBox.Show("Text box vuota, inserire un valore in ciascuna text box", "Info");
            else
                RecordCoda(appoggio);

            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
            textBox6.Clear(); textBox7.Clear(); textBox8.Clear(); textBox9.Clear();
        }

        //Funzioni Hover aggiuntaRCoda
        private void aggiuntaRCodaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            info5.Show();
        }
        private void aggiuntaRCodaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            info5.Hide();
        }

                                                                                ////Funzione 3Campi               
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        { 
                tabControl1.Show();
                tabControl1.SelectTab(1);
                TreCampi(appoggio);
        }

        //Funzioni Hover 3Campi
        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            info6.Show();
        }
        private void toolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            info6.Hide();
        }

                                                                                ////Ricerca
        private void ricercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                tabControl1.Show();
                tabControl1.SelectTab(2);
        }
        private void cerca_Click_1(object sender, EventArgs e)
        {
            Ricerca(appoggio);
            textBoxRicerca.Clear();
        }

        //Funzioni Hover ricerca
        private void ricercaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            info7.Show();
        }
        private void ricercaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            info7.Hide();
        }

                                                                                ////Modifica
        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                tabControl1.Show();
                tabControl1.SelectTab(3);
        }
        private void mod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCampo.Text) || string.IsNullOrWhiteSpace(textBoxOriginale.Text) || string.IsNullOrWhiteSpace(textBoxNuovo.Text))
                MessageBox.Show("TextBox vuota, inserire un valore in ciascuna text box", "Info");
            else
                Modifica(appoggio, textBoxCampo.Text, textBoxOriginale.Text, textBoxNuovo.Text);
            textBoxCampo.Clear();
            textBoxOriginale.Clear();
            textBoxNuovo.Clear();
        }

        //Funzioni Hover modifica
        private void modificaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            info8.Show();
        }
        private void modificaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            info8.Hide();
        }
        
                                                                                ////Funzione cancellazione
        private void cancellazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Show();
            tabControl1.SelectTab(4);
        }
        private void canc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCancellazione.Text))
                MessageBox.Show("TextBox vuota, inserire un campo univoco", "Info");
            else
                Cancellazione(appoggio, textBoxCancellazione.Text);
            textBoxCancellazione.Clear();
        }

        //Funzione cancellazione
        private void cancellazioneToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            info9.Show();
        }
        private void cancellazioneToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            info9.Hide();
        }

        public void Sostituzione(string nuovo, string vecchio)
        {
            File.Delete(vecchio);
            File.Move(nuovo, vecchio);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
