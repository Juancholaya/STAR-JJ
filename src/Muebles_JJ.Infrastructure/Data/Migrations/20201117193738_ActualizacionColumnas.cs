using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Muebles_JJ.Infrastructure.Data.Migrations
{
    public partial class ActualizacionColumnas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cantidad_insumo",
                columns: table => new
                {
                    ID_Cantidad = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(maxLength: 30, nullable: true, defaultValueSql: "'NULL'"),
                    Cantidad = table.Column<int>(type: "int(10)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Cantidad);
                });

            migrationBuilder.CreateTable(
                name: "color_producto",
                columns: table => new
                {
                    ID_Color = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 30, nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Color);
                });

            migrationBuilder.CreateTable(
                name: "documento",
                columns: table => new
                {
                    ID_Documento = table.Column<int>(type: "int(1)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(maxLength: 30, nullable: true, defaultValueSql: "'NULL'"),
                    Numero = table.Column<int>(type: "int(20)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Documento);
                });

            migrationBuilder.CreateTable(
                name: "material_producto",
                columns: table => new
                {
                    ID_Material = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 30, nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Material);
                });

            migrationBuilder.CreateTable(
                name: "medida_producto",
                columns: table => new
                {
                    ID_Medida = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Cantidad_Centimetros = table.Column<int>(type: "int(10)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Medida);
                });

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    ID_Rol = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 30, nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Rol);
                });

            migrationBuilder.CreateTable(
                name: "tipo_producto",
                columns: table => new
                {
                    ID_Tipo = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 30, nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Tipo);
                });

            migrationBuilder.CreateTable(
                name: "insumo",
                columns: table => new
                {
                    ID_Insumo = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "'NULL'"),
                    ID_Cantidad_FK = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Insumo);
                    table.ForeignKey(
                        name: "insumo_ibfk_1",
                        column: x => x.ID_Cantidad_FK,
                        principalTable: "cantidad_insumo",
                        principalColumn: "ID_Cantidad",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    ID_Persona = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Primer_Nombre = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "'NULL'"),
                    Segundo_Nombre = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "'NULL'"),
                    Primer_Apellido = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "'NULL'"),
                    Segundo_Apellido = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "'NULL'"),
                    Direccion = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "'NULL'"),
                    ID_Documento_FK = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Persona);
                    table.ForeignKey(
                        name: "persona_ibfk_1",
                        column: x => x.ID_Documento_FK,
                        principalTable: "documento",
                        principalColumn: "ID_Documento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    ID_Producto = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ID_Tipo_FK = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'"),
                    ID_Material_FK = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'"),
                    ID_Color_FK = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'"),
                    ID_Medida_FK = table.Column<int>(type: "int(30)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Producto);
                    table.ForeignKey(
                        name: "producto_ibfk_3",
                        column: x => x.ID_Color_FK,
                        principalTable: "color_producto",
                        principalColumn: "ID_Color",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "producto_ibfk_2",
                        column: x => x.ID_Material_FK,
                        principalTable: "material_producto",
                        principalColumn: "ID_Material",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "producto_ibfk_4",
                        column: x => x.ID_Medida_FK,
                        principalTable: "medida_producto",
                        principalColumn: "ID_Medida",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "producto_ibfk_1",
                        column: x => x.ID_Tipo_FK,
                        principalTable: "tipo_producto",
                        principalColumn: "ID_Tipo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    ID_Usuario = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre_Usuario = table.Column<string>(maxLength: 30, nullable: true, defaultValueSql: "'NULL'"),
                    Contraseña_Usuario = table.Column<string>(maxLength: 30, nullable: true, defaultValueSql: "'NULL'"),
                    ID_Persona_FK = table.Column<int>(type: "int(10)", nullable: true, defaultValueSql: "'NULL'"),
                    ID_Rol_FK = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Usuario);
                    table.ForeignKey(
                        name: "usuario_ibfk_1",
                        column: x => x.ID_Persona_FK,
                        principalTable: "persona",
                        principalColumn: "ID_Persona",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "usuario_ibfk_2",
                        column: x => x.ID_Rol_FK,
                        principalTable: "rol",
                        principalColumn: "ID_Rol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "inventario",
                columns: table => new
                {
                    ID_Inventario = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ID_Insumo_FK = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'"),
                    ID_Producto_FK = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'"),
                    Fecha_Entrada = table.Column<DateTime>(nullable: false),
                    Fecha_Salida = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Inventario);
                    table.ForeignKey(
                        name: "inventario_ibfk_1",
                        column: x => x.ID_Insumo_FK,
                        principalTable: "insumo",
                        principalColumn: "ID_Insumo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "inventario_ibfk_2",
                        column: x => x.ID_Producto_FK,
                        principalTable: "producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "venta",
                columns: table => new
                {
                    ID_Venta = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Cantidad_Producto = table.Column<int>(type: "int(10)", nullable: true, defaultValueSql: "'NULL'"),
                    ID_Producto_FK = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'"),
                    Sub_Total = table.Column<int>(type: "int(10)", nullable: true, defaultValueSql: "'NULL'"),
                    Total = table.Column<int>(type: "int(10)", nullable: true, defaultValueSql: "'NULL'"),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Venta);
                    table.ForeignKey(
                        name: "venta_ibfk_1",
                        column: x => x.ID_Producto_FK,
                        principalTable: "producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "telefono",
                columns: table => new
                {
                    ID_Telefono = table.Column<int>(type: "int(1)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(maxLength: 30, nullable: true, defaultValueSql: "'NULL'"),
                    Numero = table.Column<int>(type: "int(10)", nullable: true, defaultValueSql: "'NULL'"),
                    Extension = table.Column<int>(type: "int(4)", nullable: true, defaultValueSql: "'NULL'"),
                    ID_Usuario_FK = table.Column<int>(type: "int(10)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Telefono);
                    table.ForeignKey(
                        name: "telefono_ibfk_1",
                        column: x => x.ID_Usuario_FK,
                        principalTable: "usuario",
                        principalColumn: "ID_Usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "comprobante_pago",
                columns: table => new
                {
                    ID_Comprobante = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ID_Venta_FK = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'"),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Comprobante);
                    table.ForeignKey(
                        name: "comprobante_pago_ibfk_1",
                        column: x => x.ID_Venta_FK,
                        principalTable: "venta",
                        principalColumn: "ID_Venta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pedido",
                columns: table => new
                {
                    ID_Pedido = table.Column<int>(type: "int(2)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Direccion_Entrega = table.Column<string>(maxLength: 30, nullable: true, defaultValueSql: "'NULL'"),
                    ID_Venta_FK = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'"),
                    Fecha_Entrega = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Pedido);
                    table.ForeignKey(
                        name: "pedido_ibfk_1",
                        column: x => x.ID_Venta_FK,
                        principalTable: "venta",
                        principalColumn: "ID_Venta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ID_Venta_FK",
                table: "comprobante_pago",
                column: "ID_Venta_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Cantidad_FK",
                table: "insumo",
                column: "ID_Cantidad_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Insumo_FK",
                table: "inventario",
                column: "ID_Insumo_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Producto_FK",
                table: "inventario",
                column: "ID_Producto_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Venta_FK",
                table: "pedido",
                column: "ID_Venta_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Documento_FK",
                table: "persona",
                column: "ID_Documento_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Color_FK",
                table: "producto",
                column: "ID_Color_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Material_FK",
                table: "producto",
                column: "ID_Material_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Medida_FK",
                table: "producto",
                column: "ID_Medida_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Tipo_FK",
                table: "producto",
                column: "ID_Tipo_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Usuario_FK",
                table: "telefono",
                column: "ID_Usuario_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Persona_FK",
                table: "usuario",
                column: "ID_Persona_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Rol_FK",
                table: "usuario",
                column: "ID_Rol_FK");

            migrationBuilder.CreateIndex(
                name: "ID_Producto_FK",
                table: "venta",
                column: "ID_Producto_FK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comprobante_pago");

            migrationBuilder.DropTable(
                name: "inventario");

            migrationBuilder.DropTable(
                name: "pedido");

            migrationBuilder.DropTable(
                name: "telefono");

            migrationBuilder.DropTable(
                name: "insumo");

            migrationBuilder.DropTable(
                name: "venta");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "cantidad_insumo");

            migrationBuilder.DropTable(
                name: "producto");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "color_producto");

            migrationBuilder.DropTable(
                name: "material_producto");

            migrationBuilder.DropTable(
                name: "medida_producto");

            migrationBuilder.DropTable(
                name: "tipo_producto");

            migrationBuilder.DropTable(
                name: "documento");
        }
    }
}
