namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        //genero sobrecargar de constructor

        static Pesos()
        {
            Pesos.cotzRespectoDolar = 102.65;

        }

        public Pesos()
        {

            this.cantidad = 0;
        }


        public Pesos(double cantidad)
        {

            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotzRespectoDolar): this(cantidad)
        {
            Pesos.cotzRespectoDolar = cotzRespectoDolar;
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

        public static double SetCotizacion
        {
            set
            {
                cotzRespectoDolar = value;
            }
        }

        public double ConversionDolar()
        {

            return cantidad / cotzRespectoDolar; 

        }

        private static double ConversionPesos(double dolares)
        {
            return dolares * cotzRespectoDolar;
        }

        public static double GetCotizacion
        {
            get
            {
                return cotzRespectoDolar;
            }
        }

        //GENERO LA SOBRECARGA IMPLICITA y retorna el valor ingresado
        public static implicit operator Pesos(double dinero) 
        { 
            return new Pesos(dinero);
        
        }

        public static implicit operator Pesos(Euros euro)
        {

            return ConversionPesos(euro.ConversionDolar());         

        }

        public static implicit operator Pesos(Dolar dolar)
        {

            return ConversionPesos(dolar.GetCantidad);

        }
        

        public static bool operator == (Pesos dinero,Euros dinero2)
        {
            return dinero.ConversionDolar() == dinero2.ConversionDolar();

        }

        public static bool operator != (Pesos dinero, Euros dinero2)
        {
            return dinero.ConversionDolar() != dinero2.ConversionDolar();

        }

        public static Pesos operator +(Pesos dinero, Euros dinero2)
        {
            double sumarDolares = dinero.ConversionDolar() + dinero2.ConversionDolar();

            return ConversionPesos(sumarDolares);

        }

        public static Pesos operator +(Pesos dinero, Dolar dinero2)
        {
            double sumarDolares = dinero.ConversionDolar() + dinero2.GetCantidad;

            return ConversionPesos(sumarDolares);

        }









    }
}