
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using FINAL_Gimnasio;

class Program 
{
    static Cliente usuario; //creacion devariable para almacenar el usuario
    public static void Main(String[] args)
    {
        
        Instalaciones instalaciones= new Instalaciones();
        Clases clases= new Clases();

        string rep = " "; 
        
        Console.WriteLine("                                                                        ");
        Console.WriteLine("-----------------------GIMNASIO C3NTRO----------------------------------");
        Console.WriteLine("                                                                        ");
        string opcion2 = " "; //regresar al menu
      

        // ciclo que imprime el menu interactivo
        do
        {
            Console.WriteLine("-----------------------Menu de inicio-------------------------------");
            Console.WriteLine("Ingrese la opcion que desea");
            Console.WriteLine("                                                                    ");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("1. Ingresar datos del usuario");
            Console.WriteLine("2. Mostrar datos del usuario ingresado");
            Console.WriteLine("3. Salir");
            Console.WriteLine("--------------------------------------------------------------------");
            string opcion = Console.ReadLine();

            // utlizar bucles en donde las condiciones que cumpla de a cuerdo a la opcion seleccionada por el usuario 
            if (opcion == "1")
                {
                    ///Ingresar datos del usuario y aceptar unicamente letras
                    Console.WriteLine("Ingrese nombre");
                    string nombre = Console.ReadLine();
                    //parametrizar por medio de la variable declarada nombre
                    // donde cuando nombre sea diferente a lo anteriormente declarado (como letras) mostrara un error 
                    while (!nombre.All(char.IsLetter))
                    {
                        Console.WriteLine("No esta permitido, el nombre debe contener letras. Inténtelo nuevamente:");
                        nombre = Console.ReadLine();
                    }

                    Console.WriteLine("Ingrese apellido");
                    string apellido = Console.ReadLine();
                    //parametrizar por medio de la variable declarada apellido
                    // donde cuando apellido sea diferente a lo anteriormente declarado (como letras) mostrara un error
                    while (!apellido.All(char.IsLetter))
                    {
                        Console.WriteLine("No esta permitido, el nombre debe contener letras. Inténtelo nuevamente:");
                        apellido = Console.ReadLine();
                    }
                    
                    Console.WriteLine("Ingrese numero de Membresia");
                    string num = Console.ReadLine();

                    // segun los parametros definidos en cliente, se guardaran los datos del usuario
                    usuario = new Cliente(" ", " ", 0, " ");
                    Console.WriteLine("Datos del usuario ingresados correctamente.");
                }
                else if (opcion == "2")
                //mostrar unicamente cuando el usuario sea diferente a null
                { if (usuario != null)
                    {
                        //mostrar los valores ingresados del usuario anteriormente
                        Console.WriteLine("Datos del usuario ingresado:");
                        Console.WriteLine($"Nombre: {usuario.Nombre}");
                        Console.WriteLine($"Apellido: {usuario.Apellido}");
                        Console.WriteLine($"Número de Membresía: {usuario.nMembresia}");
                        Console.WriteLine($"Tipo de Membresía: {usuario.TipoMembresia}");
                    }
                    else
                    {// mostrar unicamente cuando en el menu la primera seleccion es la opcion 2 ya que no habran datos que mostrar
                        Console.WriteLine("No se ha ingresado ningún usuario.");
                    }
                }// opcion 3 salir
                else if (opcion == "3")
                {
                    break;
                }
            
 
            Console.WriteLine("----------------------------Menu Interactivo-----------------------");
            Console.WriteLine("Ingrese el numero de la opcion que desea");
            Console.WriteLine("1.) Listado de clientes con membresia activa");
            Console.WriteLine("2.) Consultar catalogo clases");
            Console.WriteLine("3.) Listado de instalaciones Disponibles");
            Console.WriteLine("4.) Salir del programa");
            int opcionn = Convert.ToInt32(Console.ReadLine());
    ///mostrar esta opcion unicamente cuando la opcion se mayor a cero ya que de lo contrariola opcion no sera valida
                if(opcionn >= 0)
                {
                    switch (opcionn)
                    {

                    case 1:
                    Console.WriteLine("----------Clientes con membresia activa----------");

                
                    break;

                    case 2: //mostrar datos segun lo establecido en la clase
                    Console.WriteLine("----------Catalogo clases------------------------");
                    clases.MostrarClases();
                
                    break;
                    
                    case 3://mostrar datos segun lo establecido en la clase
                    Console.WriteLine("----------Listado de instalaciones Disponibles----------");
                    instalaciones.MostrarInstalacionesDispo();
            
                    break;

                    case 4: //mostrar datos segun lo establecido en la clase
                    Console.WriteLine("--------------Saliendo del programa");

                    break;
                    default : 
                    Console.WriteLine("Opcion no valida");
                    break ;
                    } 

                }else
                Console.WriteLine("Desea volver al menu?");
                rep = Console.ReadLine(); // si la respuesta es igual a si 
        }  while  (rep == "si");
    }

}    
