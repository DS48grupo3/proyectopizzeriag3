using System;
using PizzeriaDominio;
using PizzeriaPersistencia;

namespace PizzeriaConsola
{
    class Program
    {
        private static IRepositorioTb_cliente _repoTb_cliente = new RepositorioTb_cliente(new PizzeriaPersistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("successful conexion!");
            //CrearCliente();
            EliminarCliente();
        }
        private static void CrearCliente()
        {
            var cliente = new Cliente
            {
                Nombres = "victo",
                Apellidos = "meneses",
                Email = "sigmagrafic@gmail.com",
                Edad = 45,
                Telefono = "56728",
                Direccion = "cali, valle, colombia",
                Password = "9567"

            };
            _repoTb_cliente.CrearCliente(cliente);
        }
        private static void EliminarCliente()
        {
            _repoTb_cliente.EliminarCliente(2);    

        }
    }
}
