using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Clase base
public class Animal
{
    public string Nombre { get; set; }

    public void Comer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }
}

// Clase que hereda de Animal
public class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} está ladrando.");
    }
}

