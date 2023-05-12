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
            this.SuspendLayout();
            // 
            // punto1
            // 
            this.punto1.Location = new System.Drawing.Point(37, 34);
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
            this.punto2.Name = "punto2";
            this.punto2.Size = new System.Drawing.Size(75, 23);
            this.punto2.TabIndex = 1;
            this.punto2.Text = "Campi";
            this.punto2.UseVisualStyleBackColor = true;
            this.punto2.Click += new System.EventHandler(this.punto2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.punto2);
            this.Controls.Add(this.punto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button punto1;
        private System.Windows.Forms.Button punto2;
    }
}

