# Cajero Automático (ATM)

Simulador de cajero automático (ATM) desarrollado en C# con Windows Forms. Permite a los usuarios iniciar sesión con su tarjeta y PIN, consultar saldo, retirar dinero, ver historial de transacciones y cambiar su PIN de manera interactiva y segura.

## Características principales
- Inicio de sesión con número de tarjeta y PIN
- Consulta de saldo disponible
- Retiro de efectivo con control de saldo y límite de transacciones
- Visualización del historial de transacciones recientes
- Cambio de PIN de usuario
- Persistencia de datos mediante archivo JSON

## Estructura del proyecto
- **ATM/Forms/**: Formularios de la interfaz gráfica (inicio, opciones, saldo, retiro, cambio de PIN, etc.)
- **ATM/Services/**: Lógica de negocio y gestión de usuarios (servicio del cajero)
- **ATM/Data/**: Archivo de base de datos de usuarios en formato JSON
- **ATM/Resources/**: Imágenes y recursos gráficos

## Requisitos
- .NET 9.0 o superior
- Windows

## Ejecución
1. Clona el repositorio:
	```
	git clone https://github.com/404Foundxxx/ATM.git
	```
2. Abre la solución `ATM.sln` en Visual Studio.
3. Compila y ejecuta el proyecto.

## Créditos
Desarrollado por [@404Foundxxx](https://github.com/404Foundxxx) 
