using System;
using System.Media;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Cajero
{
    // Formulario que maneja el ingreso del número de tarjeta
    public partial class FormNumTarjeta : Form
    {
        private CajeroService cajeroService; // Servicio que gestiona la lógica del cajero

        // Constructor que recibe el servicio CajeroService
        public FormNumTarjeta(CajeroService service)
        {
            InitializeComponent();
            cajeroService = service; // Inicializa el servicio
        }

        // Evento que se ejecuta cuando se hace clic en el botón de validar número de tarjeta
        private void label3_Click(object sender, EventArgs e)
        {
            string txtNumT = txtNumTarjeta.Text; // Obtiene el número de tarjeta ingresado

            // Verifica si el campo de tarjeta está vacío
            if (string.IsNullOrWhiteSpace(txtNumT))
            {
                SystemSounds.Hand.Play(); // Reproduce sonido de error
                MessageBox.Show("Por favor, ingrese el número de tarjeta.");
                txtNumTarjeta.Text = ""; // Limpia el campo
            }
            // Valida si el número de tarjeta es correcto
            else if (cajeroService.ValidarTarjeta(txtNumT))
            {
                this.Hide(); // Oculta el formulario actual
                FormPIN formClave = new FormPIN(cajeroService); // Abre el formulario de PIN
                formClave.ShowDialog();
            }
            else
            {
                SystemSounds.Hand.Play(); // Reproduce sonido de error
                MessageBox.Show("Número de Tarjeta incorrecto.");
                txtNumTarjeta.Text = ""; // Limpia el campo
            }
        }

        // Eventos que añaden los números al campo de texto del número de tarjeta
        private void lbl1_Click(object sender, EventArgs e) { txtNumTarjeta.Text += "1"; }
        private void lbl2_Click(object sender, EventArgs e) { txtNumTarjeta.Text += "2"; }
        private void lbl3_Click(object sender, EventArgs e) { txtNumTarjeta.Text += "3"; }
        private void lbl4_Click(object sender, EventArgs e) { txtNumTarjeta.Text += "4"; }
        private void lbl5_Click(object sender, EventArgs e) { txtNumTarjeta.Text += "5"; }
        private void lbl6_Click(object sender, EventArgs e) { txtNumTarjeta.Text += "6"; }
        private void lbl7_Click(object sender, EventArgs e) { txtNumTarjeta.Text += "7"; }
        private void lbl8_Click(object sender, EventArgs e) { txtNumTarjeta.Text += "8"; }
        private void lbl9_Click(object sender, EventArgs e) { txtNumTarjeta.Text += "9"; }
        private void lbl0_Click(object sender, EventArgs e) { txtNumTarjeta.Text += "0"; }

        // Evento que borra el último carácter del campo de texto del número de tarjeta
        private void lblClear_Click(object sender, EventArgs e)
        {
            if (txtNumTarjeta.Text.Length > 0)
            {
                txtNumTarjeta.Text = txtNumTarjeta.Text.Substring(0, txtNumTarjeta.Text.Length - 1);
            }
        }
    }
}
