namespace Telefonia
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
            this.dgvTelefonia = new System.Windows.Forms.DataGridView();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbLugar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tiempollamadaEvento = new System.Windows.Forms.Timer(this.components);
            this.tllamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnColgar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTelefonia
            // 
            this.dgvTelefonia.AllowUserToAddRows = false;
            this.dgvTelefonia.AllowUserToDeleteRows = false;
            this.dgvTelefonia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Telefono,
            this.Lugar,
            this.tllamada});
            this.dgvTelefonia.Location = new System.Drawing.Point(27, 117);
            this.dgvTelefonia.Name = "dgvTelefonia";
            this.dgvTelefonia.ReadOnly = true;
            this.dgvTelefonia.Size = new System.Drawing.Size(346, 150);
            this.dgvTelefonia.TabIndex = 0;
            // 
            // Telefono
            // 
            this.Telefono.Frozen = true;
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Lugar
            // 
            this.Lugar.Frozen = true;
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            this.Lugar.ReadOnly = true;
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Location = new System.Drawing.Point(128, 41);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(189, 20);
            this.txtbTelefono.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teléfono";
            // 
            // txtbLugar
            // 
            this.txtbLugar.Location = new System.Drawing.Point(128, 67);
            this.txtbLugar.Name = "txtbLugar";
            this.txtbLugar.Size = new System.Drawing.Size(189, 20);
            this.txtbLugar.TabIndex = 1;
            this.txtbLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbLugar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lugar";
            // 
            // tiempollamadaEvento
            // 
            this.tiempollamadaEvento.Tick += new System.EventHandler(this.tiempollamadaEvento_Tick);
            // 
            // tllamada
            // 
            this.tllamada.Frozen = true;
            this.tllamada.HeaderText = "Duración Llamada";
            this.tllamada.Name = "tllamada";
            this.tllamada.ReadOnly = true;
            // 
            // btnColgar
            // 
            this.btnColgar.Location = new System.Drawing.Point(371, 60);
            this.btnColgar.Name = "btnColgar";
            this.btnColgar.Size = new System.Drawing.Size(75, 23);
            this.btnColgar.TabIndex = 3;
            this.btnColgar.Text = "Colgar";
            this.btnColgar.UseVisualStyleBackColor = true;
            this.btnColgar.Click += new System.EventHandler(this.btnColgar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 364);
            this.Controls.Add(this.btnColgar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbLugar);
            this.Controls.Add(this.txtbTelefono);
            this.Controls.Add(this.dgvTelefonia);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTelefonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbLugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tllamada;
        private System.Windows.Forms.Timer tiempollamadaEvento;
        private System.Windows.Forms.Button btnColgar;
    }
}

