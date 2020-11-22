namespace FormProyect
{
    partial class ClientesForm
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
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IdClienteTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DniClienteTxt = new System.Windows.Forms.TextBox();
            this.NombreClienteTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DireccionClienteTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVClientes
            // 
            this.DGVClientes.AllowUserToAddRows = false;
            this.DGVClientes.AllowUserToDeleteRows = false;
            this.DGVClientes.AllowUserToResizeColumns = false;
            this.DGVClientes.AllowUserToResizeRows = false;
            this.DGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DGVClientes.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.DGVClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Location = new System.Drawing.Point(5, 3);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.ReadOnly = true;
            this.DGVClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVClientes.Size = new System.Drawing.Size(423, 204);
            this.DGVClientes.TabIndex = 0;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AgregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBtn.Location = new System.Drawing.Point(5, 219);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(133, 36);
            this.AgregarBtn.TabIndex = 1;
            this.AgregarBtn.Text = "AGREGAR";
            this.AgregarBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarBtn.UseVisualStyleBackColor = false;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarBtn.Location = new System.Drawing.Point(144, 219);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(149, 36);
            this.ModificarBtn.TabIndex = 2;
            this.ModificarBtn.Text = "MODIFICAR";
            this.ModificarBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ModificarBtn.UseVisualStyleBackColor = false;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.Location = new System.Drawing.Point(299, 219);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(129, 36);
            this.EliminarBtn.TabIndex = 3;
            this.EliminarBtn.Text = "ELIMINAR";
            this.EliminarBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarBtn.UseVisualStyleBackColor = false;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID";
            // 
            // IdClienteTxt
            // 
            this.IdClienteTxt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdClienteTxt.Location = new System.Drawing.Point(455, 34);
            this.IdClienteTxt.Name = "IdClienteTxt";
            this.IdClienteTxt.Size = new System.Drawing.Size(121, 28);
            this.IdClienteTxt.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // DniClienteTxt
            // 
            this.DniClienteTxt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DniClienteTxt.Location = new System.Drawing.Point(455, 159);
            this.DniClienteTxt.Name = "DniClienteTxt";
            this.DniClienteTxt.Size = new System.Drawing.Size(120, 28);
            this.DniClienteTxt.TabIndex = 19;
            // 
            // NombreClienteTxt
            // 
            this.NombreClienteTxt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClienteTxt.Location = new System.Drawing.Point(455, 97);
            this.NombreClienteTxt.Name = "NombreClienteTxt";
            this.NombreClienteTxt.Size = new System.Drawing.Size(121, 28);
            this.NombreClienteTxt.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Direccion";
            // 
            // DireccionClienteTxt
            // 
            this.DireccionClienteTxt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionClienteTxt.Location = new System.Drawing.Point(456, 227);
            this.DireccionClienteTxt.Name = "DireccionClienteTxt";
            this.DireccionClienteTxt.Size = new System.Drawing.Size(120, 28);
            this.DireccionClienteTxt.TabIndex = 23;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(588, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DireccionClienteTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdClienteTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DniClienteTxt);
            this.Controls.Add(this.NombreClienteTxt);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.DGVClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdClienteTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DniClienteTxt;
        private System.Windows.Forms.TextBox NombreClienteTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DireccionClienteTxt;
    }
}