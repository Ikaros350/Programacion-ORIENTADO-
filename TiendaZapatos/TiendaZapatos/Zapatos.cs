using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaZapatos
{
    class Zapatos
    {
        //atributos
        private int talla;
        private string color, estilo;

        //constructor
        public Zapatos()
        {
            talla = 0;
            color = "sin color";
            estilo = "horrible";
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }
        public int Talla
        {
            get { return talla; }
            set {
                if(value > 34 && talla <= 45)
                talla = value; }
        }

    }
}
