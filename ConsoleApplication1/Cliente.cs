using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Cliente
    {
            private string nombre, apellido, direccion, localidad, telefono;
            public int codigo;
            private DateTime FechaNac; 
            public void Listar()
            {
                //imprimimos en un renglon los datos de un cliente//
                Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|",codigo, nombre, apellido, direccion, localidad);
            }
    


            private void CapturarNombre()
            {
                Console.Write("Ingrese su nombre: ");
                nombre = Console.ReadLine();
                if (nombre == "")
                {
                    Console.WriteLine("error al ingresar el nombre");
                    CapturarNombre();
                }

            }
            private void CapturarApellido()
            {
                Console.Write("Ingrese su apellido: ");
                apellido = Console.ReadLine();
                if (apellido == "")
                {
                    Console.WriteLine("error al ingresar el apellido");
                    CapturarApellido();
                }
            }
        private void CapturarDireccion()
        {
            Console.Write("Ingrese su dirección: ");
            direccion = Console.ReadLine();
            if (direccion == "")
            {
                Console.WriteLine("error al ingresar la direccion");
                CapturarDireccion();
            }
        }
        private void CapturarLocalidad()
        {
            Console.Write("Ingrese su localidad: ");
            localidad = Console.ReadLine();
            if (localidad == "")
            {
                Console.WriteLine("error al ingresar la localidad");
                CapturarLocalidad();
            }

        }
        private void CapturarTelefono()
        {
            Console.Write("Por último ingrese su teléfono: ");
            telefono = Console.ReadLine();
            if (telefono == "")
            {
                Console.WriteLine("error al ingresar el telefono");
                CapturarTelefono();
            }
        }
        private void CapturarCodigo()
        {
            //imprime,muestra el texto "ingrese su nombre"//
            Console.Write("Ingrese su codigo: ");
            //intenta convertir a fecha lo q escribe el usuario//
            try
            {
                codigo = Convert.ToInt32(Console.ReadLine());
            }
            catch
                //si la convercion fallo vuelve a llamar al metodo//
            {
                Console.WriteLine("Error al ingresar la fecha de nac. intente nuevamente");
                CapturarCodigo();
            }
        }
        private void CapturarFechaNac()
        {
            Console.Write ("Ingrese su Fecha de Nacimiento: ");
            try {
                FechaNac = Convert.ToDateTime (Console.ReadLine ());
            }
            catch{
                Console.WriteLine("Error al ingresar la fecha de nac. intente nuevamente");
                CapturarFechaNac ();
            }
        }
        public string ImprimirFicha() 
        {
            string ficha = ("FICHA PERSONAL CLIENTE");
            ficha += "\nCodigo: " + codigo;
            ficha += "\nNombre: " + nombre;
            ficha += "\nApellido: " + apellido; 
            ficha += "\nDireccion: " + direccion; 
            ficha += "\nLocalidad: " + localidad; 
            ficha += "\nTelefono: " + telefono;             
            ficha += "\nfechaNacimiento: " + FechaNac.ToShortDateString();
            return ficha;
        }
        public void CapturarDatos()

        {
            CapturarCodigo();
            CapturarNombre();
            CapturarApellido();
            CapturarDireccion();
            CapturarLocalidad();
            CapturarTelefono();           
            CapturarFechaNac();
        }
        private string Presentarse()
        {
            string Presentacion = ("Hola Soy: "+nombre+" "+apellido);
            return Presentacion;
        }
        private string AnunciarDomicilio()
        {
            string AnunciarDomicilio = ("Vivo en: " +direccion+ " - " +localidad);
            return AnunciarDomicilio;
        }
        public string AnunciarEdad()
        {
            int edad;
            DateTime hoy = DateTime.Now;
            edad = hoy.Year - FechaNac.Year;
            string AnunciarEdad = ("Nací en el año " + FechaNac.Year + " y tengo " + edad + " años de edad");
            return AnunciarEdad;
            
        }
        
        public void Hablar()
        {
            Console.WriteLine(Presentarse());
            Console.WriteLine(AnunciarDomicilio());
            Console.WriteLine(AnunciarEdad());
        }
    }
}
    

