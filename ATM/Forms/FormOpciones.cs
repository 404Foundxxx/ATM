using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cajero
{
    // Formulario principal que muestra las opciones disponibles para el usuario
    public partial class FormOpciones : Form
    {
        private CajeroService cajeroService; // Servicio que maneja la lógica del cajero

        // Constructor que recibe el servicio CajeroService
        public FormOpciones(CajeroService service)
        {
            InitializeComponent();
            cajeroService = service; // Inicializa el servicio
        }

        // Evento que se ejecuta cuando se hace clic en el botón para ver el saldo
        private void button4_Click(object sender, EventArgs e)
        {
            FormSaldo formSaldo = new FormSaldo(cajeroService); // Crea el formulario de saldo
            formSaldo.Show(); // Muestra el formulario de saldo
            this.Hide(); // Oculta el formulario actual
        }

        // Evento que se ejecuta cuando se hace clic en el botón para retirar dinero
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            FormRetirar formRetirar = new FormRetirar(cajeroService); // Crea el formulario de retiro
            formRetirar.Show(); // Muestra el formulario de retiro
            this.Hide(); // Oculta el formulario actual
        }

        // Evento que se ejecuta cuando se hace clic en el botón para salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        // Evento que se ejecuta cuando se hace clic en el botón para ver las transacciones
        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            if (cajeroService.UsuarioActual != null) // Verifica si hay un usuario logueado
            {
                List<string> transacciones = cajeroService.ObtenerTransacciones(); // Obtiene el historial de transacciones

                if (transacciones.Count == 0) // Si no hay transacciones, muestra un mensaje
                {
                    MessageBox.Show("No hay transacciones recientes.", "Transacciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Si hay transacciones, las muestra en un mensaje
                {
                    string mensaje = "Últimas transacciones:\n\n" + string.Join("\n", transacciones);
                    MessageBox.Show(mensaje, "Transacciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe iniciar sesión primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Si no hay usuario logueado, muestra un mensaje de error
            }
        }

        // Evento que se ejecuta cuando se hace clic en el botón para cambiar el PIN
        private void btnCambiarPIN_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            FormCambiarPIN formCambiarPIN = new FormCambiarPIN(cajeroService); // Crea el formulario para cambiar el PIN
            formCambiarPIN.Show(); // Muestra el formulario para cambiar el PIN
        }
    }
}
