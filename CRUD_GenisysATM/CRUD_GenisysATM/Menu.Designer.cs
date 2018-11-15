namespace CRUD_GenisysATM
{
    partial class Menu
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
            this.clienteBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cuentaClienteBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cuentaClientBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.servicioClienteBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.servicioPublicoBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tarjetaCreditoBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.menuLbl = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // clienteBtn
            // 
            this.clienteBtn.Depth = 0;
            this.clienteBtn.Location = new System.Drawing.Point(49, 172);
            this.clienteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clienteBtn.Name = "clienteBtn";
            this.clienteBtn.Primary = true;
            this.clienteBtn.Size = new System.Drawing.Size(292, 39);
            this.clienteBtn.TabIndex = 0;
            this.clienteBtn.Text = " Cliente";
            this.clienteBtn.UseVisualStyleBackColor = true;
            // 
            // cuentaClienteBtn
            // 
            this.cuentaClienteBtn.Depth = 0;
            this.cuentaClienteBtn.Location = new System.Drawing.Point(371, 172);
            this.cuentaClienteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cuentaClienteBtn.Name = "cuentaClienteBtn";
            this.cuentaClienteBtn.Primary = true;
            this.cuentaClienteBtn.Size = new System.Drawing.Size(292, 39);
            this.cuentaClienteBtn.TabIndex = 1;
            this.cuentaClienteBtn.Text = "Cuentas de Clientes";
            this.cuentaClienteBtn.UseVisualStyleBackColor = true;
            // 
            // cuentaClientBtn
            // 
            this.cuentaClientBtn.Depth = 0;
            this.cuentaClientBtn.Location = new System.Drawing.Point(49, 266);
            this.cuentaClientBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cuentaClientBtn.Name = "cuentaClientBtn";
            this.cuentaClientBtn.Primary = true;
            this.cuentaClientBtn.Size = new System.Drawing.Size(292, 39);
            this.cuentaClientBtn.TabIndex = 2;
            this.cuentaClientBtn.Text = "Cuenta del Cliente";
            this.cuentaClientBtn.UseVisualStyleBackColor = true;
            // 
            // servicioClienteBtn
            // 
            this.servicioClienteBtn.Depth = 0;
            this.servicioClienteBtn.Location = new System.Drawing.Point(371, 266);
            this.servicioClienteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.servicioClienteBtn.Name = "servicioClienteBtn";
            this.servicioClienteBtn.Primary = true;
            this.servicioClienteBtn.Size = new System.Drawing.Size(292, 39);
            this.servicioClienteBtn.TabIndex = 3;
            this.servicioClienteBtn.Text = "Servicio al Cliente";
            this.servicioClienteBtn.UseVisualStyleBackColor = true;
            // 
            // servicioPublicoBtn
            // 
            this.servicioPublicoBtn.Depth = 0;
            this.servicioPublicoBtn.Location = new System.Drawing.Point(49, 360);
            this.servicioPublicoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.servicioPublicoBtn.Name = "servicioPublicoBtn";
            this.servicioPublicoBtn.Primary = true;
            this.servicioPublicoBtn.Size = new System.Drawing.Size(292, 39);
            this.servicioPublicoBtn.TabIndex = 4;
            this.servicioPublicoBtn.Text = "Servicio al Público";
            this.servicioPublicoBtn.UseVisualStyleBackColor = true;
            // 
            // tarjetaCreditoBtn
            // 
            this.tarjetaCreditoBtn.Depth = 0;
            this.tarjetaCreditoBtn.Location = new System.Drawing.Point(371, 360);
            this.tarjetaCreditoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.tarjetaCreditoBtn.Name = "tarjetaCreditoBtn";
            this.tarjetaCreditoBtn.Primary = true;
            this.tarjetaCreditoBtn.Size = new System.Drawing.Size(292, 39);
            this.tarjetaCreditoBtn.TabIndex = 5;
            this.tarjetaCreditoBtn.Text = "Tarjeta de Crédito";
            this.tarjetaCreditoBtn.UseVisualStyleBackColor = true;
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Depth = 0;
            this.menuLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.menuLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuLbl.Location = new System.Drawing.Point(292, 99);
            this.menuLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(117, 19);
            this.menuLbl.TabIndex = 6;
            this.menuLbl.Text = "Elija una Opción";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 438);
            this.Controls.Add(this.menuLbl);
            this.Controls.Add(this.tarjetaCreditoBtn);
            this.Controls.Add(this.servicioPublicoBtn);
            this.Controls.Add(this.servicioClienteBtn);
            this.Controls.Add(this.cuentaClientBtn);
            this.Controls.Add(this.cuentaClienteBtn);
            this.Controls.Add(this.clienteBtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton clienteBtn;
        private MaterialSkin.Controls.MaterialRaisedButton cuentaClienteBtn;
        private MaterialSkin.Controls.MaterialRaisedButton cuentaClientBtn;
        private MaterialSkin.Controls.MaterialRaisedButton servicioClienteBtn;
        private MaterialSkin.Controls.MaterialRaisedButton servicioPublicoBtn;
        private MaterialSkin.Controls.MaterialRaisedButton tarjetaCreditoBtn;
        private MaterialSkin.Controls.MaterialLabel menuLbl;
    }
}

