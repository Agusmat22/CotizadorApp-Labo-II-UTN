using Billetes;
namespace Cotizador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  MODELO DE PRUEBA UNO
             *  
             *  
            Euros dineroEuros2 = 50;
            Pesos dineroPesos2 = 6005.025;
            Dolar dineroDolar = 200;

            Pesos dineroPesos = dineroDolar;
            Euros dineroEuros = dineroDolar;
            Dolar dineroPrueba = dineroPesos2;

            
            dineroPesos += dineroDolar;
            dineroEuros += dineroDolar;
            

            Console.WriteLine($"La plata total en Pesos es: {dineroPesos.GetCantidad}");
            Console.WriteLine($"La plata total en Euros es: {dineroEuros.GetCantidad}");
            Console.WriteLine($"Son iguales entre el euro y el peso: {dineroEuros == dineroPesos}");
            Console.WriteLine($"El valor de pesos a dolares es: {dineroPrueba.GetCantidad}");  
            */

            Euros dineroEuro = 50;
            Dolar dineroDolar = 100;
            Pesos dineroPeso = 20000;

            Dolar pruebaDolar = dineroPeso;

            Euros pruebaEuro = dineroPeso;

            Pesos pruebaPeso = dineroDolar;

            Console.WriteLine($"La plata dolares es: {pruebaDolar.GetCantidad}");
            Console.WriteLine($"La plata euros es: {pruebaEuro.GetCantidad}");
            Console.WriteLine($"La plata pesos es: {pruebaPeso.GetCantidad}");

            Console.WriteLine($"El dinero en euro y en dolares es el mismo? : {pruebaEuro == pruebaDolar}");
            Console.WriteLine($"El dinero en dolares y en pesos es el mismo? : {pruebaDolar == pruebaPeso}");


        }
    }
}