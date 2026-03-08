# 🏥 API RESTful - Gestión de Citas Médicas
 
## 📖 Descripción del Proyecto
Esta es una API RESTful desarrollada en C# con .NET Core para gestionar las citas médicas de una clínica privada. El sistema soluciona el problema del registro manual, permitiendo registrar, consultar, actualizar y cancelar citas de manera eficiente, además de administrar la información de pacientes y médicos.
 
El proyecto implementa una arquitectura basada en Controladores y Modelos, utilizando colecciones en memoria (`List<T>`) para simular la persistencia de datos durante la ejecución, manejando las excepciones con bloques `try-catch` y cumpliendo con los requerimientos de la evaluación parcial.
 
## 🚀 Tecnologías Utilizadas.
* **Lenguaje:** C#
* **Framework:** .NET Core (ASP.NET Core Web API)
* **Arquitectura:** Patrón MVC (Modelos y Controladores)
* **Herramientas de prueba:** Postman
 
## ⚙️ Instalación y Ejecución
 
Sigue estos pasos para ejecutar la API en tu entorno local:
 
1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/pmsl01021991/desarrollo_de_los_servicios_web_clinica_privada]
   ```
2. **Abrir el proyecto:**
   Abre la solución en Visual Studio o la carpeta en Visual Studio Code.
3. **Restaurar paquetes y compilar:**
   Asegúrate de tener instalado el SDK de .NET. Compila el proyecto para restaurar las dependencias.
4. **Ejecutar la aplicación:**
   * En Visual Studio: Presiona `F5` o el botón de "Iniciar depuración".
   * En consola (CLI): Ejecuta el comando `dotnet run`.
5. **Probar:**
   La API se levantará por defecto en un puerto local. Usa **Postman** para interactuar con los endpoints.

------------------------------------------------------------------------

## Ejecución de la API

Una vez ejecutado el proyecto, la API estará disponible en una dirección
similar a:

    https://localhost:5168

Los endpoints pueden ser probados utilizando herramientas como
**Postman**.

Ejemplos de endpoints:

    GET /api/citas
    POST /api/citas
    PUT /api/citas/{id}
    DELETE /api/citas/{id}

    GET /api/pacientes
    POST /api/pacientes

    GET /api/medicos
    POST /api/medicos

------------------------------------------------------------------------

## Pruebas

Las pruebas de funcionamiento de la API se realizaron utilizando
**Postman**, enviando solicitudes HTTP a los endpoints para verificar
las operaciones de creación, consulta, actualización y eliminación de
registros.

------------------------------------------------------------------------

## Integrantes del equipo

-   Suyón Lescano Pablo
-   Pulache Arevalo Erick
-   Rondon Gonzalez Jhony
-   Godoy Palacios Joaquin
-   Alcala Arata Cindy
