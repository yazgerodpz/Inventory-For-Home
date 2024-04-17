// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using InventoryForHome.Models;

// linea para estableser un ciclo
bool _condicionCiclo = true;
// linea para crear una pantalla de bienvenida
// este comando usando el texto dentro de () para crear una linea de texto
Console.WriteLine("Bienvenido");
await Task.Delay(1000);
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
        Console.WriteLine("1.- Ver el Inventario");
        Console.WriteLine("2.- Editar el Inventario");
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
                Console.WriteLine("Se eligió ver Inventario");
                // una micro pausa antes limpiarse
                await Task.Delay(2500);
                Console.Clear();
                List<StoredProcedure1> _AllInventoryInDb = new List<StoredProcedure1>();
                _AllInventoryInDb = await Querys.ObtenerTablaItemAsync();
                bool ShowsInventory = true;
                string OptMenuView = string.Empty;
                await ImprimirElementos(_AllInventoryInDb);
                break;

            case "2":
                Console.WriteLine("Se eligió editar Inventario");
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
        await Task.Delay(1200);
        Console.Clear();

    }
    while (_condicionCiclo);
    // fin del ciclo
}

async Task SubmenuA1()
{
    string _opcSubmenuA1 = string.Empty;
    bool SubmenuA1 = true;
    await Task.Delay(2000);
    Console.Clear();
    do
    {
        Console.WriteLine("Opciones de editar Inventario");
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
                await Task.Delay(1500);
                SubmenuA1 = false;
                break;

            default:
                Console.WriteLine("La opción elegida no existe");
                await Task.Delay(2500);
                break;
        }
        await Task.Delay(1200);
        Console.Clear();
    }
    while (SubmenuA1);
}

async Task SubmenuA2()
{
    string _opcSubmenuA2 = string.Empty;
    bool SubmenuA2 = true;
    await Task.Delay(2000);
    Console.Clear();
    do
    {
        Console.WriteLine("Opciones para ver 'Stock' ó 'Prioridad'");
        Console.WriteLine("1.-Ver información de 'Stock'");
        Console.WriteLine("2.-Ver información de 'Prioridad'");
        Console.WriteLine("3.-Volver al menú pricipal");
        _opcSubmenuA2 = Console.ReadLine();
        switch (_opcSubmenuA2)
        {
            case "1":
                Console.WriteLine("Se eligío ver información de 'Stock'");
                await Task.Delay(2500);
                break;

            case "2":
                Console.WriteLine("Se eligío ver información de 'Prioridad'");
                await Task.Delay(2500);
                break;

            case "3":
                Console.WriteLine("Se eligío volver al menú pricipal");
                await Task.Delay(1500);
                SubmenuA2 = false;
                break;

            default:
                Console.WriteLine("La opción elegida no existe");
                await Task.Delay(2500);
                break;
        }
        await Task.Delay(1200);
        Console.Clear();
    }
    while (SubmenuA2);
}

async Task SubmenuA3()
{
    string _opcSubmenuA3 = string.Empty;
    bool SubmenuA3 = true;
    await Task.Delay(2000);
    Console.Clear();
    do
    {
        Console.WriteLine("Seleccione entre 'Stock' ó 'Prioridad' para editar");
        Console.WriteLine("1.-Editar 'Stock'");
        Console.WriteLine("2.-Editar 'Prioridad'");
        Console.WriteLine("3.-Volver al menú pricipal");
        _opcSubmenuA3 = Console.ReadLine();
        switch (_opcSubmenuA3)
        {
            case "1":
                Console.WriteLine("Se eligío editar 'Stock'");
                await SubmenuB1();
                await Task.Delay(2500);
                break;

            case "2":
                Console.WriteLine("Se eligío editar 'Prioridad'");
                await SubmenuB2();
                await Task.Delay(2500);
                break;

            case "3":
                Console.WriteLine("Se eligío volver al menú pricipal");
                await Task.Delay(1500);
                SubmenuA3 = false;
                break;

            default:
                Console.WriteLine("La opción elegida no existe");
                await Task.Delay(2500);
                break;
        }
        await Task.Delay(1200);
        Console.Clear();
    }
    while (SubmenuA3);
}
async Task SubmenuB1()
{
    string _opcSubmenuB1 = string.Empty;
    bool SubmenuB1 = true;
    await Task.Delay(2500);
    Console.Clear();
    do
    {
        Console.WriteLine("Opciones de editar 'Stock'");
        Console.WriteLine("1.-Añadir nuevo tipo de 'Stock'");
        Console.WriteLine("2.-Modificar un tipo de 'Stock'");
        Console.WriteLine("3.-Eliminar un tipo de 'Stock'");
        Console.WriteLine("4.-Volver al menú pricipal");
        _opcSubmenuB1 = Console.ReadLine();
        switch (_opcSubmenuB1)
        {
            case "1":
                Console.WriteLine("Se eligío añadir nuevo tipo de 'Stock'");
                await Task.Delay(2500);
                break;

            case "2":
                Console.WriteLine("Se eligío modificar un tipo de 'Stock'");
                await Task.Delay(2500);
                break;

            case "3":
                Console.WriteLine("Se elígio eliminar un tipo de 'Stock'");
                await Task.Delay(2500);
                break;

            case "4":
                Console.WriteLine("Se eligío volver al menú pricipal");
                await Task.Delay(2000);
                SubmenuB1 = false;
                break;

            default:
                Console.WriteLine("La opción elegida no existe");
                await Task.Delay(2500);
                break;
        }
        await Task.Delay(1200);
        Console.Clear();
    }
    while (SubmenuB1);
}
async Task SubmenuB2()
{
    string _opcSubmenuB2 = string.Empty;
    bool SubmenuB2 = true;
    await Task.Delay(2500);
    Console.Clear();
    do
    {
        Console.WriteLine("Opciones de editar 'Prioridad'");
        Console.WriteLine("1.-Añadir nueva clasificación de 'Prioridad'");
        Console.WriteLine("2.-Modificar una clasificación de 'Prioridad'");
        Console.WriteLine("3.-Eliminar una clasificación de 'Prioridad'");
        Console.WriteLine("4.-Volver al menú pricipal");
        _opcSubmenuB2 = Console.ReadLine();
        switch (_opcSubmenuB2)
        {
            case "1":
                Console.WriteLine("Se eligío añadir nueva clasificación de 'Prioridad'");
                await Task.Delay(2500);
                break;

            case "2":
                Console.WriteLine("Se eligío modificar una clasificación de 'Prioridad'");
                await Task.Delay(2500);
                break;

            case "3":
                Console.WriteLine("Se elígio eliminar una clasificación de 'Prioridad'");
                await Task.Delay(2500);
                break;

            case "4":
                Console.WriteLine("Se eligío volver al menú pricipal");
                await Task.Delay(2000);
                SubmenuB2 = false;
                break;

            default:
                Console.WriteLine("La opción elegida no existe");
                await Task.Delay(2500);
                break;
        }
        await Task.Delay(1200);
        Console.Clear();
    }
    while (SubmenuB2);
}

//creación de la función que imprimira la info de los SP
async Task ImprimirElementos(List<StoredProcedure1> _LitasInventory)
{
    int count = 0;
    int limit = 5;
    int _index = 0;
    string _OpcMov = string.Empty;
    do
    {
        do
        {
            // si el indice es menor al numero de elementos en la lista
            if (_index < _LitasInventory.Count)
            {   
                //se imprime un borde superior
                Console.WriteLine("77777777");
                //se debe imprimir un solo elemento de la lista en la posicion del indice actual
                Console.WriteLine($"IdItem: {_LitasInventory[_index].IdItem}; ItemName: {_LitasInventory[_index].ItemName}; Stock: {_LitasInventory[_index].Stock}; TypePriorityName: {_LitasInventory[_index].TypePrioritaryName}; TypeStockName: {_LitasInventory[_index].TypeStockName}; PurchesDate: {_LitasInventory[_index].PurchesDate}; ExpirationDate: {_LitasInventory[_index].ExpirationDate};");
                //se incrementa el index +1
                _index++;
                //se imprime borde inferior
                Console.WriteLine("77777777");
                //se genera un espacio de separación
                Console.WriteLine("");
            }
            //se incrementa el contador
            count++;
        //evalua el ciclo mientras el contador sea menor que el limite
        }while (count < limit);

        Console.WriteLine("");
        Console.WriteLine("Para ver los siguientes 5 oprima n.");
        Console.WriteLine("Para volver al menu oprima q");
        Console.WriteLine("Para buscar por Id oprima f");
        Console.WriteLine("");
        _OpcMov = Console.ReadLine();
        switch (_OpcMov)
        {
            //se crea la opción para ir visualizando la información 
            case "n":
                count = 0;
                Console.Clear();
                break;
            //la opción para salir de la visualización
            case "q":
                break;
            //se manda a llamar la función de busqueda por Id
            case "f":
                await BuscarArticulo(_LitasInventory);
                break;
            //opción de control para evitar problemas al interactuar el usuario con el programa
            default:
                Console.WriteLine("La opción no existe");
                _index = 0;
                await Task.Delay(1000);
                break;
        }
    } while (_OpcMov != "q");
}
//fin del ciclo de visualización

//se crea la función buscar por Id
async Task BuscarArticulo(List<StoredProcedure1> _LitasInventory)
{
    //comando para limpiar la pantalla anterior
    Console.Clear ();
    //se crea la cadena para identificar la función
    string _OptBuscarArt = string.Empty;
    //se indica que la cadena de busqueda es un num entero que partira de cero
    int _IdBuscado = 0;
    //inicia el ciclo de la función de busqueda
    do
    {

        Console.WriteLine("Ingrese el Id numérico que desea buscar");
        Console.WriteLine("Para finalizar la busqueda oprima q");
        _OptBuscarArt = Console.ReadLine();
        Console.Clear();
        switch ( _OptBuscarArt)
        {
            //opción para salir de la busqueda
            case "q":
                break;
            //la opción para buscar por Id
            default:
                //expresión lamda usada para combertir los datos del sp para poder buscarlos
                _IdBuscado = Convert.ToInt32(_OptBuscarArt);
                //expresión para obtener el primer de los elementos que concuerde con los parametros de busqueda
                //en este caso el Id
                var ArtBuscado = _LitasInventory.FirstOrDefault( e => e.IdItem == _IdBuscado);
                if( ArtBuscado != null )
                {
                    //lineas que se imprimiran en pantalla si existe el objeto buscado
                    Console.WriteLine("3333333");
                    Console.WriteLine($"IdItem: {ArtBuscado.IdItem}; ItemName: {ArtBuscado.ItemName}; Stock: {ArtBuscado.Stock}; TypePriorityName: {ArtBuscado.TypePrioritaryName}; TypeStockName: {ArtBuscado.TypeStockName}; PurchesDate: {ArtBuscado.PurchesDate}; ExpirationDate: {ArtBuscado.ExpirationDate}");
                    Console.WriteLine("3333333");
                    Console.WriteLine("");
                    Console.Clear();
                }
                else
                {
                    //lineas que se imprimiran si no existe el objeto buscado
                    Console.WriteLine("Id de articulo incorrecto");
                }
                break;
        }
    }while(_OptBuscarArt != "q");
}
//fin de loop 'comando de busqueda'