﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euros
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        //genero sobrecargar de constructor

        static Euros()
        {
            Euros.cotzRespectoDolar = 1.17;

        }

        public Euros()
        {

            this.cantidad = 0;
        }

        public Euros(double cantidad)
        {

            this.cantidad = cantidad;
        }

        public Euros(double cantidad, double cotzRespectoDolar) : this(cantidad)
        {
            Euros.cotzRespectoDolar = cotzRespectoDolar;
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

        public static double SetCotizacion
        {
            set
            {
                cotzRespectoDolar = value;
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
        //OPERADORES IMPLICITOS DONDE REALIZAN LA CONVERSION DE EUROS A PESOS Y EUROS A DOLARES

        public static implicit operator Dolar(Euros dinero)
        {
            return dinero.ConversionDolar();
        }

        public static implicit operator Pesos(Euros dinero)
        {
            return dinero.ConversionDolar() * 102.65;

        }


        //GENERO LA SOBRECARGA IMPLICITA y retorna el valor ingresado
        public static implicit operator Euros(double dinero)
        {
            return new Euros(dinero);

        }

        //SOBRECARGA DE OPERADORES 
        
        public static bool operator ==(Euros dinero, Euros dinero2)
        {
            return dinero.cantidad == dinero2.cantidad;

        public static implicit operator Euros(Pesos peso)
        {
            return ConversionEuro(peso.ConversionDolar());
        }


        public static implicit operator Euros(Dolar dolar)
        {

            return ConversionEuro(dolar.GetCantidad);

        }


        }

        public static bool operator !=(Euros dinero, Euros dinero2)
        {
            return dinero.cantidad == dinero2.cantidad;

        }

        public static bool operator ==(Euros dinero, Pesos dinero2)
        {
            return dinero.ConversionDolar() == dinero2.ConversionDolar();

        }

        public static bool operator !=(Euros dinero, Pesos dinero2)
        {
            return dinero.ConversionDolar() != dinero2.ConversionDolar();

        }

        public static bool operator ==(Euros dinero, Dolar dinero2)
        {
            return dinero.ConversionDolar() == dinero2.GetCantidad;

        }

        public static bool operator !=(Euros dinero, Dolar dinero2)
        {
            return dinero.ConversionDolar() != dinero2.GetCantidad;

        }




        public static Euros operator +(Euros dinero, Pesos dinero2)
        {
            double sumarDolares = dinero.ConversionDolar() + dinero2.ConversionDolar();

            return ConversionEuro(sumarDolares);

        }

        public static Euros operator +(Euros dinero, Dolar dinero2)
        {
            double sumarDolares = dinero.ConversionDolar() + dinero2.GetCantidad;

            return ConversionEuro(sumarDolares);

        }

        public static Euros operator -(Euros dinero, Dolar dinero2)
        {
            double restaDolares = dinero.ConversionDolar() - dinero2.GetCantidad;

            return ConversionEuro(restaDolares);

        }

        public static Euros operator -(Euros dinero, Pesos dinero2)
        {
            double restaDolares = dinero.ConversionDolar() - dinero2.ConversionDolar();

            return ConversionEuro(restaDolares);

        }




    }
}
