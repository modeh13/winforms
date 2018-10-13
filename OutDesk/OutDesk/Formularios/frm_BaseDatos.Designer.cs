namespace OutDesk.Formularios
{
  partial class frm_BaseDatos
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
      this.gbx_Conexiones = new System.Windows.Forms.GroupBox();
      this.dgv_BaseDatos = new System.Windows.Forms.DataGridView();
      this.btn_Seleccionar = new System.Windows.Forms.Button();
      this.colServidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colBaseDatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gbx_Conexiones.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_BaseDatos)).BeginInit();
      this.SuspendLayout();
      // 
      // gbx_Conexiones
      // 
      this.gbx_Conexiones.Controls.Add(this.btn_Seleccionar);
      this.gbx_Conexiones.Controls.Add(this.dgv_BaseDatos);
      this.gbx_Conexiones.Location = new System.Drawing.Point(12, 12);
      this.gbx_Conexiones.Name = "gbx_Conexiones";
      this.gbx_Conexiones.Size = new System.Drawing.Size(545, 322);
      this.gbx_Conexiones.TabIndex = 0;
      this.gbx_Conexiones.TabStop = false;
      this.gbx_Conexiones.Text = "Seleccionar";
      // 
      // dgv_BaseDatos
      // 
      this.dgv_BaseDatos.AllowUserToAddRows = false;
      this.dgv_BaseDatos.AllowUserToDeleteRows = false;
      this.dgv_BaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_BaseDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServidor,
            this.colBaseDatos});
      this.dgv_BaseDatos.Location = new System.Drawing.Point(15, 30);
      this.dgv_BaseDatos.MultiSelect = false;
      this.dgv_BaseDatos.Name = "dgv_BaseDatos";
      this.dgv_BaseDatos.RowHeadersVisible = false;
      this.dgv_BaseDatos.RowTemplate.Height = 24;
      this.dgv_BaseDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_BaseDatos.Size = new System.Drawing.Size(510, 220);
      this.dgv_BaseDatos.TabIndex = 0;
      // 
      // btn_Seleccionar
      // 
      this.btn_Seleccionar.BackColor = System.Drawing.Color.SlateGray;
      this.btn_Seleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_Seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
      this.btn_Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_Seleccionar.ForeColor = System.Drawing.Color.White;
      this.btn_Seleccionar.Location = new System.Drawing.Point(15, 266);
      this.btn_Seleccionar.Name = "btn_Seleccionar";
      this.btn_Seleccionar.Size = new System.Drawing.Size(510, 40);
      this.btn_Seleccionar.TabIndex = 1;
      this.btn_Seleccionar.Text = "Aceptar";
      this.btn_Seleccionar.UseVisualStyleBackColor = false;
      this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
      // 
      // colServidor
      // 
      this.colServidor.DataPropertyName = "Servidor";
      this.colServidor.HeaderText = "Servidor";
      this.colServidor.Name = "colServidor";
      this.colServidor.ReadOnly = true;
      this.colServidor.Width = 200;
      // 
      // colBaseDatos
      // 
      this.colBaseDatos.DataPropertyName = "Nombre";
      this.colBaseDatos.HeaderText = "Base de Datos";
      this.colBaseDatos.Name = "colBaseDatos";
      this.colBaseDatos.ReadOnly = true;
      this.colBaseDatos.Width = 200;
      // 
      // frm_BaseDatos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(576, 346);
      this.Controls.Add(this.gbx_Conexiones);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frm_BaseDatos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Base de Datos";
      this.Load += new System.EventHandler(this.frm_BaseDatos_Load);
      this.gbx_Conexiones.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_BaseDatos)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gbx_Conexiones;
    private System.Windows.Forms.Button btn_Seleccionar;
    private System.Windows.Forms.DataGridView dgv_BaseDatos;
    private System.Windows.Forms.DataGridViewTextBoxColumn colServidor;
    private System.Windows.Forms.DataGridViewTextBoxColumn colBaseDatos;
  }
}