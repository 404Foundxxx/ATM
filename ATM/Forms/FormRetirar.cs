using System;
using System.Media;
using System.Windows.Forms;

namespace Cajero
{
    public partial class FormRetirar : Form
    {
        private CajeroService cajeroService; // Servicio que maneja la lógica del cajero

        // Constructor que recibe el servicio CajeroService
        public FormRetirar(CajeroService service)
        {
            InitializeComponent();
            cajeroService = service; // Inicializa el servicio
        }

        // Método para realizar el retiro de dinero
        private void RealizarRetiro(int monto)
        {
            // Verifica si el usuario ya alcanzó el límite de transacciones
            if (cajeroService.GetTransaccionesRealizadas() >= 3)
            {
                MessageBox.Show("Has alcanzado el límite de transacciones.",
                                "Límite de transacciones",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Si ha alcanzado el límite, no se realiza el retiro
            }

            // Intenta realizar el retiro
            if (cajeroService.RetirarDinero(monto))
            {
                MessageBox.Show("Retiro exitoso.", "Retiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Cierra la ventana actual
                FormOpciones formOpciones = new FormOpciones(cajeroService); // Muestra las opciones del cajero
                formOpciones.Show();
            }
            else
            {
                // Si no se puede realizar el retiro (fondos insuficientes o límite de transacciones alcanzado)
                MessageBox.Show("Fondos insuficientes o límite de transacciones alcanzado.");
            }
        }

        // Métodos que llaman a 'RealizarRetiro' con diferentes montos cuando se hace clic en los botones
        private void btnTransacciones_Click(object sender, EventArgs e) { RealizarRetiro(20); }
        private void btnCambiarPIN_Click(object sender, EventArgs e) { RealizarRetiro(50); }
        private void btnSalir_Click(object sender, EventArgs e) { RealizarRetiro(100); }

        // Método que cierra el formulario y regresa a las opciones
        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            FormOpciones formOpciones = new FormOpciones(cajeroService); // Muestra las opciones
            formOpciones.Show();
        }
    }
}
