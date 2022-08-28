using System;

namespace PizzeriaDominio
{
    public class Carrito
    {
        public int Id {get; set;}
        public float Total {get; set;}
        public Producto Producto {get; set;}
        public Pedido Pedido {get; set;}
    }

}