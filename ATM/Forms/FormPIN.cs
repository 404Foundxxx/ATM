using System;
using System.Media;
using System.Windows.Forms;

namespace Cajero
{
    public partial class FormPIN : Form
    {
        private CajeroService cajeroService; // Servicio que maneja la lógica del cajero

        // Constructor que recibe el servicio CajeroService
        public FormPIN(CajeroService service)
        {
            InitializeComponent();
            cajeroService = service; // Inicializa el servicio
        }

        // Evento que se dispara cuando se presiona el botón para validar el PIN
        private void label3_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text; // Obtiene el PIN ingresado

            // Si el PIN está vacío, muestra un mensaje de error
            if (string.IsNullOrWhiteSpace(password))
            {
                SystemSounds.Hand.Play(); // Reproduce un sonido de error
                MessageBox.Show("Por favor, ingrese su PIN.");
                txtPassword.Text = ""; // Limpia el campo de texto
            }
            // Si el PIN es válido, muestra las opciones del cajero
            else if (cajeroService.ValidarPIN(password))
            {
                this.Hide(); // Oculta el formulario actual
                FormOpciones formOpciones = new FormOpciones(cajeroService); // Muestra las opciones
                formOpciones.ShowDialog();
            }
            // Si el PIN es incorrecto, muestra un mensaje de error
            else
            {
                SystemSounds.Hand.Play(); // Reproduce un sonido de error
                MessageBox.Show("Contraseña incorrecta.");
                txtPassword.Text = ""; // Limpia el campo de texto
            }
        }

        // Métodos que agregan números al campo de texto cuando se presionan los botones
        private void lbl1_Click(object sender, EventArgs e) { txtPassword.Text += "1"; }
        private void lbl2_Click(object sender, EventArgs e) { txtPassword.Text += "2"; }
        private void lbl3_Click(object sender, EventArgs e) { txtPassword.Text += "3"; }
        private void lbl4_Click(object sender, EventArgs e) { txtPassword.Text += "4"; }
        private void lbl5_Click(object sender, EventArgs e) { txtPassword.Text += "5"; }
        private void lbl6_Click(object sender, EventArgs e) { txtPassword.Text += "6"; }
        private void lbl7_Click(object sender, EventArgs e) { txtPassword.Text += "7"; }
        private void lbl8_Click(object sender, EventArgs e) { txtPassword.Text += "8"; }
        private void lbl9_Click(object sender, EventArgs e) { txtPassword.Text += "9"; }
        private void lbl0_Click(object sender, EventArgs e) { txtPassword.Text += "0"; }

        // Método que elimina el último carácter ingresado en el campo de texto
        private void lblClear_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                txtPassword.Text = txtPassword.Text.Substring(0, txtPassword.Text.Length - 1);
            }
        }
    }
}
