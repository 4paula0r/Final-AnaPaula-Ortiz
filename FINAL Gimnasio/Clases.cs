namespace FINAL_Gimnasio;

public class Clases
{

    //crear una variable para definir el nombre de la clase
    public string nombreClase= " "; 
     //Arreglo con la longitud de clases del catálogo.
    public Clases[] clases; 


  //creacion del metodo constructor para las clases 
    // constructor que inicialice las propiedades de nombreClase
    public Clases(string nombreClase)
    {
        this.nombreClase = nombreClase;
    }

        public Clases()
        {

            //Asignarle un valor a a cada arreglo con el nombre de la clase
            clases = new Clases[6];
            clases[0] = new Clases("Yoga");
            clases[1] = new Clases("Crossfit");
            clases[2] = new Clases("Funcional");
            clases[3] = new Clases("Pilates");
            clases[4] = new Clases("Kickboxing");
            clases[5] = new Clases("Zumba");


        }
        //creacion de funcion para mostrar las clases disponibles
        public void MostrarClases() 
        {
            for (int i = 0; i < clases.Length; i++)
            {
                Console.WriteLine($"{clases[i].nombreClase}");
          
            }
        }

}