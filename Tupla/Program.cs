

namespace Tupla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo de dato Tupla
            //Sabe que es una tupla por los parentesis ()
            //Tupla es un tipo de dato que permite almacenar varios elementos de diferentes tipos, es decir, una tupla es una colección de objetos que no necesariamente tienen que ser del mismo tipo.
            (int id, string nombre) producto = (1, "Cerveza Modelo Especial");
            //definimos el tipo de dato de la tupla y le asignamos valores. producto es el nombre de la tupla, id y nombre son los nombres de los elementos de la tupla y 1 y "Cerveza Modelo Especial" son los valores de los elementos de la tupla.
            Console.WriteLine($"Id: {producto.id}, Marca: {producto.nombre}");
            //Las tuplas son editables, es decir, podemos cambiar el valor de los elementos de la tupla.
            producto.nombre = "Cerveza Victoria"; //Antes era "Cerveza Modelo Especial" y ahora es "Cerveza Victoria"
            Console.WriteLine($"Id: {producto.id}, Marca: {producto.nombre}");

            var Persona = ("Cesar", 25); //Definimos una tupla con var
            //var sabe que tipo de dato es cada elemento de la tupla
            //Sabe que es una tupla por los parentesis ()
            //Para imprimir una tupla con var, se puede hacer de la siguiente manera
            Console.WriteLine($"Nombre: {Persona.Item1}, Edad: {Persona.Item2}");
            //Item1 y Item2 son los nombres de los elementos de la tupla, en este caso, Item1 es el nombre y Item2 es la edad.
            //Item1 y Item2 son las posiciónes de los elementos de la tupla, es decir, Item1 es el primer elemento de la tupla y Item2 es el segundo elemento de la tupla.

            //Arreglo de tuplas
            var Personas = new[]
            {
                (1,"Jorge"),
                (2,"Cesar"),
                (3,"Luis"),
                (4,"Ana")
                //("Karen",5) --> Error, no se puede agregar una tupla con elementos de diferente tipo
                //("Paola",6,3.1416) --> Error, no se puede agregar una tupla con diferente cantidad de elementos
            };
            //Un arreglo de tuplas, cada elemento del arreglo es una tupla
            //Debe tener los mimos tipos de datos y posiciones que las tuplas que lo conforman
            Console.WriteLine("\nArreglo de personas con tuplas:");
            foreach (var P in Personas)
            {
                Console.WriteLine($"Id: {P.Item1}, Nombre: {P.Item2}");
            }

            Console.WriteLine("\nArray de tuplas especificadas:");
            //Un Array de tuplas especificada
            (int id, string nombre)[] Personas2 = new[]
            {
                (5,"Manuel"),
                (6,"Mariana"),
                (7,"Orion")
            }; //Array de tuplas especificada

            foreach (var p2 in Personas2)
            {
                Console.WriteLine($"Id: {p2.id}, Nombre: {p2.nombre}");
            }


            //Obtener los valores de un metodo static que usa tupla para guardar informacion
            Console.WriteLine("\nTupla en metodos:");
            var CDMXInfo = getInfo();
            Console.WriteLine($"Latitud: {CDMXInfo.lat}, Longitud: {CDMXInfo.lng}, Nombre: {CDMXInfo.name}");

            //Ignorar valores en un metodo que usa tupla
            var (_,lng,_) = CDMXInfo; //El guion bajo _ ignora los valores de la tupla
            Console.WriteLine($"Longitud: {lng}"); //Forma par obtener un valor e ignorar los demas

        } //fin de Main


    //Metodo static y usando una tupla
    public static (float lat, float lng, string name) getInfo()
        {
            float lat = 19.312312f;
            float lng = -99.31232f;
            string name = "CDMX";

            return (lat, lng, name);
        }
    } //Fin de class Program

}//Fin de Tupla