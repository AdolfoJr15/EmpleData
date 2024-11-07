EmpleData -
Registra y Consulta Empleados

para utilizar este proyecto tienes que seguir los siguientes pasos:

1. Clonar el repositorio:
Abre una terminal o consola (puede ser "CMD" en Windows o "Terminal" en macOS/Linux).
Usa el siguiente comando para clonar el repositorio (https://github.com/AdolfoJr15/EmpleData.git):
git clone https://github.com/AdolfoJr15/EmpleData.git

2. Abrir el proyecto en Visual Studio 2022:
Asegúrate de tener instalado Visual Studio 2022 (con soporte para C#).
Puedes descargarlo desde https://visualstudio.microsoft.com/.
Una vez clonado el repositorio, ve a la carpeta del proyecto.
Abre Visual Studio 2022 y selecciona Abrir proyecto.
Navega a la carpeta donde clonaste el repositorio y selecciona el archivo .sln (solution) del proyecto C#.

3. Restaurar dependencias (si es necesario):
Si el proyecto tiene dependencias NuGet, Visual Studio 2022 generalmente las restaurará automáticamente. Si no,
puedes hacer clic derecho sobre la solución en el Explorador de soluciones y seleccionar Restaurar NuGet Packages.

4. Configuración appsettings.json:
ajusta los valores según sea necesario. Cambia el Server (por ejemplo, de localhost a la dirección IP del servidor),
el Database (nombre de la base de datos) etc...

6. Ejecutar proyecto:
Puedes probar tu API usando la herramienta:
Swagger: Si has habilitado Swagger en tu proyecto, puedes acceder a una interfaz gráfica en el 
navegador para interactuar con tu API. Visual Studio 2022 configura Swagger automáticamente si creas 
un proyecto Web API y seleccionas la opción para habilitar Swagger.
