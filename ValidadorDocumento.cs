using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionDocumento
{
    class ValidadorDocumento
    {
        //Aqui estan definidos los atributos - el estado

        private string tipo, genero, estadoValidacion;
        private long numero;
        private bool esValido;

        //Aqui definimos los metodos - los comportamientos

        //Aqui viene el contructor
        public ValidadorDocumento()
        {
            tipo = "No se ha definido";
            numero = 0;
            genero = "No ingresado";
            esValido = false;
            estadoValidacion = "No se pudo validar";
        }

        public long Numero
        {
            get { return numero; }
            set {
                if (value >= 0)
                    numero = value;

            }
        }
        public bool EsValido
        {
            get { return esValido; }
        }
        public string Genero
        {
            get { return genero; }
            set
            {
                if (value == "M" || value == "F")
                {
                    genero = value;
                }
                else
                {
                    esValido = false;
                    estadoValidacion = "Incorrecto por genero erroneo";
                }
            }
        }

        private void EjecutaValidador()
        {
            //Se necesita longitud del numero del documento
            int longitud = numero.ToString().Length;

            //variable "flag" para indicar si se fallo una validacion
            bool estaComprobado = true;
            //Se implementa la regla 1
            //cedula, hombre, logitud entre 3 y 8, rangos entre
            //1 y 19.999.999 y 70.000.000 y 90.999.999
        }
    }
}
