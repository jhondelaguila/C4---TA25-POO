using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico electrodomestico1 = new Electrodomestico();
            Console.WriteLine("Electrodomestico 1:");
            Console.WriteLine($"Precio Base: {electrodomestico1.PrecioBase}");
            Console.WriteLine($"Color: {electrodomestico1.Color}");
            Console.WriteLine($"Consumo Energético: {electrodomestico1.ConsumoEnergetico}");
            Console.WriteLine($"Peso: {electrodomestico1.Peso}");
            Console.WriteLine();

            Electrodomestico electrodomestico2 = new Electrodomestico(200, 10);
            Console.WriteLine("Electrodomestico 2:");
            Console.WriteLine($"Precio Base: {electrodomestico2.PrecioBase}");
            Console.WriteLine($"Color: {electrodomestico2.Color}");
            Console.WriteLine($"Consumo Energético: {electrodomestico2.ConsumoEnergetico}");
            Console.WriteLine($"Peso: {electrodomestico2.Peso}");
            Console.WriteLine();

            Electrodomestico electrodomestico3 = new Electrodomestico(300, "negro", 'A', 15);
            Console.WriteLine("Electrodomestico 3:");
            Console.WriteLine($"Precio Base: {electrodomestico3.PrecioBase}");
            Console.WriteLine($"Color: {electrodomestico3.Color}");
            Console.WriteLine($"Consumo Energético: {electrodomestico3.ConsumoEnergetico}");
            Console.WriteLine($"Peso: {electrodomestico3.Peso}");
        }
    }
}
