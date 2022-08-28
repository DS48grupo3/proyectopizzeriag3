using System;

namespace PizzeriaDominio
{
    public class Cliente
    {
        public int Id {get; set;}
        public string Nombres {get; set;}
        public string Apellidos {get; set;}
        public string Email {get; set;}
        public int Edad {get; set;}
        public string Telefono {get; set;}
        public string Direccion {get; set;}
        public string Password {get; set;}
        public Producto Producto {get; set;}
        public Pedido Pedido {get; set;}
    }
}