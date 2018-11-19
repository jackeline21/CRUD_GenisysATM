namespace CRUD_GenisysATM
{
    partial class Menu1
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
            this.menuLbl = new MaterialSkin.Controls.MaterialLabel();
            this.tarjetaCreditoBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.servicioPublicoBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.servicioClienteBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cuentaClientBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cuentaClienteBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.clienteBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Depth = 0;
            this.menuLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.menuLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuLbl.Location = new System.Drawing.Point(336, 75);
            this.menuLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(117, 19);
            this.menuLbl.TabIndex = 13;
            this.menuLbl.Text = "Elija una Opción";
            // 
            // tarjetaCreditoBtn
            // 
            this.tarjetaCreditoBtn.Depth = 0;
            this.tarjetaCreditoBtn.Location = new System.Drawing.Point(415, 336);
            this.tarjetaCreditoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.tarjetaCreditoBtn.Name = "tarjetaCreditoBtn";
            this.tarjetaCreditoBtn.Primary = true;
            this.tarjetaCreditoBtn.Size = new System.Drawing.Size(292, 39);
            this.tarjetaCreditoBtn.TabIndex = 12;
            this.tarjetaCreditoBtn.Text = "Tarjeta de Crédito";
            this.tarjetaCreditoBtn.UseVisualStyleBackColor = true;
            this.tarjetaCreditoBtn.Click += new System.EventHandler(this.tarjetaCreditoBtn_Click);
            // 
            // servicioPublicoBtn
            // 
            this.servicioPublicoBtn.Depth = 0;
            this.servicioPublicoBtn.Location = new System.Drawing.Point(93, 336);
            this.servicioPublicoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.servicioPublicoBtn.Name = "servicioPublicoBtn";
            this.servicioPublicoBtn.Primary = true;
            this.servicioPublicoBtn.Size = new System.Drawing.Size(292, 39);
            this.servicioPublicoBtn.TabIndex = 11;
            this.servicioPublicoBtn.Text = "Servicio al Público";
            this.servicioPublicoBtn.UseVisualStyleBackColor = true;
            this.servicioPublicoBtn.Click += new System.EventHandler(this.servicioPublicoBtn_Click);
            // 
            // servicioClienteBtn
            // 
            this.servicioClienteBtn.Depth = 0;
            this.servicioClienteBtn.Location = new System.Drawing.Point(415, 242);
            this.servicioClienteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.servicioClienteBtn.Name = "servicioClienteBtn";
            this.servicioClienteBtn.Primary = true;
            this.servicioClienteBtn.Size = new System.Drawing.Size(292, 39);
            this.servicioClienteBtn.TabIndex = 10;
            this.servicioClienteBtn.Text = "Servicio al Cliente";
            this.servicioClienteBtn.UseVisualStyleBackColor = true;
            this.servicioClienteBtn.Click += new System.EventHandler(this.servicioClienteBtn_Click);
            // 
            // cuentaClientBtn
            // 
            this.cuentaClientBtn.Depth = 0;
            this.cuentaClientBtn.Location = new System.Drawing.Point(93, 242);
            this.cuentaClientBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cuentaClientBtn.Name = "cuentaClientBtn";
            this.cuentaClientBtn.Primary = true;
            this.cuentaClientBtn.Size = new System.Drawing.Size(292, 39);
            this.cuentaClientBtn.TabIndex = 9;
            this.cuentaClientBtn.Text = "Cuenta del Cliente";
            this.cuentaClientBtn.UseVisualStyleBackColor = true;
            // 
            // cuentaClienteBtn
            // 
            this.cuentaClienteBtn.Depth = 0;
            this.cuentaClienteBtn.Location = new System.Drawing.Point(415, 148);
            this.cuentaClienteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cuentaClienteBtn.Name = "cuentaClienteBtn";
            this.cuentaClienteBtn.Primary = true;
            this.cuentaClienteBtn.Size = new System.Drawing.Size(292, 39);
            this.cuentaClienteBtn.TabIndex = 8;
            this.cuentaClienteBtn.Text = "Cuentas de Clientes";
            this.cuentaClienteBtn.UseVisualStyleBackColor = true;
            this.cuentaClienteBtn.Click += new System.EventHandler(this.cuentaClienteBtn_Click);
            // 
            // clienteBtn
            // 
            this.clienteBtn.Depth = 0;
            this.clienteBtn.Location = new System.Drawing.Point(93, 148);
            this.clienteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clienteBtn.Name = "clienteBtn";
            this.clienteBtn.Primary = true;
            this.clienteBtn.Size = new System.Drawing.Size(292, 39);
            this.clienteBtn.TabIndex = 7;
            this.clienteBtn.Text = " Cliente";
            this.clienteBtn.UseVisualStyleBackColor = true;
            this.clienteBtn.Click += new System.EventHandler(this.clienteBtn_Click);
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuLbl);
            this.Controls.Add(this.tarjetaCreditoBtn);
            this.Controls.Add(this.servicioPublicoBtn);
            this.Controls.Add(this.servicioClienteBtn);
            this.Controls.Add(this.cuentaClientBtn);
            this.Controls.Add(this.cuentaClienteBtn);
            this.Controls.Add(this.clienteBtn);
            this.Name = "Menu1";
            this.Text = "Menu1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel menuLbl;
        private MaterialSkin.Controls.MaterialRaisedButton tarjetaCreditoBtn;
        private MaterialSkin.Controls.MaterialRaisedButton servicioPublicoBtn;
        private MaterialSkin.Controls.MaterialRaisedButton servicioClienteBtn;
        private MaterialSkin.Controls.MaterialRaisedButton cuentaClientBtn;
        private MaterialSkin.Controls.MaterialRaisedButton cuentaClienteBtn;
        private MaterialSkin.Controls.MaterialRaisedButton clienteBtn;
    }
}