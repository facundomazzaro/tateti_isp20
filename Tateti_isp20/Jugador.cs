using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tateti_isp20
{
    public class Jugador
    {
        //declaramos las propiedades, como fichas//
        public Hashtable fichas;
        //string es el tipo de ficha con el que juega//
        public string tipo_ficha;
        //es el metodo constructor,
        public Jugador(string tipoficha)
        {
            //inicializamos valore//
            fichas = new Hashtable();
            //el jugador tiene 3 fichas con posicion 0//
            fichas.Add(1, 0);
            fichas.Add(2, 0);
            fichas.Add(3, 0);
            tipo_ficha = tipoficha;
        }
    }
}
