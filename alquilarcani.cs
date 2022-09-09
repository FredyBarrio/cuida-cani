//clase principal
public class alquilar_cani {
public static void Main(String[]args){
perro Vicente =new perro();
//Configurar nombre
    Vicente.setnombre("Vicente");
//Configurar Autor
    Vicente.setRaza("Sabueso");
//Configurar altura
    Vicente.setaltura(37);
//Configurar color
    Vicente.setcolor("Tricolor");
//Configurar genero
    Vicente.setgenero("Hembra");
    perro Rocky = new perro();
    
//Configurar nombre
    Rocky.setnombre("Rocky");
//Configurar Autor
    Rocky.setRaza("Labrador");
//Configurar altura
    Rocky.setaltura(58);
//Configurar color
    Rocky.setcolor("Negro");
//Configurar genero
    Rocky.setgenero("Macho");
//Lee unos valores, los convierte y los muestra en pantalla

//Lee unos valores, los convierte y los muestra en pantalla


Console.WriteLine("Quires alquilar un perro de caza ");
Console.WriteLine("1. Si");
Console.WriteLine("2. NO");
            int respuesta = Convert.ToInt32(Console.ReadLine ());
if (respuesta==1 ) {
            Vicente.tostring();
            Rocky.tostring();
            Console.WriteLine ("Que perro Quieres Alquilar");
            Console.WriteLine ("Cual elijes");
            Console.WriteLine ("1. Vicente");
            Console.WriteLine ("2. Rocky");
            Console.WriteLine ("3. salir");
            int Opcion = Convert.ToInt32( Console.ReadLine ());
 
           switch (Opcion)
    {
        case 1:
            Console.WriteLine("Elejiste a vicente");
           
            break;

        case 2:
            Console.WriteLine("Elejiste a Rocky");
            
            break;
       
        case 3: 
        
          Console.WriteLine ("salir");
           break;
        default:
            Console.WriteLine("incorrecto");
            break;
    }
            } else {
                Console.WriteLine ("salir");
            }

    }
}