namespace FormProyect
{
    partial class VentasForm
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
            this.DGVPreparacion = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductosCbx = new System.Windows.Forms.ComboBox();
            this.ClientesCbx = new System.Windows.Forms.ComboBox();
            this.EntregaCbx = new System.Windows.Forms.ComboBox();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.Iniciar = new System.Windows.Forms.Button();
            this.ListBoxFinalizados = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPreparacion)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPreparacion
            // 
            this.DGVPreparacion.AllowUserToDeleteRows = false;
            this.DGVPreparacion.AllowUserToResizeColumns = false;
            this.DGVPreparacion.AllowUserToResizeRows = false;
            this.DGVPreparacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVPreparacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVPreparacion.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DGVPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPreparacion.Location = new System.Drawing.Point(12, 112);
            this.DGVPreparacion.Name = "DGVPreparacion";
            this.DGVPreparacion.ReadOnly = true;
            this.DGVPreparacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVPreparacion.Size = new System.Drawing.Size(301, 154);
            this.DGVPreparacion.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "PREPARACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "FINALIZADOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "PRODUCTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "CLIENTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "ENTREGA";
            // 
            // ProductosCbx
            // 
            this.ProductosCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductosCbx.FormattingEnabled = true;
            this.ProductosCbx.Location = new System.Drawing.Point(148, 275);
            this.ProductosCbx.Name = "ProductosCbx";
            this.ProductosCbx.Size = new System.Drawing.Size(183, 28);
            this.ProductosCbx.TabIndex = 23;
            // 
            // ClientesCbx
            // 
            this.ClientesCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesCbx.FormattingEnabled = true;
            this.ClientesCbx.Location = new System.Drawing.Point(148, 309);
            this.ClientesCbx.Name = "ClientesCbx";
            this.ClientesCbx.Size = new System.Drawing.Size(183, 28);
            this.ClientesCbx.TabIndex = 24;
            // 
            // EntregaCbx
            // 
            this.EntregaCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntregaCbx.FormattingEnabled = true;
            this.EntregaCbx.Location = new System.Drawing.Point(148, 343);
            this.EntregaCbx.Name = "EntregaCbx";
            this.EntregaCbx.Size = new System.Drawing.Size(183, 28);
            this.EntregaCbx.TabIndex = 25;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AgregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBtn.Location = new System.Drawing.Point(361, 275);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(169, 96);
            this.AgregarBtn.TabIndex = 26;
            this.AgregarBtn.Text = "AGREGAR PEDIDO";
            this.AgregarBtn.UseVisualStyleBackColor = false;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // Iniciar
            // 
            this.Iniciar.BackColor = System.Drawing.Color.Red;
            this.Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciar.Location = new System.Drawing.Point(12, 9);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(165, 72);
            this.Iniciar.TabIndex = 27;
            this.Iniciar.Text = "INICIAR DIA";
            this.Iniciar.UseVisualStyleBackColor = false;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // ListBoxFinalizados
            // 
            this.ListBoxFinalizados.BackColor = System.Drawing.SystemColors.Info;
            this.ListBoxFinalizados.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxFinalizados.FormattingEnabled = true;
            this.ListBoxFinalizados.ItemHeight = 25;
            this.ListBoxFinalizados.Location = new System.Drawing.Point(329, 112);
            this.ListBoxFinalizados.Name = "ListBoxFinalizados";
            this.ListBoxFinalizados.Size = new System.Drawing.Size(226, 154);
            this.ListBoxFinalizados.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 63);
            this.label2.TabIndex = 29;
            this.label2.Text = "BIENVENIDOS";
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(564, 377);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListBoxFinalizados);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.EntregaCbx);
            this.Controls.Add(this.ClientesCbx);
            this.Controls.Add(this.ProductosCbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVPreparacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentasForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentasForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPreparacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPreparacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ProductosCbx;
        private System.Windows.Forms.ComboBox ClientesCbx;
        private System.Windows.Forms.ComboBox EntregaCbx;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.ListBox ListBoxFinalizados;
        private System.Windows.Forms.Label label2;
    }
}