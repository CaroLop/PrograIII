namespace ExamenFinalEj1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntipodepedido = new System.Windows.Forms.Button();
            this.btnMontos = new System.Windows.Forms.Button();
            this.btnSinEntrega = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtNroPedido = new System.Windows.Forms.TextBox();
            this.cbTipoPedido = new System.Windows.Forms.ComboBox();
            this.TxtHraPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSinEntrega);
            this.tabPage3.Controls.Add(this.btnMontos);
            this.tabPage3.Controls.Add(this.btntipodepedido);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(534, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(32, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 266);
            this.panel1.TabIndex = 0;
            // 
            // btntipodepedido
            // 
            this.btntipodepedido.Location = new System.Drawing.Point(347, 139);
            this.btntipodepedido.Name = "btntipodepedido";
            this.btntipodepedido.Size = new System.Drawing.Size(107, 23);
            this.btntipodepedido.TabIndex = 1;
            this.btntipodepedido.Text = "Tipo de Pedido";
            this.btntipodepedido.UseVisualStyleBackColor = true;
            this.btntipodepedido.Click += new System.EventHandler(this.btntipodepedido_Click);
            // 
            // btnMontos
            // 
            this.btnMontos.Location = new System.Drawing.Point(347, 87);
            this.btnMontos.Name = "btnMontos";
            this.btnMontos.Size = new System.Drawing.Size(107, 23);
            this.btnMontos.TabIndex = 2;
            this.btnMontos.Text = "Montos <250";
            this.btnMontos.UseVisualStyleBackColor = true;
            this.btnMontos.Click += new System.EventHandler(this.btnMontos_Click);
            // 
            // btnSinEntrega
            // 
            this.btnSinEntrega.Location = new System.Drawing.Point(347, 45);
            this.btnSinEntrega.Name = "btnSinEntrega";
            this.btnSinEntrega.Size = new System.Drawing.Size(107, 23);
            this.btnSinEntrega.TabIndex = 3;
            this.btnSinEntrega.Text = "No entregados";
            this.btnSinEntrega.UseVisualStyleBackColor = true;
            this.btnSinEntrega.Click += new System.EventHandler(this.btnSinEntrega_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.TxtHraPedido);
            this.tabPage1.Controls.Add(this.txtNroPedido);
            this.tabPage1.Controls.Add(this.txtMonto);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbTipoPedido);
            this.tabPage1.Controls.Add(this.btnRegistro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro de Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(272, 58);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(86, 40);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(96, 128);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 2;
            // 
            // txtNroPedido
            // 
            this.txtNroPedido.Location = new System.Drawing.Point(96, 35);
            this.txtNroPedido.Name = "txtNroPedido";
            this.txtNroPedido.Size = new System.Drawing.Size(100, 20);
            this.txtNroPedido.TabIndex = 3;
            // 
            // cbTipoPedido
            // 
            this.cbTipoPedido.FormattingEnabled = true;
            this.cbTipoPedido.Items.AddRange(new object[] {
            "Carnes",
            "Verduras",
            "Frutas",
            "Bebidas",
            "Otros",
            "Comida Elaborada"});
            this.cbTipoPedido.Location = new System.Drawing.Point(96, 85);
            this.cbTipoPedido.Name = "cbTipoPedido";
            this.cbTipoPedido.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPedido.TabIndex = 4;
            // 
            // TxtHraPedido
            // 
            this.TxtHraPedido.Location = new System.Drawing.Point(96, 172);
            this.TxtHraPedido.Name = "TxtHraPedido";
            this.TxtHraPedido.Size = new System.Drawing.Size(100, 20);
            this.TxtHraPedido.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nro Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de Pedido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora del pedido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hora de entrega";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 391);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSinEntrega;
        private System.Windows.Forms.Button btnMontos;
        private System.Windows.Forms.Button btntipodepedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtHraPedido;
        private System.Windows.Forms.TextBox txtNroPedido;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoPedido;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

