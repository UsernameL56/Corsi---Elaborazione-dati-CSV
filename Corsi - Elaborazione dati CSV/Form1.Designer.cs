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
            this.SuspendLayout();
            // 
            // punto1
            // 
            this.punto1.Location = new System.Drawing.Point(28, 28);
            this.punto1.Margin = new System.Windows.Forms.Padding(2);
            this.punto1.Name = "punto1";
            this.punto1.Size = new System.Drawing.Size(56, 19);
            this.punto1.TabIndex = 0;
            this.punto1.Text = "Aggiunta";
            this.punto1.UseVisualStyleBackColor = true;
            this.punto1.Click += new System.EventHandler(this.punto1_Click);
            // 
            // punto2
            // 
            this.punto2.Location = new System.Drawing.Point(102, 28);
            this.punto2.Margin = new System.Windows.Forms.Padding(2);
            this.punto2.Name = "punto2";
            this.punto2.Size = new System.Drawing.Size(56, 19);
            this.punto2.TabIndex = 1;
            this.punto2.Text = "Campi";
            this.punto2.UseVisualStyleBackColor = true;
            this.punto2.Click += new System.EventHandler(this.punto2_Click);
            // 
            // punto3
            // 
            this.punto3.Location = new System.Drawing.Point(179, 28);
            this.punto3.Margin = new System.Windows.Forms.Padding(2);
            this.punto3.Name = "punto3";
            this.punto3.Size = new System.Drawing.Size(62, 19);
            this.punto3.TabIndex = 2;
            this.punto3.Text = "Lunghezza";
            this.punto3.UseVisualStyleBackColor = true;
            this.punto3.Click += new System.EventHandler(this.punto3_Click);
            // 
            // punto4
            // 
            this.punto4.Location = new System.Drawing.Point(258, 28);
            this.punto4.Margin = new System.Windows.Forms.Padding(2);
            this.punto4.Name = "punto4";
            this.punto4.Size = new System.Drawing.Size(69, 19);
            this.punto4.TabIndex = 3;
            this.punto4.Text = "Spaziatura";
            this.punto4.UseVisualStyleBackColor = true;
            this.punto4.Click += new System.EventHandler(this.punto4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // punto5
            // 
            this.punto5.Location = new System.Drawing.Point(340, 28);
            this.punto5.Margin = new System.Windows.Forms.Padding(2);
            this.punto5.Name = "punto5";
            this.punto5.Size = new System.Drawing.Size(69, 19);
            this.punto5.TabIndex = 5;
            this.punto5.Text = "Coda";
            this.punto5.UseVisualStyleBackColor = true;
            this.punto5.Click += new System.EventHandler(this.punto5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Comune;Provincia;Denominazione sito;Indirizzo;Numero civico;ID Anagrafe;miovalore" +
    ";cancellazione logica";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 225);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(848, 208);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // punto6
            // 
            this.punto6.Location = new System.Drawing.Point(424, 26);
            this.punto6.Name = "punto6";
            this.punto6.Size = new System.Drawing.Size(75, 23);
            this.punto6.TabIndex = 8;
            this.punto6.Text = "3Campi";
            this.punto6.UseVisualStyleBackColor = true;
            this.punto6.Click += new System.EventHandler(this.punto6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 471);
            this.Controls.Add(this.punto6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.punto5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.punto4);
            this.Controls.Add(this.punto3);
            this.Controls.Add(this.punto2);
            this.Controls.Add(this.punto1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

