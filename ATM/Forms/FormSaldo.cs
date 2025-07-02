using System;
using System.Windows.Forms;

namespace Cajero
{
    public partial class FormSaldo : Form
    {
        private CajeroService cajeroService; // Servicio que maneja la lógica del cajero

        // Constructor que recibe el servicio CajeroService y muestra el saldo actual
        public FormSaldo(CajeroService service)
        {
            InitializeComponent();
            cajeroService = service; // Inicializa el servicio

            // Muestra el saldo disponible formateado en la etiqueta lblSaldoActual
            lblSaldoActual.Text = $"Saldo disponible:\n${cajeroService.ObtenerSaldo():N2}";
        }

        // Método que regresa al formulario de opciones al hacer clic en el botón "Atrás"
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta la ventana actual
            FormOpciones formOpciones = new FormOpciones(cajeroService); // Muestra el formulario de opciones
            formOpciones.Show();
        }
    }
}
