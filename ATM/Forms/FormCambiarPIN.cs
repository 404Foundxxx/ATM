using System;
using System.Media;
using System.Windows.Forms;

namespace Cajero
{
    // Formulario para cambiar el PIN del usuario
    public partial class FormCambiarPIN : Form
    {
        private CajeroService cajeroService; // Servicio que gestiona la lógica del cajero

        // Constructor que recibe el servicio CajeroService
        public FormCambiarPIN(CajeroService service)
        {
            InitializeComponent();
            cajeroService = service; // Inicializa el servicio
        }

        // Evento que se ejecuta cuando se hace clic en el botón de cambiar PIN
        private void label3_Click(object sender, EventArgs e)
        {
            string pinActual = txtPinActual.Text; // Obtiene el PIN actual ingresado
            string nuevoPin = txtNuevoPin.Text; // Obtiene el nuevo PIN ingresado

            // Verifica que ambos campos no estén vacíos
            if (string.IsNullOrWhiteSpace(pinActual) || string.IsNullOrWhiteSpace(nuevoPin))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica si el PIN actual es correcto
            if (!cajeroService.ValidarPIN(pinActual))
            {
                MessageBox.Show("El PIN actual es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si el nuevo PIN es un número de 4 dígitos
            if (nuevoPin.Length != 4 || !int.TryParse(nuevoPin, out _))
            {
                MessageBox.Show("El nuevo PIN debe ser un número de 4 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cambia el PIN y cierra el formulario actual
            cajeroService.CambiarPIN(nuevoPin);
            this.Close();

            // Abre el formulario de opciones
            FormOpciones formOpciones = new FormOpciones(cajeroService);
            formOpciones.Show();
        }

        // Eventos que añaden los números al campo de texto del PIN
        private void lbl1_Click(object sender, EventArgs e) { txtPinActual.Text += "1"; }
        private void lbl2_Click(object sender, EventArgs e) { txtPinActual.Text += "2"; }
        private void lbl3_Click(object sender, EventArgs e) { txtPinActual.Text += "3"; }
        private void lbl4_Click(object sender, EventArgs e) { txtPinActual.Text += "4"; }
        private void lbl5_Click(object sender, EventArgs e) { txtPinActual.Text += "5"; }
        private void lbl6_Click(object sender, EventArgs e) { txtPinActual.Text += "6"; }
        private void lbl7_Click(object sender, EventArgs e) { txtPinActual.Text += "7"; }
        private void lbl8_Click(object sender, EventArgs e) { txtPinActual.Text += "8"; }
        private void lbl9_Click(object sender, EventArgs e) { txtPinActual.Text += "9"; }
        private void lbl0_Click(object sender, EventArgs e) { txtPinActual.Text += "0"; }

        // Evento que borra el último carácter del campo de texto del PIN
        private void lblClear_Click(object sender, EventArgs e)
        {
            if (txtPinActual.Text.Length > 0)
            {
                txtPinActual.Text = txtPinActual.Text.Substring(0, txtPinActual.Text.Length - 1);
            }
        }

        // Evento que se ejecuta cuando se hace clic en el botón de cancelar
        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
            FormOpciones formOpciones = new FormOpciones(cajeroService); // Muestra el formulario de opciones
            formOpciones.Show();
        }

        // Evento que se ejecuta al cargar el formulario (actualmente no hace nada)
        private void FormCambiarPIN_Load(object sender, EventArgs e) { }
    }
}
