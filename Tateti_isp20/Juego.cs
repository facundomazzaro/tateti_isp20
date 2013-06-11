using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tateti_isp20
{
    public class Juego
    {
        private Tablero tablero;
        private Jugador jugador1;
        private Jugador jugador2;

        public Juego()
        {
            tablero = new Tablero();
            jugador1 = new Jugador("x");
            jugador2 = new Jugador("0");
        }
        public void PintarTablero()
        {
            tablero.Limpiar();

            //y recorre la ficha de los jugadores y va grabando//
            //en las pocicones del tablero el tipo de ficha de los jugadores//
            //usamos ficha.value para saber la pocision q tiene definida ese jugador//
            foreach (DictionaryEntry ficha in jugador1.fichas)
            {
                tablero.posiciones[ficha.Value] = jugador1.tipo_ficha + ficha.Key.ToString();
            }
            //recorremos el diccionario del jugador 2//
            foreach (DictionaryEntry ficha in jugador2.fichas)
            {
                tablero.posiciones[ficha.Value] = jugador2.tipo_ficha + ficha.Key.ToString();
            }
            tablero.Pintar();
        }
        public int SeleccionarFicha(int jugador_actual)
        {
            int ficha_a_mover = 0;
            Console.Write("jugador {0}: ingrese el numero de ficha a mover:", jugador_actual);
            try
            {
                ficha_a_mover = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("error, valor incorrecto");
                Console.ReadKey();
                SeleccionarFicha(jugador_actual);
            }
            return ficha_a_mover;
        }
            
        public void Jugar(int jugador, int nroficha, int pos_elegida)
        {
            //al jugador 1 de la ficha 1 le asigna la posicion elegida//
            if (jugador == 1)
                jugador1.fichas[nroficha] = pos_elegida;
            else
                jugador2.fichas[nroficha] = pos_elegida;
            //limpia el tablero//
        }
    }
}

        
           
    
    
