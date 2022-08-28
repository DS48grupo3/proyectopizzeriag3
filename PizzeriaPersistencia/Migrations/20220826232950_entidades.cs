using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzeriaPersistencia.Migrations
{
    public partial class entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pago = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_pedido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_producto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_carrito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<float>(type: "real", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: true),
                    PedidoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_carrito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_carrito_Tb_pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Tb_pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_carrito_Tb_producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Tb_producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductoId = table.Column<int>(type: "int", nullable: true),
                    PedidoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_cliente_Tb_pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Tb_pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_cliente_Tb_producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Tb_producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_carrito_PedidoId",
                table: "Tb_carrito",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_carrito_ProductoId",
                table: "Tb_carrito",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_cliente_PedidoId",
                table: "Tb_cliente",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_cliente_ProductoId",
                table: "Tb_cliente",
                column: "ProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_carrito");

            migrationBuilder.DropTable(
                name: "Tb_cliente");

            migrationBuilder.DropTable(
                name: "Tb_pedido");

            migrationBuilder.DropTable(
                name: "Tb_producto");
        }
    }
}
