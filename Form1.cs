using SegundoPARcialpedro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SegundoPARcialpedro
{
    public partial class lblDescuento : Form
    {
        private decimal subtotal = 0m;

        public lblDescuento()
        {
            InitializeComponent();
        }

        private void lblDescuento_Load(object sender, EventArgs e)
        {
            Font fuenteMonoespaciada = new Font("Consolas", 9);
            lblEncabezado.Font = fuenteMonoespaciada;
            lstAlquileres.Font = fuenteMonoespaciada;

            nudDias.Minimum = 1;
            nudDias.Maximum = 30;

            lblEncabezado.Text = string.Concat(
                "Días".PadRight(6),
                "Vehículo".PadRight(24),
                "Tarifa".PadLeft(10),
                "Total".PadLeft(12)
            );

            LimpiarTodo();
        }

        private void LimpiarTodo()
        {
            subtotal = 0m;
            lstAlquileres.Items.Clear();

            // Reiniciar datos del cliente y opciones
            txtCliente.Text = string.Empty;
            dtpSalida.Value = DateTime.Today;
            chkCorporativo.Checked = false;
            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            // Reiniciar campos del vehículo
            LimpiarCamposVehiculo();

            // Reiniciar etiquetas de montos
            string montoCero = "RD$ 0.00";
            lblSubtotal.Text = montoCero;
            lblDescuentos.Text = montoCero;
            lblDomicilio.Text = montoCero;
            lblItbis.Text = montoCero;
            lblTotal.Text = montoCero;
        }

        private void LimpiarCamposVehiculo()
        {
            txtVehiculo.Text = string.Empty;
            txtTarifa.Text = string.Empty;
            nudDias.Value = 1;
            chkGps.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcionVehiculo = txtVehiculo.Text.Trim();

            if (string.IsNullOrEmpty(descripcionVehiculo))
            {
                MessageBox.Show("Escriba el vehículo.");
                txtVehiculo.Focus();
                return;
            }

            if (!decimal.TryParse(txtTarifa.Text, out decimal tarifaDiaria))
            {
                MessageBox.Show("Escriba una tarifa válida.");
                txtTarifa.Focus();
                return;
            }

            if (rbtCompleto.Checked)
            {
                tarifaDiaria += 300m;
                descripcionVehiculo += " (Completo)";
            }

            if (chkGps.Checked)
            {
                tarifaDiaria += 100m;
                descripcionVehiculo += " (GPS)";
            }

            int cantidadDias = Convert.ToInt32(nudDias.Value);
            decimal importeLinea = tarifaDiaria * cantidadDias;
            subtotal += importeLinea;

            if (descripcionVehiculo.Length > 24)
            {
                descripcionVehiculo = descripcionVehiculo.Substring(0, 24);
            }

            string registroFila = string.Format("{0}{1}{2}{3}",
                cantidadDias.ToString().PadRight(6),
                descripcionVehiculo.PadRight(24),
                tarifaDiaria.ToString("N2").PadLeft(10),
                importeLinea.ToString("N2").PadLeft(12)
            );

            lstAlquileres.Items.Add(registroFila);

            LimpiarCamposVehiculo();
            txtVehiculo.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.Items.Count == 0)
            {
                MessageBox.Show("Agregue al menos un vehículo.");
                return;
            }

            decimal montoDescuento = chkCorporativo.Checked ? subtotal * 0.15m : 0m;
            decimal cargoDomicilio = rbtDomicilio.Checked ? 500m : 0m;

            decimal montoGravable = (subtotal - montoDescuento) + cargoDomicilio;
            decimal montoItbis = montoGravable * 0.18m;
            decimal totalGeneral = montoGravable + montoItbis;

            lblSubtotal.Text = $"RD$ {subtotal:0.00}";
            lblDescuentos.Text = $"RD$ {montoDescuento:0.00}";
            lblDomicilio.Text = $"RD$ {cargoDomicilio:0.00}";
            lblItbis.Text = $"RD$ {montoItbis:0.00}";
            lblTotal.Text = $"RD$ {totalGeneral:0.00}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            txtCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}