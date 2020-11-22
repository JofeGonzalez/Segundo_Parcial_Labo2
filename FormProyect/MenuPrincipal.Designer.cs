namespace FormProyect
{
    partial class MenuPrincipal
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
            this.ClientesBtn = new System.Windows.Forms.Button();
            this.VentasBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientesBtn
            // 
            this.ClientesBtn.BackColor = System.Drawing.Color.Chocolate;
            this.ClientesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesBtn.Location = new System.Drawing.Point(33, 38);
            this.ClientesBtn.Name = "ClientesBtn";
            this.ClientesBtn.Size = new System.Drawing.Size(202, 51);
            this.ClientesBtn.TabIndex = 0;
            this.ClientesBtn.Text = "CLIENTES";
            this.ClientesBtn.UseVisualStyleBackColor = false;
            this.ClientesBtn.Click += new System.EventHandler(this.ClientesBtn_Click);
            this.ClientesBtn.MouseEnter += new System.EventHandler(this.ClientesBtn_MouseEnter);
            this.ClientesBtn.MouseLeave += new System.EventHandler(this.ClientesBtn_MouseLeave);
            // 
            // VentasBtn
            // 
            this.VentasBtn.BackColor = System.Drawing.Color.Chocolate;
            this.VentasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasBtn.Location = new System.Drawing.Point(33, 114);
            this.VentasBtn.Name = "VentasBtn";
            this.VentasBtn.Size = new System.Drawing.Size(202, 51);
            this.VentasBtn.TabIndex = 1;
            this.VentasBtn.Text = "VENTAS";
            this.VentasBtn.UseVisualStyleBackColor = false;
            this.VentasBtn.Click += new System.EventHandler(this.VentasBtn_Click);
            this.VentasBtn.MouseEnter += new System.EventHandler(this.VentasBtn_MouseEnter);
            this.VentasBtn.MouseLeave += new System.EventHandler(this.VentasBtn_MouseLeave);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(273, 197);
            this.Controls.Add(this.VentasBtn);
            this.Controls.Add(this.ClientesBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClientesBtn;
        private System.Windows.Forms.Button VentasBtn;
    }
}

