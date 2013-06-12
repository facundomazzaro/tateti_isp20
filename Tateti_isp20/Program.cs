using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tateti_isp20
{
    //comentario 1//
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();
            //los de abajo son dos variables//
            int jugador_actual=1;
            int ficha_actual=1;
            int ficha_a_mover = 0;
            int posicion_elegida = 0;

            while (true)
            {
                //llama al metodo pintar tablero//
                juego.PintarTablero();
                //cuando ya se colocaron las 6 fichas pide a definir las fichas a mover//
                //pide ingresar la ficha a mover//
                ///pregunta si ficha actual es igual a 0//
                if (ficha_actual == 0)
                {
                    ficha_a_mover = juego.SeleccionarFicha(jugador_actual);
                    Console.Write("jugador {0}: ingrese la posicion de la ficha {1}:", jugador_actual, ficha_a_mover);
                    posicion_elegida = Convert.ToInt32(Console.ReadLine());
                    juego.Jugar(jugador_actual, ficha_a_mover, posicion_elegida);
                }
                    //en las primeras 6 fichas se ejecuta esto//
                else
                {

                    //se escribe una opcion y se almasena en posicion elegida//
                    Console.Write("jugador {0}: ingrese la posicion de la ficha {1}:", jugador_actual, ficha_actual);
                    try
                    {

                        posicion_elegida = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("error, valor incorrecto");
                        continue;
                        Console.ReadKey();
                    }

                    //llamamos al metodo jugar y le pasamos jugador_actual, etc//
                    juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
                    //cambio del jugador//
                }
                jugador_actual++;
                //si el jugador actual es 3 q vuelva a se 1//
                if (jugador_actual == 3)
                {
                    jugador_actual = 1;
                    if (ficha_actual > 0)
                    {
                        //incrementa 1//
                        ficha_actual++;
                        if (ficha_actual == 4)
                            ficha_actual = 0;
                    }
                }
            }
        }
    }
}
