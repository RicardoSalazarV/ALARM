ALARMA

ALARMA es una aplicación de escritorio desarrollada en C# con Windows Forms que permite a los usuarios agendar citas de reparación seleccionando el tipo de dispositivo, ingresando su nombre y eligiendo una fecha. Además, incluye una barra de progreso que simula una cuenta regresiva, reforzando la experiencia de urgencia mediante alertas visuales y sonoras.

Características

Ingreso del nombre del cliente.

Menú interactivo para seleccionar el tipo de dispositivo:

Computadora

Smartphone

Tablet

Otro


Selector de fecha para agendar la cita.

Confirmación visual de la cita con los datos ingresados.

Botón para limpiar el formulario.

Temporizador con barra de progreso que lanza una advertencia al finalizar.


Componentes UI

TextBox: Entrada del nombre.

ToolStripSplitButton: Confirma y muestra los datos de la cita.

MenuStrip: Permite seleccionar el tipo de dispositivo.

DateTimePicker: Permite escoger la fecha deseada.

ProgressBar: Simula el paso del tiempo para alertar al usuario.

Timer: Controla la barra de progreso.


Flujo de la Aplicación

1. El usuario introduce su nombre.


2. Selecciona el dispositivo a reparar desde el menú.


3. Elige la fecha para la cita.


4. Confirma la cita y recibe un resumen de los datos ingresados.


5. El sistema puede iniciar una cuenta regresiva visual que culmina con una alerta tipo "alarma".



Requisitos del Sistema

Visual Studio 2019 o superior

.NET Framework 4.7 o superior

Windows 10/11


Cómo usar

1. Clona este repositorio o descarga los archivos.


2. Abre el archivo .sln con Visual Studio.


3. Compila y ejecuta (Ctrl + F5).


4. Ingresa los datos y sigue las instrucciones en pantalla.


5. Observa cómo el temporizador activa la "alarma" al llegar al límite.



Posibles Mejoras

Sonido de alerta real al finalizar el temporizador.

Persistencia en base de datos (SQLite o MySQL).

Funcionalidad para editar o cancelar citas.

Diseño responsivo y temas personalizables.

Notificaciones push o por correo electrónico.
