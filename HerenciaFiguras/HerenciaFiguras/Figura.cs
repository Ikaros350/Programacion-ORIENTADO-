using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFiguras
{
    class Figura
    {
        protected int centroX, centroY; //SOLO "PROTECTED" podran acceder a los que hagan parte de la Jerarquia

        public Figura() //constructor de clase
        {
            centroX = 0;
            centroY = 0;
        }

        public int CentroX
        {
            get { return centroX; }
            set { centroX = value; }
        }

        public int CentroY
        {
            get { return centroY; }
            set { centroY = value; }
        }

        public virtual string  Info() // metodo para acortar el console, y virtual es la sobre escritura de info
        {
            string resultado = "La figura tiene centro en (" +centroX+","+centroY+")";

            return resultado;
        }

        public string ObtieneArea()
        {
            string mensaje = "No hay informacion para realizar eso";
            return mensaje;
        }
    }
}
