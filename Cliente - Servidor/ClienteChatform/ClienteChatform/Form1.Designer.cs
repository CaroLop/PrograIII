namespace ClienteChatform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBPARTICIPANTES = new System.Windows.Forms.ListBox();
            this.TXTMSG = new System.Windows.Forms.TextBox();
            this.TXTNICK = new System.Windows.Forms.TextBox();
            this.BTNENVIAR = new System.Windows.Forms.Button();
            this.lbConversacion = new System.Windows.Forms.ListBox();
            this.TXTIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nick:";
            // 
            // LBPARTICIPANTES
            // 
            this.LBPARTICIPANTES.FormattingEnabled = true;
            this.LBPARTICIPANTES.Location = new System.Drawing.Point(483, 12);
            this.LBPARTICIPANTES.Name = "LBPARTICIPANTES";
            this.LBPARTICIPANTES.Size = new System.Drawing.Size(154, 251);
            this.LBPARTICIPANTES.TabIndex = 3;
            // 
            // TXTMSG
            // 
            this.TXTMSG.Location = new System.Drawing.Point(114, 384);
            this.TXTMSG.Name = "TXTMSG";
            this.TXTMSG.Size = new System.Drawing.Size(297, 20);
            this.TXTMSG.TabIndex = 4;
            // 
            // TXTNICK
            // 
            this.TXTNICK.Location = new System.Drawing.Point(537, 285);
            this.TXTNICK.Name = "TXTNICK";
            this.TXTNICK.Size = new System.Drawing.Size(100, 20);
            this.TXTNICK.TabIndex = 5;
            // 
            // BTNENVIAR
            // 
            this.BTNENVIAR.Location = new System.Drawing.Point(460, 384);
            this.BTNENVIAR.Name = "BTNENVIAR";
            this.BTNENVIAR.Size = new System.Drawing.Size(75, 23);
            this.BTNENVIAR.TabIndex = 6;
            this.BTNENVIAR.Text = "Enviar";
            this.BTNENVIAR.UseVisualStyleBackColor = true;
            this.BTNENVIAR.Click += new System.EventHandler(this.BTNENVIAR_Click);
            // 
            // lbConversacion
            // 
            this.lbConversacion.FormattingEnabled = true;
            this.lbConversacion.Location = new System.Drawing.Point(49, 12);
            this.lbConversacion.Name = "lbConversacion";
            this.lbConversacion.ScrollAlwaysVisible = true;
            this.lbConversacion.Size = new System.Drawing.Size(362, 303);
            this.lbConversacion.TabIndex = 7;
            // 
            // TXTIP
            // 
            this.TXTIP.Location = new System.Drawing.Point(149, 335);
            this.TXTIP.Name = "TXTIP";
            this.TXTIP.Size = new System.Drawing.Size(129, 20);
            this.TXTIP.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.TXTIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbConversacion);
            this.Controls.Add(this.BTNENVIAR);
            this.Controls.Add(this.TXTNICK);
            this.Controls.Add(this.TXTMSG);
            this.Controls.Add(this.LBPARTICIPANTES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBPARTICIPANTES;
        private System.Windows.Forms.Button BTNENVIAR;
        public System.Windows.Forms.TextBox TXTMSG;
        public System.Windows.Forms.TextBox TXTNICK;
        public System.Windows.Forms.ListBox lbConversacion;
        public System.Windows.Forms.TextBox TXTIP;
        private System.Windows.Forms.Label label3;
    }
}

