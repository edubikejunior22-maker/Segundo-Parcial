namespace SegundoPARcialpedro
{
    partial class lblDescuento
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtCompleto = new System.Windows.Forms.RadioButton();
            this.rbtBasico = new System.Windows.Forms.RadioButton();
            this.entr = new System.Windows.Forms.GroupBox();
            this.rbtDomicilio = new System.Windows.Forms.RadioButton();
            this.rbtSucursal = new System.Windows.Forms.RadioButton();
            this.chkGps = new System.Windows.Forms.CheckBox();
            this.chkCorporativo = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lstAlquileres = new System.Windows.Forms.ListBox();
            this.Subtotal = new System.Windows.Forms.Label();
            this.Domicilio = new System.Windows.Forms.Label();
            this.Descuentos = new System.Windows.Forms.Label();
            this.Itbis = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblItbis = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.entr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(75, 32);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(75, 101);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(53, 20);
            this.lblSalida.TabIndex = 2;
            this.lblSalida.Text = "Salida";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(63, 163);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(70, 20);
            this.lblVehiculo.TabIndex = 3;
            this.lblVehiculo.Text = "Vehiculo";
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(75, 232);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(49, 20);
            this.lblTarifa.TabIndex = 4;
            this.lblTarifa.Text = "Tarifa";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(83, 287);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(41, 20);
            this.lblDias.TabIndex = 5;
            this.lblDias.Text = "Dias";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtCompleto);
            this.groupBox1.Controls.Add(this.rbtBasico);
            this.groupBox1.Location = new System.Drawing.Point(67, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seguro";
            // 
            // rbtCompleto
            // 
            this.rbtCompleto.AutoSize = true;
            this.rbtCompleto.Location = new System.Drawing.Point(12, 55);
            this.rbtCompleto.Name = "rbtCompleto";
            this.rbtCompleto.Size = new System.Drawing.Size(102, 24);
            this.rbtCompleto.TabIndex = 1;
            this.rbtCompleto.TabStop = true;
            this.rbtCompleto.Text = "Completo";
            this.rbtCompleto.UseVisualStyleBackColor = true;
            // 
            // rbtBasico
            // 
            this.rbtBasico.Location = new System.Drawing.Point(12, 25);
            this.rbtBasico.Name = "rbtBasico";
            this.rbtBasico.Size = new System.Drawing.Size(101, 24);
            this.rbtBasico.TabIndex = 0;
            this.rbtBasico.TabStop = true;
            this.rbtBasico.Text = "Basico";
            this.rbtBasico.UseVisualStyleBackColor = true;
            // 
            // entr
            // 
            this.entr.Controls.Add(this.rbtDomicilio);
            this.entr.Controls.Add(this.rbtSucursal);
            this.entr.Location = new System.Drawing.Point(319, 362);
            this.entr.Name = "entr";
            this.entr.Size = new System.Drawing.Size(200, 100);
            this.entr.TabIndex = 7;
            this.entr.TabStop = false;
            this.entr.Text = "Entrega";
            // 
            // rbtDomicilio
            // 
            this.rbtDomicilio.AutoSize = true;
            this.rbtDomicilio.Location = new System.Drawing.Point(21, 55);
            this.rbtDomicilio.Name = "rbtDomicilio";
            this.rbtDomicilio.Size = new System.Drawing.Size(100, 24);
            this.rbtDomicilio.TabIndex = 1;
            this.rbtDomicilio.TabStop = true;
            this.rbtDomicilio.Text = "Domicillio";
            this.rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // rbtSucursal
            // 
            this.rbtSucursal.AutoSize = true;
            this.rbtSucursal.Location = new System.Drawing.Point(21, 25);
            this.rbtSucursal.Name = "rbtSucursal";
            this.rbtSucursal.Size = new System.Drawing.Size(117, 24);
            this.rbtSucursal.TabIndex = 0;
            this.rbtSucursal.TabStop = true;
            this.rbtSucursal.Text = "En sucursal";
            this.rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // chkGps
            // 
            this.chkGps.AutoSize = true;
            this.chkGps.Location = new System.Drawing.Point(79, 469);
            this.chkGps.Name = "chkGps";
            this.chkGps.Size = new System.Drawing.Size(69, 24);
            this.chkGps.TabIndex = 8;
            this.chkGps.Text = "GPS";
            this.chkGps.UseVisualStyleBackColor = true;
            // 
            // chkCorporativo
            // 
            this.chkCorporativo.AutoSize = true;
            this.chkCorporativo.Location = new System.Drawing.Point(67, 74);
            this.chkCorporativo.Name = "chkCorporativo";
            this.chkCorporativo.Size = new System.Drawing.Size(166, 24);
            this.chkCorporativo.TabIndex = 9;
            this.chkCorporativo.Text = "Cliente corporativo";
            this.chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(67, 531);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 50);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular Total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(216, 539);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 43);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Nuevo alquiler";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(360, 535);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 47);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(525, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(569, 66);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar al alquiler";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Location = new System.Drawing.Point(521, 101);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(99, 20);
            this.lblEncabezado.TabIndex = 14;
            this.lblEncabezado.Text = "Encabezado";
            // 
            // lstAlquileres
            // 
            this.lstAlquileres.FormattingEnabled = true;
            this.lstAlquileres.ItemHeight = 20;
            this.lstAlquileres.Location = new System.Drawing.Point(525, 124);
            this.lstAlquileres.Name = "lstAlquileres";
            this.lstAlquileres.Size = new System.Drawing.Size(569, 244);
            this.lstAlquileres.TabIndex = 15;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(616, 442);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(69, 20);
            this.Subtotal.TabIndex = 16;
            this.Subtotal.Text = "Subtotal";
            // 
            // Domicilio
            // 
            this.Domicilio.AutoSize = true;
            this.Domicilio.Location = new System.Drawing.Point(616, 486);
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Size = new System.Drawing.Size(72, 20);
            this.Domicilio.TabIndex = 17;
            this.Domicilio.Text = "Domicilio";
            // 
            // Descuentos
            // 
            this.Descuentos.AutoSize = true;
            this.Descuentos.Location = new System.Drawing.Point(616, 519);
            this.Descuentos.Name = "Descuentos";
            this.Descuentos.Size = new System.Drawing.Size(95, 20);
            this.Descuentos.TabIndex = 18;
            this.Descuentos.Text = "Descuentos";
            // 
            // Itbis
            // 
            this.Itbis.AutoSize = true;
            this.Itbis.Location = new System.Drawing.Point(634, 561);
            this.Itbis.Name = "Itbis";
            this.Itbis.Size = new System.Drawing.Size(39, 20);
            this.Itbis.TabIndex = 19;
            this.Itbis.Text = "Itbis";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(596, 594);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(135, 20);
            this.Total.TabIndex = 20;
            this.Total.Text = "TOTAL A PAGAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(842, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 21;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(846, 456);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(51, 20);
            this.lblSubtotal.TabIndex = 22;
            this.lblSubtotal.Text = "label2";
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Location = new System.Drawing.Point(850, 497);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(51, 20);
            this.lblDescuentos.TabIndex = 23;
            this.lblDescuentos.Text = "label3";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(845, 531);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(51, 20);
            this.lblDomicilio.TabIndex = 24;
            this.lblDomicilio.Text = "label4";
            // 
            // lblItbis
            // 
            this.lblItbis.AutoSize = true;
            this.lblItbis.Location = new System.Drawing.Point(844, 561);
            this.lblItbis.Name = "lblItbis";
            this.lblItbis.Size = new System.Drawing.Size(51, 20);
            this.lblItbis.TabIndex = 25;
            this.lblItbis.Text = "label5";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(843, 594);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "label6";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(139, 32);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(301, 26);
            this.txtCliente.TabIndex = 27;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(147, 163);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(293, 26);
            this.txtVehiculo.TabIndex = 28;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(147, 229);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(293, 26);
            this.txtTarifa.TabIndex = 29;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(139, 104);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(293, 26);
            this.dtpSalida.TabIndex = 30;
            // 
            // nudDias
            // 
            this.nudDias.Location = new System.Drawing.Point(139, 285);
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(143, 26);
            this.nudDias.TabIndex = 31;
            // 
            // lblDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 640);
            this.Controls.Add(this.nudDias);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblItbis);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblDescuentos);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Itbis);
            this.Controls.Add(this.Descuentos);
            this.Controls.Add(this.Domicilio);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.lstAlquileres);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.chkCorporativo);
            this.Controls.Add(this.chkGps);
            this.Controls.Add(this.entr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblCliente);
            this.Name = "lblDescuento";
            this.Text = "RenCar Express-Alquiler";
            this.Load += new System.EventHandler(this.lblDescuento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.entr.ResumeLayout(false);
            this.entr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtCompleto;
        private System.Windows.Forms.RadioButton rbtBasico;
        private System.Windows.Forms.GroupBox entr;
        private System.Windows.Forms.RadioButton rbtDomicilio;
        private System.Windows.Forms.RadioButton rbtSucursal;
        private System.Windows.Forms.CheckBox chkGps;
        private System.Windows.Forms.CheckBox chkCorporativo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.ListBox lstAlquileres;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label Domicilio;
        private System.Windows.Forms.Label Descuentos;
        private System.Windows.Forms.Label Itbis;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblItbis;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.NumericUpDown nudDias;
    }
}

