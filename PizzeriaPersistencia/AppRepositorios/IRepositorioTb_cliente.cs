using PizzeriaDominio;
using System.Collections.Generic;

namespace PizzeriaPersistencia
{
    public interface IRepositorioTb_cliente
    {
        Cliente CrearCliente(Cliente cliente);
        Cliente ConsultarCliente(int Id);
        IEnumerable<Cliente> ConsultarClientes();
        Cliente ActualizarCliente(Cliente cliente);
        void EliminarCliente(int Id);  
    }
}