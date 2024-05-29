using System.Runtime.InteropServices;

namespace FINAL_Gimnasio;

public class Cliente
{
    public string Nombre = " ";
    public string Apellido = "";
    public  int nMembresia = 0;

    public string TipoMembresia = " ";    // verifica si la membresia esta activa o no
 


 //Inicialización de las propiedades del cliente
    public Cliente(string Nombre, string Apellido, int nMembresia, string tipoMembresia ){

        this.Nombre= Nombre;    
        this.Apellido= Apellido; 
        this.TipoMembresia= tipoMembresia;
        this.nMembresia= nMembresia;
        
    }
}