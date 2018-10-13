namespace OutDesk.Controles
{
  partial class uc_CrearArbolTipificacion
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

    #region Código generado por el Diseñador de componentes

    /// <summary> 
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_CrearArbolTipificacion));
      this.btn_SubirArchivo = new System.Windows.Forms.Button();
      this.ofd_Archivo = new System.Windows.Forms.OpenFileDialog();
      this.gbx_CrearArbol = new System.Windows.Forms.GroupBox();
      this.tvw_Arbol = new System.Windows.Forms.TreeView();
      this.btn_Procesar = new System.Windows.Forms.Button();
      this.cbx_Campana = new System.Windows.Forms.ComboBox();
      this.lblCampana = new System.Windows.Forms.Label();
      this.cbx_Cliente = new System.Windows.Forms.ComboBox();
      this.lblCliente = new System.Windows.Forms.Label();
      this.cbx_Formularios = new System.Windows.Forms.ComboBox();
      this.lblFormulario = new System.Windows.Forms.Label();
      this.cbx_Tablas = new System.Windows.Forms.ComboBox();
      this.lblTablaTipificacion = new System.Windows.Forms.Label();
      this.txt_RutaArchivo = new System.Windows.Forms.TextBox();
      this.lblArchivo = new System.Windows.Forms.Label();
      this.lblArbol = new System.Windows.Forms.Label();
      this.btn_Guardar = new System.Windows.Forms.Button();
      this.bgw_Principal = new System.ComponentModel.BackgroundWorker();
      this.gbx_CrearArbol.SuspendLayout();
      this.SuspendLayout();
      // 
      // btn_SubirArchivo
      // 
      this.btn_SubirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_SubirArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btn_SubirArchivo.Image")));
      this.btn_SubirArchivo.Location = new System.Drawing.Point(532, 144);
      this.btn_SubirArchivo.Name = "btn_SubirArchivo";
      this.btn_SubirArchivo.Size = new System.Drawing.Size(68, 42);
      this.btn_SubirArchivo.TabIndex = 0;
      this.btn_SubirArchivo.UseVisualStyleBackColor = true;
      this.btn_SubirArchivo.Click += new System.EventHandler(this.btn_SubirArchivo_Click);
      // 
      // gbx_CrearArbol
      // 
      this.gbx_CrearArbol.Controls.Add(this.tvw_Arbol);
      this.gbx_CrearArbol.Controls.Add(this.btn_Guardar);
      this.gbx_CrearArbol.Controls.Add(this.btn_Procesar);
      this.gbx_CrearArbol.Controls.Add(this.cbx_Campana);
      this.gbx_CrearArbol.Controls.Add(this.lblCampana);
      this.gbx_CrearArbol.Controls.Add(this.cbx_Cliente);
      this.gbx_CrearArbol.Controls.Add(this.lblCliente);
      this.gbx_CrearArbol.Controls.Add(this.cbx_Formularios);
      this.gbx_CrearArbol.Controls.Add(this.lblFormulario);
      this.gbx_CrearArbol.Controls.Add(this.cbx_Tablas);
      this.gbx_CrearArbol.Controls.Add(this.lblTablaTipificacion);
      this.gbx_CrearArbol.Controls.Add(this.txt_RutaArchivo);
      this.gbx_CrearArbol.Controls.Add(this.lblArbol);
      this.gbx_CrearArbol.Controls.Add(this.lblArchivo);
      this.gbx_CrearArbol.Controls.Add(this.btn_SubirArchivo);
      this.gbx_CrearArbol.Location = new System.Drawing.Point(12, 3);
      this.gbx_CrearArbol.Name = "gbx_CrearArbol";
      this.gbx_CrearArbol.Size = new System.Drawing.Size(722, 655);
      this.gbx_CrearArbol.TabIndex = 1;
      this.gbx_CrearArbol.TabStop = false;
      this.gbx_CrearArbol.Text = "Crear Árbol Tipificación";
      // 
      // tvw_Arbol
      // 
      this.tvw_Arbol.Location = new System.Drawing.Point(27, 225);
      this.tvw_Arbol.Name = "tvw_Arbol";
      this.tvw_Arbol.Size = new System.Drawing.Size(678, 358);
      this.tvw_Arbol.TabIndex = 6;
      // 
      // btn_Procesar
      // 
      this.btn_Procesar.BackColor = System.Drawing.Color.SlateGray;
      this.btn_Procesar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
      this.btn_Procesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_Procesar.ForeColor = System.Drawing.Color.White;
      this.btn_Procesar.Location = new System.Drawing.Point(620, 50);
      this.btn_Procesar.Name = "btn_Procesar";
      this.btn_Procesar.Size = new System.Drawing.Size(85, 136);
      this.btn_Procesar.TabIndex = 5;
      this.btn_Procesar.Text = "Procesar";
      this.btn_Procesar.UseVisualStyleBackColor = false;
      this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
      // 
      // cbx_Campana
      // 
      this.cbx_Campana.Enabled = false;
      this.cbx_Campana.FormattingEnabled = true;
      this.cbx_Campana.Location = new System.Drawing.Point(325, 50);
      this.cbx_Campana.Name = "cbx_Campana";
      this.cbx_Campana.Size = new System.Drawing.Size(275, 24);
      this.cbx_Campana.TabIndex = 4;
      // 
      // lblCampana
      // 
      this.lblCampana.AutoSize = true;
      this.lblCampana.Location = new System.Drawing.Point(322, 30);
      this.lblCampana.Name = "lblCampana";
      this.lblCampana.Size = new System.Drawing.Size(72, 17);
      this.lblCampana.TabIndex = 3;
      this.lblCampana.Text = "Campaña:";
      // 
      // cbx_Cliente
      // 
      this.cbx_Cliente.FormattingEnabled = true;
      this.cbx_Cliente.Location = new System.Drawing.Point(27, 50);
      this.cbx_Cliente.Name = "cbx_Cliente";
      this.cbx_Cliente.Size = new System.Drawing.Size(275, 24);
      this.cbx_Cliente.TabIndex = 4;
      this.cbx_Cliente.SelectedIndexChanged += new System.EventHandler(this.cbx_Cliente_SelectedIndexChanged);
      // 
      // lblCliente
      // 
      this.lblCliente.AutoSize = true;
      this.lblCliente.Location = new System.Drawing.Point(24, 30);
      this.lblCliente.Name = "lblCliente";
      this.lblCliente.Size = new System.Drawing.Size(55, 17);
      this.lblCliente.TabIndex = 3;
      this.lblCliente.Text = "Cliente:";
      // 
      // cbx_Formularios
      // 
      this.cbx_Formularios.FormattingEnabled = true;
      this.cbx_Formularios.Location = new System.Drawing.Point(325, 105);
      this.cbx_Formularios.Name = "cbx_Formularios";
      this.cbx_Formularios.Size = new System.Drawing.Size(275, 24);
      this.cbx_Formularios.TabIndex = 4;
      // 
      // lblFormulario
      // 
      this.lblFormulario.AutoSize = true;
      this.lblFormulario.Location = new System.Drawing.Point(322, 85);
      this.lblFormulario.Name = "lblFormulario";
      this.lblFormulario.Size = new System.Drawing.Size(79, 17);
      this.lblFormulario.TabIndex = 3;
      this.lblFormulario.Text = "Formulario:";
      // 
      // cbx_Tablas
      // 
      this.cbx_Tablas.FormattingEnabled = true;
      this.cbx_Tablas.Location = new System.Drawing.Point(27, 105);
      this.cbx_Tablas.Name = "cbx_Tablas";
      this.cbx_Tablas.Size = new System.Drawing.Size(275, 24);
      this.cbx_Tablas.TabIndex = 4;
      // 
      // lblTablaTipificacion
      // 
      this.lblTablaTipificacion.AutoSize = true;
      this.lblTablaTipificacion.Location = new System.Drawing.Point(24, 85);
      this.lblTablaTipificacion.Name = "lblTablaTipificacion";
      this.lblTablaTipificacion.Size = new System.Drawing.Size(44, 17);
      this.lblTablaTipificacion.TabIndex = 3;
      this.lblTablaTipificacion.Text = "Tabla";
      // 
      // txt_RutaArchivo
      // 
      this.txt_RutaArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.txt_RutaArchivo.Location = new System.Drawing.Point(27, 164);
      this.txt_RutaArchivo.Name = "txt_RutaArchivo";
      this.txt_RutaArchivo.ReadOnly = true;
      this.txt_RutaArchivo.Size = new System.Drawing.Size(499, 22);
      this.txt_RutaArchivo.TabIndex = 2;
      // 
      // lblArchivo
      // 
      this.lblArchivo.AutoSize = true;
      this.lblArchivo.Location = new System.Drawing.Point(24, 144);
      this.lblArchivo.Name = "lblArchivo";
      this.lblArchivo.Size = new System.Drawing.Size(59, 17);
      this.lblArchivo.TabIndex = 1;
      this.lblArchivo.Text = "Archivo:";
      // 
      // lblArbol
      // 
      this.lblArbol.AutoSize = true;
      this.lblArbol.Location = new System.Drawing.Point(24, 205);
      this.lblArbol.Name = "lblArbol";
      this.lblArbol.Size = new System.Drawing.Size(45, 17);
      this.lblArbol.TabIndex = 1;
      this.lblArbol.Text = "Árbol:";
      // 
      // btn_Guardar
      // 
      this.btn_Guardar.BackColor = System.Drawing.Color.SlateGray;
      this.btn_Guardar.Enabled = false;
      this.btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
      this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_Guardar.ForeColor = System.Drawing.Color.White;
      this.btn_Guardar.Location = new System.Drawing.Point(27, 600);
      this.btn_Guardar.Name = "btn_Guardar";
      this.btn_Guardar.Size = new System.Drawing.Size(678, 40);
      this.btn_Guardar.TabIndex = 5;
      this.btn_Guardar.Text = "Guardar";
      this.btn_Guardar.UseVisualStyleBackColor = false;
      this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
      // 
      // bgw_Principal
      // 
      this.bgw_Principal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_Procesar_DoWork);
      this.bgw_Principal.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_Procesar_RunWorkerCompleted);
      // 
      // uc_CrearArbolTipificacion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gbx_CrearArbol);
      this.Name = "uc_CrearArbolTipificacion";
      this.Size = new System.Drawing.Size(755, 673);
      this.gbx_CrearArbol.ResumeLayout(false);
      this.gbx_CrearArbol.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_SubirArchivo;
    private System.Windows.Forms.OpenFileDialog ofd_Archivo;
    private System.Windows.Forms.GroupBox gbx_CrearArbol;
    private System.Windows.Forms.TextBox txt_RutaArchivo;
    private System.Windows.Forms.Label lblArchivo;
    private System.Windows.Forms.ComboBox cbx_Tablas;
    private System.Windows.Forms.Label lblTablaTipificacion;
    private System.Windows.Forms.ComboBox cbx_Campana;
    private System.Windows.Forms.Label lblCampana;
    private System.Windows.Forms.ComboBox cbx_Cliente;
    private System.Windows.Forms.Label lblCliente;
    private System.Windows.Forms.ComboBox cbx_Formularios;
    private System.Windows.Forms.Label lblFormulario;
    private System.Windows.Forms.Button btn_Procesar;
    private System.Windows.Forms.TreeView tvw_Arbol;
    private System.Windows.Forms.Label lblArbol;
    private System.Windows.Forms.Button btn_Guardar;
    private System.ComponentModel.BackgroundWorker bgw_Principal;
  }
}
