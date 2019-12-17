namespace SupermercadoNosis
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
            this.btn_AbrirCaja = new System.Windows.Forms.Button();
            this.btn_CerrarCaja = new System.Windows.Forms.Button();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.btn_AtenderCliente = new System.Windows.Forms.Button();
            this.dt_Cajas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Cajas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AbrirCaja
            // 
            this.btn_AbrirCaja.AccessibleName = "Abrir Caja";
            this.btn_AbrirCaja.Location = new System.Drawing.Point(12, 12);
            this.btn_AbrirCaja.Name = "btn_AbrirCaja";
            this.btn_AbrirCaja.Size = new System.Drawing.Size(75, 23);
            this.btn_AbrirCaja.TabIndex = 0;
            this.btn_AbrirCaja.Text = "Abrir Caja";
            this.btn_AbrirCaja.UseVisualStyleBackColor = true;
            this.btn_AbrirCaja.Click += new System.EventHandler(this.btn_AbrirCaja_Click);
            // 
            // btn_CerrarCaja
            // 
            this.btn_CerrarCaja.Location = new System.Drawing.Point(93, 12);
            this.btn_CerrarCaja.Name = "btn_CerrarCaja";
            this.btn_CerrarCaja.Size = new System.Drawing.Size(75, 23);
            this.btn_CerrarCaja.TabIndex = 1;
            this.btn_CerrarCaja.Text = "Cerrar Caja";
            this.btn_CerrarCaja.UseVisualStyleBackColor = true;
            this.btn_CerrarCaja.Click += new System.EventHandler(this.btn_CerrarCaja_Click);
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.Location = new System.Drawing.Point(174, 12);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(92, 23);
            this.btn_AgregarCliente.TabIndex = 2;
            this.btn_AgregarCliente.Text = "Agregar Cliente";
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // btn_AtenderCliente
            // 
            this.btn_AtenderCliente.Location = new System.Drawing.Point(272, 12);
            this.btn_AtenderCliente.Name = "btn_AtenderCliente";
            this.btn_AtenderCliente.Size = new System.Drawing.Size(90, 23);
            this.btn_AtenderCliente.TabIndex = 3;
            this.btn_AtenderCliente.Text = "Atender Cliente";
            this.btn_AtenderCliente.UseVisualStyleBackColor = true;
            this.btn_AtenderCliente.Click += new System.EventHandler(this.btn_AtenderCliente_Click);
            // 
            // dt_Cajas
            // 
            this.dt_Cajas.AllowUserToAddRows = false;
            this.dt_Cajas.AllowUserToDeleteRows = false;
            this.dt_Cajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Cajas.Location = new System.Drawing.Point(12, 41);
            this.dt_Cajas.MultiSelect = false;
            this.dt_Cajas.Name = "dt_Cajas";
            this.dt_Cajas.ReadOnly = true;
            this.dt_Cajas.Size = new System.Drawing.Size(558, 346);
            this.dt_Cajas.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 399);
            this.Controls.Add(this.dt_Cajas);
            this.Controls.Add(this.btn_AtenderCliente);
            this.Controls.Add(this.btn_AgregarCliente);
            this.Controls.Add(this.btn_CerrarCaja);
            this.Controls.Add(this.btn_AbrirCaja);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dt_Cajas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AbrirCaja;
        private System.Windows.Forms.Button btn_CerrarCaja;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.Button btn_AtenderCliente;
        private System.Windows.Forms.DataGridView dt_Cajas;
    }
}

