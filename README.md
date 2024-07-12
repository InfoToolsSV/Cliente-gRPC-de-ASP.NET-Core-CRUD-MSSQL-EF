# Cliente gRPC de ASP.NET Core CRUD con MSSQL y EF

Este proyecto demuestra cómo construir un cliente MVC para consumir un servicio gRPC utilizando ASP.NET Core, Entity Framework (EF) y MSSQL para operaciones CRUD.

## Requisitos

- .NET 6.0 SDK o superior
- SQL Server
- Servicio gRPC en ejecución (ver [Servicio gRPC de ASP.NET Core CRUD con MSSQL y EF](https://github.com/InfoToolsSV/Servicio-gRPC-de-ASP.NET-Core-CRUD-MSSQL-EF))

## Configuración

1. **Clonar el repositorio:**

    ```bash
    git clone https://github.com/InfoToolsSV/Cliente-gRPC-de-ASP.NET-Core-CRUD-MSSQL-EF.git
    cd Cliente-gRPC-de-ASP.NET-Core-CRUD-MSSQL-EF
    ```

2. **Configurar la conexión al servicio gRPC:**

    Actualiza la URL del servicio gRPC en la clase de servicio correspondiente.

    ```csharp
    public class GrpcClientService
    {
        private readonly GrpcChannel _channel;

        public GrpcClientService()
        {
            _channel = GrpcChannel.ForAddress("https://localhost:5001");
        }

        // Métodos para consumir el servicio gRPC
    }
    ```

## Ejecución del proyecto

1. **Construir el proyecto:**

    ```bash
    dotnet build
    ```

2. **Ejecutar el proyecto:**

    ```bash
    dotnet run
    ```

## Estructura del proyecto

- **Controllers:** Controladores MVC para manejar las solicitudes del usuario.
- **Models:** Clases de modelo de datos.
- **Protos:** Archivos .proto utilizados para la comunicación con el servicio gRPC.
- **Services:** Servicios que interactúan con el servicio gRPC.
- **Views:** Vistas MVC para la interfaz de usuario.

## Uso

Una vez que el cliente esté en ejecución, puedes acceder a la interfaz web y realizar operaciones CRUD que se comunicarán con el servicio gRPC.

## Contribuciones

¡Las contribuciones son bienvenidas! Por favor, abre un issue o envía un pull request.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT.
