using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    public class SistemaClientes
    {
        ArrayList clientes = new ArrayList();

        public SistemaClientes()
        {
            Console.WriteLine("cargando el sistema del cliente");
        }
        public void Iniciar()
        {
            Menu();
        }
        private void ListarClientes()
        {
             foreach (Cliente cli in clientes)
                        {
                            cli.Listar();
                        }
        }
        private void BorrarCliente(int id_borrar)
        {
              foreach (Cliente cli in clientes)
                        {

                            if (cli.codigo == id_borrar)
                            {
                                clientes.Remove(cli);
                                break;
                            }
              }
        }                                                                                   
        private void Menu()
        {
            int opcion = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("CARGA DE CLIENTES");
                Console.WriteLine("1- cargar un nuevo cliente");
                Console.WriteLine("2- listar los clientes cargados");
                Console.WriteLine("3- borrar un cliente");
                Console.WriteLine("4- Salir");
                Console.WriteLine("ingrese la opcion");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("error de la opcion ingresada");

                }
                switch (opcion)
                {
                    case 1:
                        Cliente cliente = new Cliente();
                        cliente.CapturarDatos();
                        clientes.Add(cliente);
                        break;

                    case 2:
                        ListarClientes();
                        Console.ReadLine();
                        break;

                    case 3:
                        ListarClientes();                       
                        Console.WriteLine("ingrese el numero del Cliente a borrar");
                        int eliminar_cliente = Convert.ToInt32(Console.ReadLine());
                        BorrarCliente(eliminar_cliente);
                        ListarClientes();
                        Console.ReadLine();
                        break;
                                             
                    case 4:
                        return;
                }

                

            }


        }
    }
}
