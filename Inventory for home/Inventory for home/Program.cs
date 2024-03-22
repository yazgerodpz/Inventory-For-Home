// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

// linea para estableser un ciclo
bool _condicionCiclo = true;
// linea para crear una pantalla de bienvenida
// este comando usando el texto dentro de () para crear una linea de texto
Console.WriteLine("Bienvenido");
await Task.Delay(2500);
// el comando limpiara la pantalla
Console.Clear();
await MainMenuAsync();
//esta sentencia denota lo que se ejecutara enseguida en seguida 
async Task MainMenuAsync()
{
    do
    {
        // estas son las opciones del menú que se mostraran
        Console.WriteLine("Seleccione una de las siguientes opciones para proceder");
        Console.WriteLine("1.- Ver el inventario");
        Console.WriteLine("2.- Editar el inventario");
        Console.WriteLine("3.- Ver información de 'Stock' ó 'Prioridad'");
        Console.WriteLine("4.- Editar 'Stock' ó 'Prioridad'");
        Console.WriteLine("5.- Salir");
        // el comando string se usa para representar una secuencia
        string _opcEncadenaElegida = string.Empty;
        _opcEncadenaElegida = Console.ReadLine();
        // cambio a la opción seleccionada
        switch (_opcEncadenaElegida)
        {
            case "1":
                // se mostrara la siguiente linea
                Console.WriteLine("Se eligió ver inventario");
                // una micro pausa antes limpiarse
                await Task.Delay(2500);
                break;

            case "2":
                Console.WriteLine("Se eligió editar inventario");
                await SubmenuA1();
                await Task.Delay(2500);
                break;

            case "3":
                Console.WriteLine("Se eligió ver información de 'Stock' ó 'Prioridad'");
                await SubmenuA2();
                await Task.Delay(2500);
                break;

            case "4":
                Console.WriteLine("Se eligió editar 'Stock' ó 'Prioridad'");
                await SubmenuA3();
                await Task.Delay(2500);
                break;

            case "5":
                Console.WriteLine("Se eligió salir");
                //estabeser la condición que finaliza el programa
                _condicionCiclo = false;
                await Task.Delay(2000);
                break;

            default:
                // una opción de control para el caso de que no se elija una de las opciones establecida
                Console.WriteLine("La opción elegida no existe");
                await Task.Delay(2500);
                break;
        }
        // orden para limpiar la consola
        await Task.Delay(2000);
        Console.Clear();

    }
    while (_condicionCiclo);
    // fin del ciclo
}

async Task SubmenuA1()
{
    string _opcSubmenuA1 = string.Empty;
    bool SubmenuA1 = true;
    await Task.Delay(2500);
    Console.Clear();
    do
    {
        Console.WriteLine("Opciones de editar inventario");
        Console.WriteLine("1.-Añadir nuevo artículo");
        Console.WriteLine("2.-Modificar artículo");
        Console.WriteLine("3.-Eliminar artículo");
        Console.WriteLine("4.-Volver al menú pricipal");
        _opcSubmenuA1 = Console.ReadLine();
        switch (_opcSubmenuA1)
        {
            case "1":
                Console.WriteLine("Se eligío añadir nuevo artículo");
                await Task.Delay(2500);
                break;

            case "2":
                Console.WriteLine("Se eligío modificar un artículo");
                await Task.Delay(2500);
                break;

            case "3":
                Console.WriteLine("Se elígio eliminar arículo");
                await Task.Delay(2500);
                break;

            case "4":
                Console.WriteLine("Se eligío volver al menú pricipal");
                await Task.Delay(2000);
                SubmenuA1 = false;
                break;

            default:
                Console.WriteLine("La opción elegida no existe");
                await Task.Delay(2500);
                break;
        }
        await Task.Delay(2500);
        Console.Clear();
    }
    while (SubmenuA1);
}

async Task SubmenuA2()
{
    string _opcSubmenuA2 = string.Empty;
    bool SubmenuA2 = true;
    await Task.Delay(2500);
    Console.Clear();
    do
    {
        Console.WriteLine("Opción ver 'Stock' ó 'Prioridad'");
        Console.WriteLine("Añadir nuevo artículo");
        Console.WriteLine("Modificar artículo");
        Console.WriteLine("Eliminar artículo");
        Console.WriteLine("Volver al menú pricipal");
        switch (_opcSubmenuA2)
        {
            case "1":
                Console.WriteLine("Se eligío añadir nuevo artículo");
                await Task.Delay(2500);
                break;

            case "2":
                Console.WriteLine("Se eligío modificar un artículo");
                await Task.Delay(2500);
                break;

            case "3":
                Console.WriteLine("Se elígio eliminar arículo");
                await Task.Delay(2500);
                break;

            case "4":
                Console.WriteLine("Se eligío volver al menú pricipal");
                await Task.Delay(2500);
                SubmenuA2 = false;
                break;

            default:
                Console.WriteLine("La opción elegida no existe");
                await Task.Delay(2500);
                break;
        }
        await Task.Delay(2500);
        Console.Clear();
    }
    while (SubmenuA2);
}

async Task SubmenuA3()
{
    string _opcSubmenuA3 = string.Empty;
    bool SubmenuA3 = true;
    await Task.Delay(2500);
    Console.Clear();
    do
    {
        Console.WriteLine("Opciones de editar inventario");
        Console.WriteLine("Añadir nuevo artículo");
        Console.WriteLine("Modificar artículo");
        Console.WriteLine("Eliminar artículo");
        Console.WriteLine("Volver al menú pricipal");
        switch (_opcSubmenuA3)
        {
            case "1":
                Console.WriteLine("Se eligío añadir nuevo artículo");
                await Task.Delay(2500);
                break;

            case "2":
                Console.WriteLine("Se eligío modificar un artículo");
                await Task.Delay(2500);
                break;

            case "3":
                Console.WriteLine("Se elígio eliminar arículo");
                await Task.Delay(2500);
                break;

            case "4":
                Console.WriteLine("Se eligío volver al menú pricipal");
                await Task.Delay(2500);
                SubmenuA3 = false;
                break;

            default:
                Console.WriteLine("La opción elegida no existe");
                await Task.Delay(2500);
                break;
        }
        await Task.Delay(2500);
        Console.Clear();
    }
    while (SubmenuA3);
}