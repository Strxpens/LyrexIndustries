﻿namespace LaTuerca
{
    partial class menuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextoCarrito = new System.Windows.Forms.Label();
            this.LaTuercaPanel = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Button();
            this.loginAdmin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.envioDomicilio = new System.Windows.Forms.Button();
            this.siguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.TextoCarrito);
            this.panel1.Controls.Add(this.LaTuercaPanel);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 62);
            this.panel1.TabIndex = 0;
            // 
            // TextoCarrito
            // 
            this.TextoCarrito.AutoSize = true;
            this.TextoCarrito.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCarrito.Location = new System.Drawing.Point(999, 14);
            this.TextoCarrito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCarrito.Name = "TextoCarrito";
            this.TextoCarrito.Size = new System.Drawing.Size(100, 37);
            this.TextoCarrito.TabIndex = 2;
            this.TextoCarrito.Text = "Carrito";
            // 
            // LaTuercaPanel
            // 
            this.LaTuercaPanel.AutoSize = true;
            this.LaTuercaPanel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaTuercaPanel.Location = new System.Drawing.Point(224, 14);
            this.LaTuercaPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LaTuercaPanel.Name = "LaTuercaPanel";
            this.LaTuercaPanel.Size = new System.Drawing.Size(257, 37);
            this.LaTuercaPanel.TabIndex = 1;
            this.LaTuercaPanel.Text = "Chiviteria La Tuerca";
            this.LaTuercaPanel.Click += new System.EventHandler(this.LaTuercaPanel_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(51, 68);
            this.Menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(219, 63);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // loginAdmin
            // 
            this.loginAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.loginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAdmin.Location = new System.Drawing.Point(443, 68);
            this.loginAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginAdmin.Name = "loginAdmin";
            this.loginAdmin.Size = new System.Drawing.Size(232, 63);
            this.loginAdmin.TabIndex = 2;
            this.loginAdmin.Text = "Admin";
            this.loginAdmin.UseVisualStyleBackColor = false;
            this.loginAdmin.Click += new System.EventHandler(this.loginAdmin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(751, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 620);
            this.panel2.TabIndex = 3;
            // 
            // envioDomicilio
            // 
            this.envioDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.envioDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.envioDomicilio.Location = new System.Drawing.Point(51, 599);
            this.envioDomicilio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.envioDomicilio.Name = "envioDomicilio";
            this.envioDomicilio.Size = new System.Drawing.Size(219, 63);
            this.envioDomicilio.TabIndex = 4;
            this.envioDomicilio.Text = "Envio Domicilio";
            this.envioDomicilio.UseVisualStyleBackColor = false;
            this.envioDomicilio.Click += new System.EventHandler(this.envioDomicilio_Click);
            // 
            // siguiente
            // 
            this.siguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siguiente.Location = new System.Drawing.Point(456, 599);
            this.siguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(219, 63);
            this.siguiente.TabIndex = 5;
            this.siguiente.Text = "Siguiente";
            this.siguiente.UseVisualStyleBackColor = false;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1011, 617);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Carrito:";
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1349, 677);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.envioDomicilio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginAdmin);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "menuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chiviteria La Tuerca";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LaTuercaPanel;
        private System.Windows.Forms.Label TextoCarrito;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button loginAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button envioDomicilio;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.Label label1;
    }
}

