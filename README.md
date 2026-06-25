# Sistema de Restaurante - POO en C#

Ejercicio academico de **Programacion II** - Universidad Catolica del Uruguay (UCU)

Sistema de gestion de restaurante en **C# (.NET 8)** aplicando **Programacion Orientada a Objetos (POO)** con enfasis en el **Principio de Responsabilidad Unica (SRP)**.

---

## Descripcion

Este proyecto implementa un sistema basico de restaurante con las siguientes capacidades: modelado de platillos (nombre, precio, categoria vegetariana), gestion del menu (agregar/eliminar/buscar platos), representacion de mesas con estado de ocupacion, mozos que toman pedidos y son asignados a mesas, y ordenes que agrupan platillos y calculan el total.

El diseno respeta el principio **SRP**: cada clase tiene una unica razon de cambio y no asume responsabilidades ajenas.

---

## Tecnologias

| Tecnologia | Version |
|---|---|
| C# | 12 (LangVersion 6+) |
| .NET SDK | 8.0 |
| NUnit | Framework de testing |
| Namespace principal | `Ucu.Poo.Restaurant` |

---

## Estructura del proyecto

```
Restaurante-poo-csharp/
├── src/
│   ├── Dish.cs
│   ├── Menu.cs
│   ├── Order.cs
│   ├── Table.cs
│   ├── Waiter.cs
│   ├── Program.cs
│   └── Program.csproj
├── test/
│   ├── DishTests.cs
│   ├── MenuTests.cs
│   ├── TableTests.cs
│   ├── WaiterTests.cs
│   └── ProgramTests.csproj
├── assets/
├── .gitignore
├── Restaurant.sln
└── README.md
```

---

## Clases y responsabilidades

### `Dish`
Representa un platillo del restaurante. Almacena nombre, precio y si es vegetariano. Cumple con SRP al unicamente modelar los datos de un plato.

### `Menu`
Gestiona la coleccion de platillos disponibles. Permite agregar, eliminar y buscar platos. No asume responsabilidades de logica de negocio externa.

### `Order`
Representa el pedido de una mesa. Permite agregar platillos y calcular el precio total. Separa la logica de facturacion del resto del sistema.

### `Table`
Modela una mesa con su numero identificador y estado de ocupacion (libre/ocupada). Solo gestiona su propia informacion y estado.

### `Waiter`
Representa a un mozo. Puede ser asignado a una mesa y tomar pedidos. Encargado unicamente de responsabilidades propias del rol.

---

## Instalacion y ejecucion

**Requisito previo:** [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) o superior.

```bash
git clone https://github.com/Ignacio-Zeballos/Restaurante-poo-csharp.git
cd Restaurante-poo-csharp/src
dotnet run
```

---

## Ejecucion de tests

```bash
cd test
dotnet test
```

Tests implementados con **NUnit** cubriendo las clases `Dish`, `Menu`, `Table` y `Waiter`.

---

## Proximos pasos

A continuacion se listan mejoras identificadas para futuras iteraciones del proyecto.

**1. Agregar OrderTests.cs** - La clase `Order` no tiene tests unitarios. Agregar cobertura para `AddToOrder` y el calculo del total.

**2. Validacion de datos en constructores** - Incorporar validaciones (precio no negativo en `Dish`, nombre no vacio) con excepciones apropiadas (`ArgumentException`, `ArgumentNullException`).

**3. Interfaz de consola interactiva** - Reemplazar el `Program.cs` estatico por un menu de consola que permita agregar platos, asignar mozos y realizar pedidos en tiempo real.

**4. Persistencia de datos** - Implementar lectura/escritura desde archivos JSON o CSV para que el menu y estado de mesas persistan entre ejecuciones.

**5. Patron Repository** - Separar el acceso a datos de la logica de negocio aplicando el patron Repository, como evolucion natural del SRP ya implementado.

**6. Completar la seccion About del repositorio** - Agregar descripcion y topics relevantes en GitHub: `csharp`, `oop`, `dotnet`, `restaurant`, `ucu`.

**7. Configurar GitHub Actions** - Agregar un workflow CI/CD que ejecute los tests automaticamente en cada push o pull request.

**8. Documentacion XML completa** - Estandarizar comentarios `/// <summary>` en todos los metodos y propiedades para generar documentacion automatica con DocFX.
