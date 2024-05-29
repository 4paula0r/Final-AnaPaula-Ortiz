using System.Runtime.InteropServices;
using System.Web;

namespace FINAL_Gimnasio;

public class Instalaciones
{

    public string NombreInstalacion= " ";
    //creacion un arreglo  para guardar las instalaciones
    public Instalaciones[] instalaciones;
    

    public Instalaciones (string NombreInstalacion){
        
        this.NombreInstalacion = NombreInstalacion;
   
    }
    public Instalaciones()
        {
            instalaciones = new Instalaciones[6];
            //Asignarle un valor a el nombre de la clase
            instalaciones[0] = new Instalaciones("Sede zona 1 Ciudad de Guatemala");
            instalaciones[1] = new Instalaciones("Sede zona 2 Ciudad de Guatemala");
            instalaciones[2] = new Instalaciones("Sede zona 11 Ciudad de Guatemala");
            instalaciones[3] = new Instalaciones("Sede zona 7 Ciudad de Guatemala");
            instalaciones[4] = new Instalaciones("Sede zona 18 Ciudad de Guatemala");
            instalaciones[5] = new Instalaciones("Sede zona 15 Ciudad de Guatemala");
        }

        //creacion de funcion para mostrar las clases disponibles
        public void MostrarInstalacionesDispo() 
        {
            for (int i = 0; i < instalaciones.Length; i++)
            {
                Console.WriteLine($"{instalaciones[i].NombreInstalacion}");
          
            }
        }

}