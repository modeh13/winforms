namespace OutDesk
{
  partial class frm_Principal
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.tsm_BaseDatos = new System.Windows.Forms.ToolStripMenuItem();
      this.mesaDeAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tsm_CrearArbolTipificacion = new System.Windows.Forms.ToolStripMenuItem();
      this.pnl_Contenedor = new System.Windows.Forms.Panel();
      this.bgw_Principal = new System.ComponentModel.BackgroundWorker();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
      this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_BaseDatos,
            this.mesaDeAyudaToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(876, 28);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "menuStrip1";
      // 
      // tsm_BaseDatos
      // 
      this.tsm_BaseDatos.Image = ((System.Drawing.Image)(resources.GetObject("tsm_BaseDatos.Image")));
      this.tsm_BaseDatos.Name = "tsm_BaseDatos";
      this.tsm_BaseDatos.Size = new System.Drawing.Size(32, 24);
      this.tsm_BaseDatos.Click += new System.EventHandler(this.tsm_BaseDatos_Click);
      // 
      // mesaDeAyudaToolStripMenuItem
      // 
      this.mesaDeAyudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_CrearArbolTipificacion});
      this.mesaDeAyudaToolStripMenuItem.Name = "mesaDeAyudaToolStripMenuItem";
      this.mesaDeAyudaToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
      this.mesaDeAyudaToolStripMenuItem.Text = "Mesa de Ayuda";
      // 
      // tsm_CrearArbolTipificacion
      // 
      this.tsm_CrearArbolTipificacion.Name = "tsm_CrearArbolTipificacion";
      this.tsm_CrearArbolTipificacion.Size = new System.Drawing.Size(262, 26);
      this.tsm_CrearArbolTipificacion.Text = "Crear Árbol de Tipificación";
      this.tsm_CrearArbolTipificacion.Click += new System.EventHandler(this.tsm_CrearArbolTipificacion_Click);
      // 
      // pnl_Contenedor
      // 
      this.pnl_Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnl_Contenedor.Location = new System.Drawing.Point(0, 31);
      this.pnl_Contenedor.Name = "pnl_Contenedor";
      this.pnl_Contenedor.Size = new System.Drawing.Size(876, 455);
      this.pnl_Contenedor.TabIndex = 1;
      // 
      // bgw_Principal
      // 
      this.bgw_Principal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_Principal_DoWork);
      // 
      // frm_Principal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(876, 487);
      this.Controls.Add(this.pnl_Contenedor);
      this.Controls.Add(this.menuStrip);
      this.MainMenuStrip = this.menuStrip;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frm_Principal";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Outsourcing - Desk";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frm_Principal_Load);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem mesaDeAyudaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tsm_CrearArbolTipificacion;
    private System.Windows.Forms.Panel pnl_Contenedor;
    private System.ComponentModel.BackgroundWorker bgw_Principal;
    private System.Windows.Forms.ToolStripMenuItem tsm_BaseDatos;
  }
}

