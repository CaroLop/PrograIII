namespace WindowsFormsApp2
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
            this.BTNCOLTEMP = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BTNOBTEMP = new System.Windows.Forms.Button();
            this.txtleer = new System.Windows.Forms.TextBox();
            this.LBLRESULTADO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNCOLTEMP
            // 
            this.BTNCOLTEMP.Location = new System.Drawing.Point(281, 153);
            this.BTNCOLTEMP.Name = "BTNCOLTEMP";
            this.BTNCOLTEMP.Size = new System.Drawing.Size(75, 23);
            this.BTNCOLTEMP.TabIndex = 0;
            this.BTNCOLTEMP.Text = "Colocar";
            this.BTNCOLTEMP.UseVisualStyleBackColor = true;
            this.BTNCOLTEMP.Click += new System.EventHandler(this.BTNCOLTEMP_Click);
            // 
            // BTNOBTEMP
            // 
            this.BTNOBTEMP.Location = new System.Drawing.Point(281, 82);
            this.BTNOBTEMP.Name = "BTNOBTEMP";
            this.BTNOBTEMP.Size = new System.Drawing.Size(75, 23);
            this.BTNOBTEMP.TabIndex = 1;
            this.BTNOBTEMP.Text = "Obtener";
            this.BTNOBTEMP.UseVisualStyleBackColor = true;
            this.BTNOBTEMP.Click += new System.EventHandler(this.BTNOBTEMP_Click);
            // 
            // txtleer
            // 
            this.txtleer.Location = new System.Drawing.Point(51, 96);
            this.txtleer.Name = "txtleer";
            this.txtleer.Size = new System.Drawing.Size(170, 20);
            this.txtleer.TabIndex = 2;
            // 
            // LBLRESULTADO
            // 
            this.LBLRESULTADO.AutoSize = true;
            this.LBLRESULTADO.Location = new System.Drawing.Point(59, 163);
            this.LBLRESULTADO.Name = "LBLRESULTADO";
            this.LBLRESULTADO.Size = new System.Drawing.Size(0, 13);
            this.LBLRESULTADO.TabIndex = 3;
            this.LBLRESULTADO.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 321);
            this.Controls.Add(this.LBLRESULTADO);
            this.Controls.Add(this.txtleer);
            this.Controls.Add(this.BTNOBTEMP);
            this.Controls.Add(this.BTNCOLTEMP);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCOLTEMP;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button BTNOBTEMP;
        private System.Windows.Forms.TextBox txtleer;
        private System.Windows.Forms.Label LBLRESULTADO;
    }
}

