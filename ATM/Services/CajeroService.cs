using System.Text.Json;

namespace Cajero
{
    public class CajeroService
    {
        private readonly string filepath = "ATM/Data/CajeroAutoDB.json"; // Ruta del archivo JSON
        private List<Usuario> usuarios; // Lista de usuarios
        public Usuario UsuarioActual { get; private set; } // Usuario actualmente autenticado

        // Constructor que carga los usuarios al iniciar el servicio
        public CajeroService()
        {
            CargarUsuarios();
        }

        // Carga los usuarios desde el archivo JSON
        private void CargarUsuarios()
        {
            if (File.Exists(filepath))
            {
                try
                {
                    string json = File.ReadAllText(filepath);
                    usuarios = JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
                }
                catch
                {
                    usuarios = new List<Usuario>(); // Si ocurre un error, inicializa la lista vacía
                }
            }
            else
            {
                usuarios = new List<Usuario>(); // Si no existe el archivo, inicializa la lista vacía
            }
        }

        // Guarda la lista de usuarios en el archivo JSON
        private void GuardarUsuarios()
        {
            try
            {
                string json = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filepath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Valida si la tarjeta existe entre los usuarios
        public bool ValidarTarjeta(string tarjeta)
        {
            UsuarioActual = usuarios.Find(u => u.Tarjeta == tarjeta);
            return UsuarioActual != null;
        }

        // Valida si el PIN es correcto para el usuario actual
        public bool ValidarPIN(string pin)
        {
            return UsuarioActual?.PIN == pin;
        }

        // Obtiene el saldo del usuario actual
        public decimal ObtenerSaldo()
        {
            return UsuarioActual?.Saldo ?? 0;
        }

        private const int LIMITE_TRANSACCIONES = 10; // Límite de transacciones por sesión
        private int transaccionesRealizadas = 0; // Contador de transacciones realizadas

        // Realiza un retiro de dinero si es posible
        public bool RetirarDinero(int monto)
        {
            if (transaccionesRealizadas >= LIMITE_TRANSACCIONES)
                return false; // Límite de transacciones alcanzado

            if (UsuarioActual?.Saldo >= monto)
            {
                // Descuenta el monto y guarda la transacción
                UsuarioActual.Saldo -= monto;
                string transaccion = $"Retiro de ${monto} - {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
                UsuarioActual.Transacciones.Insert(0, transaccion);
                GuardarUsuarios();

                transaccionesRealizadas++;
                return true; // Retiro exitoso
            }
            else
            {
                MessageBox.Show("Saldo insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Saldo insuficiente
            }
        }

        // Devuelve el número de transacciones realizadas
        public int GetTransaccionesRealizadas()
        {
            return transaccionesRealizadas;
        }

        // Resetea el contador de transacciones
        public void ResetTransacciones()
        {
            transaccionesRealizadas = 0;
        }

        // Obtiene el historial de transacciones del usuario
        public List<string> ObtenerTransacciones()
        {
            return UsuarioActual?.Transacciones ?? new List<string>();
        }

        // Cambia el PIN del usuario actual
        public void CambiarPIN(string nuevoPIN)
        {
            if (UsuarioActual == null)
            {
                MessageBox.Show("Debe iniciar sesión primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsuarioActual.PIN = nuevoPIN;
            GuardarUsuarios();
            MessageBox.Show("PIN cambiado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Clase que representa a un usuario
    public class Usuario
    {
        public string Tarjeta { get; set; } // Número de tarjeta
        public string PIN { get; set; } // PIN del usuario
        public decimal Saldo { get; set; } = 1000; // Saldo inicial
        public List<string> Transacciones { get; set; } = new List<string>(); // Historial de transacciones
    }
}
