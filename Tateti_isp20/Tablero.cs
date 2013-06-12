using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tateti_isp20
{
    //comentario 3//
   public class Tablero
    {
       public Hashtable posiciones;
       public Tablero()
       {
           //agrega una posicion//
           posiciones = new Hashtable();
           //inicializamos las 9 posiciones conn el valor vacio//
           for (int i = 1; i < 10; i++)
           {
               posiciones.Add(i, "  ");
           }
          
       }
       //borro la consola//
       public void Limpiar()
       {
           for (int i = 1; i < 10; i++)
           {
               posiciones[i] = "  ";
           }
       }
       public void Pintar()
       {
            //borra la consola//
            Console.Clear();
            //imprimo el tablero y cada una de las posiciones//
            for (int i=1; i<10; i++)
            {
                Console.Write("[ {0} ]", posiciones[i]);
                //utilizamos el modulo para detectar que ya se imprimieron 3 casilleros y 
                //generamos un salto de linia//
                if (i % 3 == 0)
                {
                    Console.Write("\n");
                }
            }
        }
            
    }
}
