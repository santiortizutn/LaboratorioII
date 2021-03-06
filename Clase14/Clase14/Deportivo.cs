﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioInterfaces
{
    public class Deportivo:Auto,IAFIP,IARBA
    {
        private int _caballosFuerza;

        public Deportivo(double precio, string patente, int hp):base(precio,patente)
        {
            this._caballosFuerza = hp;
        }
        public override void MostrarPatente()
        {
            Console.WriteLine("Patente: " + this._patente);
        }
        public override double Precio
        {
            get
            {
                return base.Precio + this.CalcularImpuesto();
            }
            set
            {
                base.Precio = value;
            }
        }


        public double CalcularImpuesto()
        {
            return this._precio * 1.28;
        }



        double IARBA.CalcularImpuesto()
        {
            return this._precio * 1.23;
        }
    }
}
