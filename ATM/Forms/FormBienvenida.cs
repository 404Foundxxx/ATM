using System;
using System.Windows.Forms;

namespace Cajero
{
    // Formulario de bienvenida que muestra la pantalla inicial
    public partial class FormBienvenida : Form
    {
        private CajeroService cajeroService; // Servicio del cajero que gestiona la lógica

        // Constructor del formulario, inicializa los componentes y el servicio del cajero
        public FormBienvenida()
        {
            InitializeComponent();
            cajeroService = new CajeroService(); // Crea una instancia del servicio CajeroService
        }

        // Evento que se ejecuta cuando se hace clic en el botón "Insertar"
        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            // Oculta el formulario actual y abre el formulario de ingreso de número de tarjeta
            this.Hide();
            FormNumTarjeta formNumeroTarjeta = new FormNumTarjeta(cajeroService); // Pasa el servicio al siguiente formulario
            formNumeroTarjeta.ShowDialog(); // Muestra el formulario de forma modal
        }
    }
}
