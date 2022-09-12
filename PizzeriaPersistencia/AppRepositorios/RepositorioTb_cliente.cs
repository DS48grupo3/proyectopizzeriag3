using PizzeriaDominio;
using System.Collections.Generic;
using System.Linq;

namespace PizzeriaPersistencia
{
    public class RepositorioTb_cliente : IRepositorioTb_cliente
    {
        private readonly AppContext _appContext;
        public RepositorioTb_cliente(AppContext appContext)
        {
            _appContext = appContext;
        }
         public Cliente CrearCliente(Cliente cliente)
         {
            var clienteAdicionado = _appContext.Tb_cliente.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
         }
         public Cliente ConsultarCliente(int Id)
         {
            var clienteEncontrado = _appContext.Tb_cliente.FirstOrDefault(c => c.Id == Id);
            return clienteEncontrado;
         }
         public  IEnumerable<Cliente> ConsultarClientes()
         {
            return _appContext.Tb_cliente;
         }
         public Cliente ActualizarCliente(Cliente cliente)
         {
            var clienteEncontrado = _appContext.Tb_cliente.FirstOrDefault(c => c.Id == cliente.Id);
            if(clienteEncontrado != null){
                clienteEncontrado.Nombres = cliente.Nombres;
                clienteEncontrado.Apellidos = cliente.Apellidos;
                clienteEncontrado.Email = cliente.Email;
                clienteEncontrado.Edad = cliente.Edad;
                clienteEncontrado.Telefono = cliente.Telefono;
                clienteEncontrado.Direccion = cliente.Direccion;
                clienteEncontrado.Password = cliente.Password;

                _appContext.SaveChanges();
            }
            return clienteEncontrado;
         }
         public void EliminarCliente(int Id)
         {
            var clienteEncontrado = _appContext.Tb_cliente.FirstOrDefault(c => c.Id == Id);
            if(clienteEncontrado == null)
            return;
            _appContext.Tb_cliente.Remove(clienteEncontrado);
            _appContext.SaveChanges();

         }
    }
}