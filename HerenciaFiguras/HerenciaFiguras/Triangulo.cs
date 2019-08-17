using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFiguras
{
    class Triangulo : Figura // Tiene las propiedades de una figura
    {
        private string v_tipo;
        private int v_base, v_altura;

        /// <summary>
        /// CONSTRUCTOR BASICO DE LA CLASE TRIANGULO
        /// </summary>


            // aca es la primera sobrecarga
        public Triangulo() // no recibe parametros
        {
            v_tipo = "";
            v_base = 0;
            v_altura = 0;
            centroX = 10;
            centroY = 10;
            
        }
        /// <summary>
        /// Constructor de la clase parametro
        /// </summary>
        /// <param name="p_cx"></param>
        /// <param name="p_cy"></param>
        public Triangulo(int p_cx, int p_cy) // si recibe parametros
        {
            v_tipo = "";
            v_base = 0;
            v_altura = 0;
            centroX = p_cx;
            centroY = p_cy;
        }
        /// <summary>
        /// Constructor con datos de centro, altura y base
        /// </summary>
        /// <param name="p_altura">altura del triangulo</param>
        /// <param name="p_base">base del triangulo</param>
        /// <param name="p_cx">coordenada en x del centro</param>
        /// <param name="p_cy">coordenada y del centro</param>
        public Triangulo(string p_tipo, int p_altura, int p_base, int p_cx, int p_cy)
        {
            v_tipo = p_tipo;
            v_base = p_base;
            v_altura = p_altura;
            centroX = p_cx;
            centroY = p_cy;
        }

        private int V_Base
        {
            get { return v_base; }
            set { v_base = value; }
        }

        public string V_Tipo
        {
            get { return v_tipo; }
            set { v_tipo = value; }
        }
        public int V_Altura
        {
            get { return v_altura; }
            set { v_altura = value; }
        }
        public override string Info() //sobreescritura
        {
            //base es solo se usa para que los hijos invoquen algo del padre
            string resultado = base.Info() + 
                "\nLa triangulo tiene base "+v_base+" altura "+v_altura+"\nEs de tipo "+v_tipo+"  "+ObtieneArea();
            return resultado;
        }
        public new string ObtieneArea() // no marcado con el virtual es decir se tiene que hacer con new
        {
            float area = (float)(v_base * v_altura) / 2;
            string mensaje = "El area es del triangulo es "+ area.ToString("0.00");
            return mensaje;
        }
    }
}
