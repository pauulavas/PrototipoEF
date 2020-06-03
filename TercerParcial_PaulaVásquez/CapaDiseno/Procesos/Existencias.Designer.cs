namespace CapaDiseno.Procesos
{
    partial class Existencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Existencias));
            this.gpb_datos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_BuscarTipoTransporte = new System.Windows.Forms.Button();
            this.Txt_3 = new System.Windows.Forms.TextBox();
            this.Txt_2 = new System.Windows.Forms.TextBox();
            this.Txt_1 = new System.Windows.Forms.TextBox();
            this.Lbl_chasis = new System.Windows.Forms.Label();
            this.Lbl_placa = new System.Windows.Forms.Label();
            this.Lbl_codigotransporte = new System.Windows.Forms.Label();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.gpb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_datos
            // 
            this.gpb_datos.Controls.Add(this.button1);
            this.gpb_datos.Controls.Add(this.Btn_BuscarTipoTransporte);
            this.gpb_datos.Controls.Add(this.Txt_3);
            this.gpb_datos.Controls.Add(this.Txt_2);
            this.gpb_datos.Controls.Add(this.Txt_1);
            this.gpb_datos.Controls.Add(this.Lbl_chasis);
            this.gpb_datos.Controls.Add(this.Lbl_placa);
            this.gpb_datos.Controls.Add(this.Lbl_codigotransporte);
            this.gpb_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos.Location = new System.Drawing.Point(49, 153);
            this.gpb_datos.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_datos.Name = "gpb_datos";
            this.gpb_datos.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_datos.Size = new System.Drawing.Size(916, 200);
            this.gpb_datos.TabIndex = 114;
            this.gpb_datos.TabStop = false;
            this.gpb_datos.Text = "Datos";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(392, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 47);
            this.button1.TabIndex = 37;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_BuscarTipoTransporte
            // 
            this.Btn_BuscarTipoTransporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BuscarTipoTransporte.Image")));
            this.Btn_BuscarTipoTransporte.Location = new System.Drawing.Point(392, 33);
            this.Btn_BuscarTipoTransporte.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BuscarTipoTransporte.Name = "Btn_BuscarTipoTransporte";
            this.Btn_BuscarTipoTransporte.Size = new System.Drawing.Size(41, 47);
            this.Btn_BuscarTipoTransporte.TabIndex = 36;
            this.Btn_BuscarTipoTransporte.UseVisualStyleBackColor = true;
            this.Btn_BuscarTipoTransporte.Click += new System.EventHandler(this.Btn_BuscarTipoTransporte_Click);
            // 
            // Txt_3
            // 
            this.Txt_3.Location = new System.Drawing.Point(680, 86);
            this.Txt_3.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_3.Name = "Txt_3";
            this.Txt_3.Size = new System.Drawing.Size(169, 23);
            this.Txt_3.TabIndex = 10;
            // 
            // Txt_2
            // 
            this.Txt_2.Location = new System.Drawing.Point(217, 123);
            this.Txt_2.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_2.Name = "Txt_2";
            this.Txt_2.Size = new System.Drawing.Size(169, 23);
            this.Txt_2.TabIndex = 9;
            // 
            // Txt_1
            // 
            this.Txt_1.Location = new System.Drawing.Point(217, 45);
            this.Txt_1.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_1.Name = "Txt_1";
            this.Txt_1.Size = new System.Drawing.Size(169, 23);
            this.Txt_1.TabIndex = 8;
            // 
            // Lbl_chasis
            // 
            this.Lbl_chasis.AutoSize = true;
            this.Lbl_chasis.Location = new System.Drawing.Point(530, 88);
            this.Lbl_chasis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_chasis.Name = "Lbl_chasis";
            this.Lbl_chasis.Size = new System.Drawing.Size(111, 17);
            this.Lbl_chasis.TabIndex = 2;
            this.Lbl_chasis.Text = "Saldo Existencia";
            // 
            // Lbl_placa
            // 
            this.Lbl_placa.AutoSize = true;
            this.Lbl_placa.Location = new System.Drawing.Point(67, 129);
            this.Lbl_placa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_placa.Name = "Lbl_placa";
            this.Lbl_placa.Size = new System.Drawing.Size(113, 17);
            this.Lbl_placa.TabIndex = 1;
            this.Lbl_placa.Text = "Codigo Producto";
            // 
            // Lbl_codigotransporte
            // 
            this.Lbl_codigotransporte.AutoSize = true;
            this.Lbl_codigotransporte.Location = new System.Drawing.Point(67, 50);
            this.Lbl_codigotransporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_codigotransporte.Name = "Lbl_codigotransporte";
            this.Lbl_codigotransporte.Size = new System.Drawing.Size(105, 17);
            this.Lbl_codigotransporte.TabIndex = 0;
            this.Lbl_codigotransporte.Text = "Codigo Bodega";
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.Teal;
            this.Btn_consultar.FlatAppearance.BorderSize = 3;
            this.Btn_consultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultar.Location = new System.Drawing.Point(582, 31);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(140, 89);
            this.Btn_consultar.TabIndex = 113;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.Teal;
            this.Btn_guardar.FlatAppearance.BorderSize = 3;
            this.Btn_guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_guardar.Location = new System.Drawing.Point(498, 31);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(86, 89);
            this.Btn_guardar.TabIndex = 111;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.Teal;
            this.Btn_editar.FlatAppearance.BorderSize = 3;
            this.Btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_editar.Location = new System.Drawing.Point(414, 31);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(86, 89);
            this.Btn_editar.TabIndex = 110;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.Teal;
            this.Btn_ingresar.FlatAppearance.BorderSize = 3;
            this.Btn_ingresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ingresar.Location = new System.Drawing.Point(330, 31);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(86, 89);
            this.Btn_ingresar.TabIndex = 109;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Existencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.gpb_datos);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_ingresar);
            this.Name = "Existencias";
            this.Text = "Existencias";
            this.gpb_datos.ResumeLayout(false);
            this.gpb_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_datos;
        private System.Windows.Forms.Button Btn_BuscarTipoTransporte;
        private System.Windows.Forms.TextBox Txt_3;
        private System.Windows.Forms.TextBox Txt_2;
        private System.Windows.Forms.TextBox Txt_1;
        private System.Windows.Forms.Label Lbl_chasis;
        private System.Windows.Forms.Label Lbl_placa;
        private System.Windows.Forms.Label Lbl_codigotransporte;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button button1;
    }
}