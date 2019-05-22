namespace OperacionesVectores
{
    partial class MostarOperacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxmostarop = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxmostarop
            // 
            this.lbxmostarop.FormattingEnabled = true;
            this.lbxmostarop.Location = new System.Drawing.Point(12, 12);
            this.lbxmostarop.Name = "lbxmostarop";
            this.lbxmostarop.Size = new System.Drawing.Size(364, 186);
            this.lbxmostarop.TabIndex = 0;
            // 
            // MostarOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 217);
            this.Controls.Add(this.lbxmostarop);
            this.Name = "MostarOperacion";
            this.Text = "MostarOperacion";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbxmostarop;
    }
}