
class Program
{
    static void Main(string[] args)
    {
        Perro miPerro = new Perro();
        miPerro.Nombre = "Noah";
        miPerro.Comer();  // Método heredado de la clase Animal
        miPerro.Ladrar(); // Método específico de la clase Perro

        Console.ReadKey();
    }
}

