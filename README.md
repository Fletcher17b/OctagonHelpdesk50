🛠️ Octagon Helpdesk
Un sistema para gestionar requerimientos o Tickets de manera eficiente en el área de Informática. 💼

🚀 Características principales
✨ Registro y seguimiento de requerimientos.
✨ Fases: Creado → Asignado → En proceso → Finalizado. (Excepcion: En Espera)
✨ Soporte para adjuntar imágenes y descripciones detalladas.
✨ Interfaz amigable diseñada con Windows Forms (.NET Framework 4.7.2).

🖥️ Requisitos previos
Antes de instalar, asegúrate de tener lo siguiente:

✅ Visual Studio (con soporte para .NET Framework).
✅ .NET Framework 4.7.2.
✅ Git para clonar el repositorio.


📥 Instalación
Paso 1: Clonar el repositorio
Abre una terminal y ejecuta:
git clone https://github.com/Fletcher17b/OctagonHelpdesk.git

Paso 2: Abrir el proyecto en Visual Studio
1️⃣ Abre Visual Studio.
2️⃣ Selecciona Abrir un proyecto o solución.
3️⃣ Navega hasta la carpeta del repositorio y selecciona el archivo .sln.

Paso 3: Restaurar paquetes NuGet
1️⃣ Ve a Herramientas > Administrador de paquetes NuGet > Administrar paquetes para la solución.
2️⃣ Asegúrate de que los paquetes estén actualizados.
3️⃣ Instala el paquete para Microsoft ReportViewer:

Install-Package Microsoft.ReportingServices.ReportViewerControl.Winforms


Paso 4: Ejecutar el proyecto
1️⃣ Establece el proyecto principal (clic derecho sobre el proyecto en el Explorador de soluciones > Establecer como proyecto de inicio).
2️⃣ Presiona Ctrl + F5 para compilar y ejecutar.

📊 Uso del ReportViewer
Este proyecto utiliza Microsoft ReportViewer para generar reportes interactivos.
Asegúrate de configurar el control en el formulario y vincularlo a un archivo .rdlc.
Puedes personalizar los reportes según tus necesidades.
