using Billetes;
namespace Cotizador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Euros dineroEuros2 = 50;
            Pesos dineroPesos2 = 6005.025;
            Dolar dineroDolar = 200;

            Pesos dineroPesos = 0;
            Euros dineroEuros = 0;

            dineroPesos += dineroDolar;
            dineroEuros += dineroDolar;


            Console.WriteLine($"La plata total en Pesos es: {dineroPesos.GetCantidad}");
            Console.WriteLine($"La plata total en Euros es: {dineroEuros.GetCantidad}");
            Console.WriteLine($"Son iguales entre el euro y el peso: {dineroEuros == dineroPesos}");
        }
    }
}