namespace LaTuerca
{
    partial class pantallaSiguiente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.siguienteDom = new System.Windows.Forms.Button();
            this.cancelarDom = new System.Windows.Forms.Button();
            this.Pedido = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 59);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desea Confirmar El Pedido?";
            // 
            // siguienteDom
            // 
            this.siguienteDom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.siguienteDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.siguienteDom.Location = new System.Drawing.Point(577, 257);
            this.siguienteDom.Margin = new System.Windows.Forms.Padding(4);
            this.siguienteDom.Name = "siguienteDom";
            this.siguienteDom.Size = new System.Drawing.Size(179, 64);
            this.siguienteDom.TabIndex = 6;
            this.siguienteDom.Text = "Confirmar";
            this.siguienteDom.UseVisualStyleBackColor = false;
            this.siguienteDom.Click += new System.EventHandler(this.siguienteDom_Click);
            // 
            // cancelarDom
            // 
            this.cancelarDom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cancelarDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cancelarDom.Location = new System.Drawing.Point(16, 257);
            this.cancelarDom.Margin = new System.Windows.Forms.Padding(4);
            this.cancelarDom.Name = "cancelarDom";
            this.cancelarDom.Size = new System.Drawing.Size(179, 64);
            this.cancelarDom.TabIndex = 7;
            this.cancelarDom.Text = "Regresar";
            this.cancelarDom.UseVisualStyleBackColor = false;
            this.cancelarDom.Click += new System.EventHandler(this.cancelarDom_Click);
            // 
            // Pedido
            // 
            this.Pedido.BackColor = System.Drawing.SystemColors.Info;
            this.Pedido.FormattingEnabled = true;
            this.Pedido.ItemHeight = 16;
            this.Pedido.Location = new System.Drawing.Point(16, 70);
            this.Pedido.Name = "Pedido";
            this.Pedido.Size = new System.Drawing.Size(740, 180);
            this.Pedido.TabIndex = 8;
            // 
            // pantallaSiguiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 336);
            this.Controls.Add(this.Pedido);
            this.Controls.Add(this.cancelarDom);
            this.Controls.Add(this.siguienteDom);
            this.Controls.Add(this.panel1);
            this.Name = "pantallaSiguiente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siguiente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button siguienteDom;
        private System.Windows.Forms.Button cancelarDom;
        private System.Windows.Forms.ListBox Pedido;
    }
}