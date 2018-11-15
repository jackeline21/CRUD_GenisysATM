namespace CRUD_GenisysATM
{
    partial class Cliente
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
            this.nombreTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nombresLb = new MaterialSkin.Controls.MaterialLabel();
            this.apellidosLb = new MaterialSkin.Controls.MaterialLabel();
            this.identidadLb = new MaterialSkin.Controls.MaterialLabel();
            this.direccionLb = new MaterialSkin.Controls.MaterialLabel();
            this.celularLb = new MaterialSkin.Controls.MaterialLabel();
            this.telefonoLb = new MaterialSkin.Controls.MaterialLabel();
            this.apellidosTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.identidadTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.direccionTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.telefonoTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CelularTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.clienteDgv = new System.Windows.Forms.DataGridView();
            this.listarBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.actualizarBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buscarBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.crearBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.eliminarBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreTxt
            // 
            this.nombreTxt.Depth = 0;
            this.nombreTxt.Hint = "";
            this.nombreTxt.Location = new System.Drawing.Point(105, 78);
            this.nombreTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.PasswordChar = '\0';
            this.nombreTxt.SelectedText = "";
            this.nombreTxt.SelectionLength = 0;
            this.nombreTxt.SelectionStart = 0;
            this.nombreTxt.Size = new System.Drawing.Size(211, 23);
            this.nombreTxt.TabIndex = 0;
            this.nombreTxt.UseSystemPasswordChar = false;
            // 
            // nombresLb
            // 
            this.nombresLb.AutoSize = true;
            this.nombresLb.Depth = 0;
            this.nombresLb.Font = new System.Drawing.Font("Roboto", 11F);
            this.nombresLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nombresLb.Location = new System.Drawing.Point(11, 82);
            this.nombresLb.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombresLb.Name = "nombresLb";
            this.nombresLb.Size = new System.Drawing.Size(71, 19);
            this.nombresLb.TabIndex = 1;
            this.nombresLb.Text = "Nombres";
            // 
            // apellidosLb
            // 
            this.apellidosLb.AutoSize = true;
            this.apellidosLb.Depth = 0;
            this.apellidosLb.Font = new System.Drawing.Font("Roboto", 11F);
            this.apellidosLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apellidosLb.Location = new System.Drawing.Point(13, 128);
            this.apellidosLb.MouseState = MaterialSkin.MouseState.HOVER;
            this.apellidosLb.Name = "apellidosLb";
            this.apellidosLb.Size = new System.Drawing.Size(72, 19);
            this.apellidosLb.TabIndex = 2;
            this.apellidosLb.Text = "Apellidos";
            // 
            // identidadLb
            // 
            this.identidadLb.AutoSize = true;
            this.identidadLb.Depth = 0;
            this.identidadLb.Font = new System.Drawing.Font("Roboto", 11F);
            this.identidadLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.identidadLb.Location = new System.Drawing.Point(13, 173);
            this.identidadLb.MouseState = MaterialSkin.MouseState.HOVER;
            this.identidadLb.Name = "identidadLb";
            this.identidadLb.Size = new System.Drawing.Size(70, 19);
            this.identidadLb.TabIndex = 3;
            this.identidadLb.Text = "Identidad";
            // 
            // direccionLb
            // 
            this.direccionLb.AutoSize = true;
            this.direccionLb.Depth = 0;
            this.direccionLb.Font = new System.Drawing.Font("Roboto", 11F);
            this.direccionLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.direccionLb.Location = new System.Drawing.Point(9, 224);
            this.direccionLb.MouseState = MaterialSkin.MouseState.HOVER;
            this.direccionLb.Name = "direccionLb";
            this.direccionLb.Size = new System.Drawing.Size(73, 19);
            this.direccionLb.TabIndex = 4;
            this.direccionLb.Text = "Dirección";
            // 
            // celularLb
            // 
            this.celularLb.AutoSize = true;
            this.celularLb.Depth = 0;
            this.celularLb.Font = new System.Drawing.Font("Roboto", 11F);
            this.celularLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.celularLb.Location = new System.Drawing.Point(11, 331);
            this.celularLb.MouseState = MaterialSkin.MouseState.HOVER;
            this.celularLb.Name = "celularLb";
            this.celularLb.Size = new System.Drawing.Size(56, 19);
            this.celularLb.TabIndex = 5;
            this.celularLb.Text = "Celular";
            // 
            // telefonoLb
            // 
            this.telefonoLb.AutoSize = true;
            this.telefonoLb.Depth = 0;
            this.telefonoLb.Font = new System.Drawing.Font("Roboto", 11F);
            this.telefonoLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.telefonoLb.Location = new System.Drawing.Point(13, 276);
            this.telefonoLb.MouseState = MaterialSkin.MouseState.HOVER;
            this.telefonoLb.Name = "telefonoLb";
            this.telefonoLb.Size = new System.Drawing.Size(69, 19);
            this.telefonoLb.TabIndex = 6;
            this.telefonoLb.Text = "Teléfono";
            // 
            // apellidosTxt
            // 
            this.apellidosTxt.Depth = 0;
            this.apellidosTxt.Hint = "";
            this.apellidosTxt.Location = new System.Drawing.Point(105, 124);
            this.apellidosTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.apellidosTxt.Name = "apellidosTxt";
            this.apellidosTxt.PasswordChar = '\0';
            this.apellidosTxt.SelectedText = "";
            this.apellidosTxt.SelectionLength = 0;
            this.apellidosTxt.SelectionStart = 0;
            this.apellidosTxt.Size = new System.Drawing.Size(211, 23);
            this.apellidosTxt.TabIndex = 7;
            this.apellidosTxt.UseSystemPasswordChar = false;
            // 
            // identidadTxt
            // 
            this.identidadTxt.Depth = 0;
            this.identidadTxt.Hint = "";
            this.identidadTxt.Location = new System.Drawing.Point(105, 169);
            this.identidadTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.identidadTxt.Name = "identidadTxt";
            this.identidadTxt.PasswordChar = '\0';
            this.identidadTxt.SelectedText = "";
            this.identidadTxt.SelectionLength = 0;
            this.identidadTxt.SelectionStart = 0;
            this.identidadTxt.Size = new System.Drawing.Size(211, 23);
            this.identidadTxt.TabIndex = 8;
            this.identidadTxt.UseSystemPasswordChar = false;
            // 
            // direccionTxt
            // 
            this.direccionTxt.Depth = 0;
            this.direccionTxt.Hint = "";
            this.direccionTxt.Location = new System.Drawing.Point(105, 220);
            this.direccionTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.PasswordChar = '\0';
            this.direccionTxt.SelectedText = "";
            this.direccionTxt.SelectionLength = 0;
            this.direccionTxt.SelectionStart = 0;
            this.direccionTxt.Size = new System.Drawing.Size(211, 23);
            this.direccionTxt.TabIndex = 9;
            this.direccionTxt.UseSystemPasswordChar = false;
            // 
            // telefonoTxt
            // 
            this.telefonoTxt.Depth = 0;
            this.telefonoTxt.Hint = "";
            this.telefonoTxt.Location = new System.Drawing.Point(105, 272);
            this.telefonoTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.telefonoTxt.Name = "telefonoTxt";
            this.telefonoTxt.PasswordChar = '\0';
            this.telefonoTxt.SelectedText = "";
            this.telefonoTxt.SelectionLength = 0;
            this.telefonoTxt.SelectionStart = 0;
            this.telefonoTxt.Size = new System.Drawing.Size(211, 23);
            this.telefonoTxt.TabIndex = 10;
            this.telefonoTxt.UseSystemPasswordChar = false;
            // 
            // CelularTxt
            // 
            this.CelularTxt.Depth = 0;
            this.CelularTxt.Hint = "";
            this.CelularTxt.Location = new System.Drawing.Point(105, 327);
            this.CelularTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.CelularTxt.Name = "CelularTxt";
            this.CelularTxt.PasswordChar = '\0';
            this.CelularTxt.SelectedText = "";
            this.CelularTxt.SelectionLength = 0;
            this.CelularTxt.SelectionStart = 0;
            this.CelularTxt.Size = new System.Drawing.Size(211, 23);
            this.CelularTxt.TabIndex = 11;
            this.CelularTxt.UseSystemPasswordChar = false;
            // 
            // clienteDgv
            // 
            this.clienteDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDgv.Location = new System.Drawing.Point(359, 78);
            this.clienteDgv.Name = "clienteDgv";
            this.clienteDgv.Size = new System.Drawing.Size(390, 272);
            this.clienteDgv.TabIndex = 12;
            // 
            // listarBtn
            // 
            this.listarBtn.Depth = 0;
            this.listarBtn.Location = new System.Drawing.Point(190, 396);
            this.listarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.listarBtn.Name = "listarBtn";
            this.listarBtn.Primary = true;
            this.listarBtn.Size = new System.Drawing.Size(104, 23);
            this.listarBtn.TabIndex = 13;
            this.listarBtn.Text = "Listar";
            this.listarBtn.UseVisualStyleBackColor = true;
            // 
            // actualizarBtn
            // 
            this.actualizarBtn.Depth = 0;
            this.actualizarBtn.Location = new System.Drawing.Point(495, 396);
            this.actualizarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.actualizarBtn.Name = "actualizarBtn";
            this.actualizarBtn.Primary = true;
            this.actualizarBtn.Size = new System.Drawing.Size(104, 23);
            this.actualizarBtn.TabIndex = 14;
            this.actualizarBtn.Text = "Actualizar";
            this.actualizarBtn.UseVisualStyleBackColor = true;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Depth = 0;
            this.buscarBtn.Location = new System.Drawing.Point(341, 396);
            this.buscarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Primary = true;
            this.buscarBtn.Size = new System.Drawing.Size(104, 23);
            this.buscarBtn.TabIndex = 15;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            // 
            // crearBtn
            // 
            this.crearBtn.Depth = 0;
            this.crearBtn.Location = new System.Drawing.Point(30, 396);
            this.crearBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.crearBtn.Name = "crearBtn";
            this.crearBtn.Primary = true;
            this.crearBtn.Size = new System.Drawing.Size(104, 23);
            this.crearBtn.TabIndex = 16;
            this.crearBtn.Text = "Crear";
            this.crearBtn.UseVisualStyleBackColor = true;
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Depth = 0;
            this.eliminarBtn.Location = new System.Drawing.Point(660, 396);
            this.eliminarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Primary = true;
            this.eliminarBtn.Size = new System.Drawing.Size(104, 23);
            this.eliminarBtn.TabIndex = 17;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.crearBtn);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.actualizarBtn);
            this.Controls.Add(this.listarBtn);
            this.Controls.Add(this.clienteDgv);
            this.Controls.Add(this.CelularTxt);
            this.Controls.Add(this.telefonoTxt);
            this.Controls.Add(this.direccionTxt);
            this.Controls.Add(this.identidadTxt);
            this.Controls.Add(this.apellidosTxt);
            this.Controls.Add(this.telefonoLb);
            this.Controls.Add(this.celularLb);
            this.Controls.Add(this.direccionLb);
            this.Controls.Add(this.identidadLb);
            this.Controls.Add(this.apellidosLb);
            this.Controls.Add(this.nombresLb);
            this.Controls.Add(this.nombreTxt);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.clienteDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField nombreTxt;
        private MaterialSkin.Controls.MaterialLabel nombresLb;
        private MaterialSkin.Controls.MaterialLabel apellidosLb;
        private MaterialSkin.Controls.MaterialLabel identidadLb;
        private MaterialSkin.Controls.MaterialLabel direccionLb;
        private MaterialSkin.Controls.MaterialLabel celularLb;
        private MaterialSkin.Controls.MaterialLabel telefonoLb;
        private MaterialSkin.Controls.MaterialSingleLineTextField apellidosTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField identidadTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField direccionTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField telefonoTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField CelularTxt;
        private System.Windows.Forms.DataGridView clienteDgv;
        private MaterialSkin.Controls.MaterialRaisedButton listarBtn;
        private MaterialSkin.Controls.MaterialRaisedButton actualizarBtn;
        private MaterialSkin.Controls.MaterialRaisedButton buscarBtn;
        private MaterialSkin.Controls.MaterialRaisedButton crearBtn;
        private MaterialSkin.Controls.MaterialRaisedButton eliminarBtn;
    }
}