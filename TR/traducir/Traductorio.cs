using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.traducir
{
    public class Traductorio
    {
        private string entrada;
        public string[] kakchikel = { "jolomaj","xikinaj","tzamaj","eyaj","telemaj","tz´umaj","tz´ikaj","ruwi´ q´ab´aj","pamaj","pamaj" };
        public string[] español = { "cabeza", "oreja", "nariz", "diente", "hombro", "pecho", "codo","dedos","estómago","estomago"};
        public string[] noEncontrado = { "Palabra no encontrada :("};

        public string Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }

        private string salida;

        public string Salida
        {
            get { return salida; }
            set { salida = value; }
        }

        public string Traducir()
        {
            bool encontrar = false;
            int contador = 0;

            while (encontrar == false)
            {
                if (Entrada.Equals(español[contador]))
                {
                    salida = kakchikel[contador];
                    encontrar = true;
                }

                //if (!Entrada.Equals(español[contador]))
                //{
                //    salida = noEncontrado[contador];
                //    encontrar = true;
                //}
                contador++;
            }
            return salida;
        }
    }
}
