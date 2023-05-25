namespace Corsi___Elaborazione_dati_CSV
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.punto1 = new System.Windows.Forms.Button();
            this.punto2 = new System.Windows.Forms.Button();
            this.punto3 = new System.Windows.Forms.Button();
            this.punto4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.punto5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.punto6 = new System.Windows.Forms.Button();
            this.punto7 = new System.Windows.Forms.Button();
            this.punto8 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.punto9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // punto1
            // 
            this.punto1.Location = new System.Drawing.Point(37, 34);
            this.punto1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.punto1.Name = "punto1";
            this.punto1.Size = new System.Drawing.Size(75, 23);
            this.punto1.TabIndex = 0;
            this.punto1.Text = "Aggiunta";
            this.punto1.UseVisualStyleBackColor = true;
            this.punto1.Click += new System.EventHandler(this.punto1_Click);
            // 
            // punto2
            // 
            this.punto2.Location = new System.Drawing.Point(136, 34);
            this.punto2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.punto2.Name = "punto2";
            this.punto2.Size = new System.Drawing.Size(75, 23);
            this.punto2.TabIndex = 1;
            this.punto2.Text = "Campi";
            this.punto2.UseVisualStyleBackColor = true;
            this.punto2.Click += new System.EventHandler(this.punto2_Click);
            // 
            // punto3
            // 
            this.punto3.Location = new System.Drawing.Point(239, 34);
            this.punto3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.punto3.Name = "punto3";
            this.punto3.Size = new System.Drawing.Size(83, 23);
            this.punto3.TabIndex = 2;
            this.punto3.Text = "Lunghezza";
            this.punto3.UseVisualStyleBackColor = true;
            this.punto3.Click += new System.EventHandler(this.punto3_Click);
            // 
            // punto4
            // 
            this.punto4.Location = new System.Drawing.Point(344, 34);
            this.punto4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.punto4.Name = "punto4";
            this.punto4.Size = new System.Drawing.Size(92, 23);
            this.punto4.TabIndex = 3;
            this.punto4.Text = "Spaziatura";
            this.punto4.UseVisualStyleBackColor = true;
            this.punto4.Click += new System.EventHandler(this.punto4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 4;
            // 
            // punto5
            // 
            this.punto5.Location = new System.Drawing.Point(453, 34);
            this.punto5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.punto5.Name = "punto5";
            this.punto5.Size = new System.Drawing.Size(92, 23);
            this.punto5.TabIndex = 5;
            this.punto5.Text = "Coda";
            this.punto5.UseVisualStyleBackColor = true;
            this.punto5.Click += new System.EventHandler(this.punto5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Comune;Provincia;Denominazione sito;Indirizzo;Numero civico;ID Anagrafe;miovalore" +
    ";cancellazione logica";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 261);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1129, 255);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // punto6
            // 
            this.punto6.Location = new System.Drawing.Point(565, 32);
            this.punto6.Margin = new System.Windows.Forms.Padding(4);
            this.punto6.Name = "punto6";
            this.punto6.Size = new System.Drawing.Size(100, 28);
            this.punto6.TabIndex = 8;
            this.punto6.Text = "3Campi";
            this.punto6.UseVisualStyleBackColor = true;
            this.punto6.Click += new System.EventHandler(this.punto6_Click);
            // 
            // punto7
            // 
            this.punto7.Location = new System.Drawing.Point(687, 32);
            this.punto7.Margin = new System.Windows.Forms.Padding(4);
            this.punto7.Name = "punto7";
            this.punto7.Size = new System.Drawing.Size(100, 28);
            this.punto7.TabIndex = 9;
            this.punto7.Text = "Ricerca";
            this.punto7.UseVisualStyleBackColor = true;
            this.punto7.Click += new System.EventHandler(this.punto7_Click);
            // 
            // punto8
            // 
            this.punto8.Location = new System.Drawing.Point(804, 34);
            this.punto8.Margin = new System.Windows.Forms.Padding(4);
            this.punto8.Name = "punto8";
            this.punto8.Size = new System.Drawing.Size(100, 28);
            this.punto8.TabIndex = 11;
            this.punto8.Text = "Modifica";
            this.punto8.UseVisualStyleBackColor = true;
            this.punto8.Click += new System.EventHandler(this.punto8_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(912, 110);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(804, 110);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1020, 110);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 14;
            // 
            // punto9
            // 
            this.punto9.Location = new System.Drawing.Point(921, 34);
            this.punto9.Margin = new System.Windows.Forms.Padding(4);
            this.punto9.Name = "punto9";
            this.punto9.Size = new System.Drawing.Size(100, 28);
            this.punto9.TabIndex = 15;
            this.punto9.Text = "Cancellazione";
            this.punto9.UseVisualStyleBackColor = true;
            this.punto9.Click += new System.EventHandler(this.punto9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 580);
            this.Controls.Add(this.punto9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.punto8);
            this.Controls.Add(this.punto7);
            this.Controls.Add(this.punto6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.punto5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.punto4);
            this.Controls.Add(this.punto3);
            this.Controls.Add(this.punto2);
            this.Controls.Add(this.punto1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button punto1;
        private System.Windows.Forms.Button punto2;
        private System.Windows.Forms.Button punto3;
        private System.Windows.Forms.Button punto4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button punto5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button punto6;
        private System.Windows.Forms.Button punto7;
        private System.Windows.Forms.Button punto8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button punto9;
    }
}

