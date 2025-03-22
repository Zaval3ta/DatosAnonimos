

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto anónimo
            //Es un objeto que no tiene un tipo definido. No necesitas definir una clase para crear un objeto.
            var persona = new
            {
                Nombre = "Juan",
                Pais = "México",
            }; // Fin de la declaración de persona
            Console.WriteLine($"Nombre: {persona.Nombre} Pais: {persona.Pais}");
            //El objeto anonimo solo es de lectura, no se puede modificar su contenido

            //Coleccion de objetos anónimos
            var cervezas = new[]
            {
                //Los objetos anonimos de una coleccion deben tener la misma estructura o propiedades
                new { Nombre = "Victoria", Marca = "Grupo Corona" },
                new { Nombre = "Negra Modelo", Marca= "Grupo Modelo" },
                new { Nombre = "Corona", Marca = "Grupo Corona" }
            }; // Fin de la declaración de personas

            Console.WriteLine("\nColeccion de objetos anonimos:\n");
            foreach (var cerveza in cervezas)
            {
                Console.WriteLine($"Cerveza: {cerveza.Nombre} Marca: {cerveza.Marca}");
            } // Fin de la iteración de cervezas

        }// Fin de Main


    } // Fin de la clase Program


} // Fin del namespace TiposAnonimos