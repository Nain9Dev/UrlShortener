# UrlShortener
# Acortador de URLs con .NET y C#

![Imagen de la App](images/url-shortener-banner.jpg)  Una aplicación web robusta construida con **ASP.NET Core Web API** que transforma URLs largas en enlaces cortos y fáciles de compartir. Este proyecto demuestra mis habilidades en el desarrollo de backend, la creación de APIs RESTful y la gestión de bases de datos.

## ✨ Características Principales

* **Creación de URLs Cortas:** Genera un código único para cada URL original.
* **Redirección Rápida:** Resuelve los enlaces cortos y redirige al usuario a la URL original de manera eficiente.
* **API RESTful:** Endpoints bien definidos para crear y gestionar los enlaces.
* **(Próximamente) Autenticación de Usuarios:** Sistema de registro y login con JWT para que los usuarios gestionen sus propios enlaces.
* **(Próximamente) Panel de Estadísticas:** Conteo de clics y análisis básico por cada enlace.

## 🛠️ Tecnologías Utilizadas

* **Framework:** ASP.NET Core 8
* **Lenguaje:** C#
* **Arquitectura:** API RESTful
* **Base de Datos:** Entity Framework Core con SQL Server (o la base de datos que elijas, ej: PostgreSQL)
* **Autenticación:** JSON Web Tokens (JWT)

## 🚀 Cómo Empezar

### **Prerrequisitos**

* SDK de .NET 8
* SQL Server (o tu elección de BD)
* Un editor de código como Visual Studio o VS Code.

### **Instalación**

1.  Clona el repositorio:
    ```bash
    git clone [https://github.com/Nain9Dev/UrlShortener.git](https://github.com/Nain9Dev/UrlShortener.git)
    ```
2.  Navega al directorio del proyecto:
    ```bash
    cd UrlShortener
    ```
3.  Configura tu cadena de conexión en `appsettings.json`.
4.  Aplica las migraciones de la base de datos:
    ```bash
    dotnet ef database update
    ```
5.  Ejecuta la aplicación:
    ```bash
    dotnet run
    ```
La API estará disponible en `https://localhost:5001`.

## 🤝 Cómo Contribuir

Las contribuciones son bienvenidas. Si tienes ideas para mejorar el proyecto, por favor abre un *issue* para discutirlo o envía un *pull request*.

---
