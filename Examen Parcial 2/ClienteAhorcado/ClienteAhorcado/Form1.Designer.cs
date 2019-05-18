namespace ClienteAhorcado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblLetra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.txtpalabra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblganador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar Letra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Empezar a jugar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.Location = new System.Drawing.Point(60, 68);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(34, 13);
            this.lblLetra.TabIndex = 2;
            this.lblLetra.Text = "Letra:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(72, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(175, 65);
            this.txtLetra.Multiline = true;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(158, 26);
            this.txtLetra.TabIndex = 4;
            // 
            // txtpalabra
            // 
            this.txtpalabra.Location = new System.Drawing.Point(175, 109);
            this.txtpalabra.Multiline = true;
            this.txtpalabra.Name = "txtpalabra";
            this.txtpalabra.Size = new System.Drawing.Size(158, 29);
            this.txtpalabra.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Palabra:";
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.Location = new System.Drawing.Point(364, 219);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(0, 18);
            this.lblPalabra.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(449, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Enviar Palabra";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblganador
            // 
            this.lblganador.AutoSize = true;
            this.lblganador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblganador.Location = new System.Drawing.Point(364, 300);
            this.lblganador.Name = "lblganador";
            this.lblganador.Size = new System.Drawing.Size(0, 18);
            this.lblganador.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 427);
            this.Controls.Add(this.lblganador);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpalabra);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLetra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.TextBox txtpalabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblganador;
    }
}

