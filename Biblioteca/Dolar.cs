using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        //genero sobrecargar de constructor

        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;

        }

        public Dolar(double cantidad)
        {

            this.cantidad = cantidad;
        }

        

        //Genero los metodos get, pero en esta ocasion los vamos a reemplazar por propiedades
        //tipo PROPERTY
        public double GetCantidad
        {
            get
            {
                return cantidad;
            }
        }

        public static double GetCotizacion
        {
            get
            {
                return cotzRespectoDolar;
            }
        }

        public double ConversionDolar()
        {

            return cantidad * cotzRespectoDolar;

        }

        public static double ConversionEuro(double dolares)
        {

            return dolares / cotzRespectoDolar;

        }

        //GENERO LA SOBRECARGA IMPLICITA y retorna el valor ingresado
        public static implicit operator Dolar(double dinero)
        {
            return new Dolar(dinero);

        }

        public static bool operator ==(Dolar dinero, Pesos dinero2)
        {
            return dinero.GetCantidad == dinero2.ConversionDolar();

        }

        public static bool operator !=(Dolar dinero, Pesos dinero2)
        {
            return dinero.GetCantidad != dinero2.ConversionDolar();

        }

        public static bool operator ==(Dolar dinero, Euros dinero2)
        {
            return dinero.GetCantidad == dinero2.ConversionDolar();

        }

        public static bool operator !=(Dolar dinero, Euros dinero2)
        {
            return dinero.GetCantidad != dinero2.ConversionDolar();

        }


        public static Dolar operator + (Dolar dinero, Pesos dinero2)
        {
            double sumarDolares = dinero.GetCantidad + dinero2.ConversionDolar();

            return ConversionEuro(sumarDolares);

        }

    }
}
