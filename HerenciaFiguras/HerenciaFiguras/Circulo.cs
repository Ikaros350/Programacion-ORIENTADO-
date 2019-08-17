using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFiguras
{
    class Circulo : Figura
    {
        private int radio;

        public Circulo()
        {
            radio = 0;
        }
        
        public Circulo(int p_Radio)// polimorfismo por sobre carga
        {
            radio = p_Radio;
        }

        public int Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public override string Info() //Sobreescritura
        {
            //base es solo se usa para que los hijos invoquen algo del padre
            string resultado = base.Info() +
                "\nEl circulo tiene radio de "+ radio;
            return resultado;
        }
        public new string ObtieneArea()// ocultamiento
        {
            float area = (float)(Math.PI * Math.Pow(radio, 2));
            string mensaje = "El area del circulo es " + area.ToString("0.00");
            return mensaje;
        }
    }
}
