﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Muebles_JJ.Web;

namespace Muebles_JJ.Infrastructure.Data.Migrations
{
    [DbContext(typeof(Muebles_JJDbContext))]
    partial class Muebles_JJDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Muebles_JJ.Web.CantidadInsumo", b =>
                {
                    b.Property<int>("IdCantidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Cantidad")
                        .HasColumnType("int(2)");

                    b.Property<int?>("Cantidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Tipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(30);

                    b.HasKey("IdCantidad")
                        .HasName("PRIMARY");

                    b.ToTable("cantidad_insumo");
                });

            modelBuilder.Entity("Muebles_JJ.Web.ColorProducto", b =>
                {
                    b.Property<int>("IdColor")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Color")
                        .HasColumnType("int(2)");

                    b.Property<string>("Nombre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(30);

                    b.HasKey("IdColor")
                        .HasName("PRIMARY");

                    b.ToTable("color_producto");
                });

            modelBuilder.Entity("Muebles_JJ.Web.ComprobantePago", b =>
                {
                    b.Property<int>("IdComprobante")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Comprobante")
                        .HasColumnType("int(2)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdVentaFk")
                        .HasColumnName("ID_Venta_FK")
                        .HasColumnType("int(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("IdComprobante")
                        .HasName("PRIMARY");

                    b.HasIndex("IdVentaFk")
                        .HasName("ID_Venta_FK");

                    b.ToTable("comprobante_pago");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Documento", b =>
                {
                    b.Property<int>("IdDocumento")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Documento")
                        .HasColumnType("int(1)");

                    b.Property<int?>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(20)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Tipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(30);

                    b.HasKey("IdDocumento")
                        .HasName("PRIMARY");

                    b.ToTable("documento");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Insumo", b =>
                {
                    b.Property<int>("IdInsumo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Insumo")
                        .HasColumnType("int(2)");

                    b.Property<int?>("IdCantidadFk")
                        .HasColumnName("ID_Cantidad_FK")
                        .HasColumnType("int(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Nombre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(20)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(20);

                    b.HasKey("IdInsumo")
                        .HasName("PRIMARY");

                    b.HasIndex("IdCantidadFk")
                        .HasName("ID_Cantidad_FK");

                    b.ToTable("insumo");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Inventario", b =>
                {
                    b.Property<int>("IdInventario")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Inventario")
                        .HasColumnType("int(2)");

                    b.Property<DateTime>("Fecha_Entrada")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Fecha_Salida")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdInsumoFk")
                        .HasColumnName("ID_Insumo_FK")
                        .HasColumnType("int(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("IdProductoFk")
                        .HasColumnName("ID_Producto_FK")
                        .HasColumnType("int(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("IdInventario")
                        .HasName("PRIMARY");

                    b.HasIndex("IdInsumoFk")
                        .HasName("ID_Insumo_FK");

                    b.HasIndex("IdProductoFk")
                        .HasName("ID_Producto_FK");

                    b.ToTable("inventario");
                });

            modelBuilder.Entity("Muebles_JJ.Web.MaterialProducto", b =>
                {
                    b.Property<int>("IdMaterial")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Material")
                        .HasColumnType("int(2)");

                    b.Property<string>("Nombre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(30);

                    b.HasKey("IdMaterial")
                        .HasName("PRIMARY");

                    b.ToTable("material_producto");
                });

            modelBuilder.Entity("Muebles_JJ.Web.MedidaProducto", b =>
                {
                    b.Property<int>("IdMedida")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Medida")
                        .HasColumnType("int(2)");

                    b.Property<int?>("CantidadCentimetros")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Cantidad_Centimetros")
                        .HasColumnType("int(10)")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("IdMedida")
                        .HasName("PRIMARY");

                    b.ToTable("medida_producto");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Pedido")
                        .HasColumnType("int(2)");

                    b.Property<string>("DireccionEntrega")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Direccion_Entrega")
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(30);

                    b.Property<DateTime>("Fecha_Entrega")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdVentaFk")
                        .HasColumnName("ID_Venta_FK")
                        .HasColumnType("int(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("IdPedido")
                        .HasName("PRIMARY");

                    b.HasIndex("IdVentaFk")
                        .HasName("ID_Venta_FK");

                    b.ToTable("pedido");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Persona", b =>
                {
                    b.Property<int>("IdPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Persona")
                        .HasColumnType("int(10)");

                    b.Property<string>("Direccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(50);

                    b.Property<int?>("IdDocumentoFk")
                        .HasColumnName("ID_Documento_FK")
                        .HasColumnType("int(1)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("PrimerApellido")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Primer_Apellido")
                        .HasColumnType("varchar(10)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(10);

                    b.Property<string>("PrimerNombre")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Primer_Nombre")
                        .HasColumnType("varchar(10)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(10);

                    b.Property<string>("SegundoApellido")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Segundo_Apellido")
                        .HasColumnType("varchar(10)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(10);

                    b.Property<string>("SegundoNombre")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Segundo_Nombre")
                        .HasColumnType("varchar(10)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(10);

                    b.HasKey("IdPersona")
                        .HasName("PRIMARY");

                    b.HasIndex("IdDocumentoFk")
                        .HasName("ID_Documento_FK");

                    b.ToTable("persona");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Producto")
                        .HasColumnType("int(2)");

                    b.Property<int?>("IdColorFk")
                        .HasColumnName("ID_Color_FK")
                        .HasColumnType("int(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("IdMaterialFk")
                        .HasColumnName("ID_Material_FK")
                        .HasColumnType("int(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("IdMedidaFk")
                        .HasColumnName("ID_Medida_FK")
                        .HasColumnType("int(30)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("IdTipoFk")
                        .HasColumnName("ID_Tipo_FK")
                        .HasColumnType("int(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("IdProducto")
                        .HasName("PRIMARY");

                    b.HasIndex("IdColorFk")
                        .HasName("ID_Color_FK");

                    b.HasIndex("IdMaterialFk")
                        .HasName("ID_Material_FK");

                    b.HasIndex("IdMedidaFk")
                        .HasName("ID_Medida_FK");

                    b.HasIndex("IdTipoFk")
                        .HasName("ID_Tipo_FK");

                    b.ToTable("producto");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Rol")
                        .HasColumnType("int(2)");

                    b.Property<string>("Nombre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(30);

                    b.HasKey("IdRol")
                        .HasName("PRIMARY");

                    b.ToTable("rol");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Telefono", b =>
                {
                    b.Property<int>("IdTelefono")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Telefono")
                        .HasColumnType("int(1)");

                    b.Property<int?>("Extension")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(4)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("IdUsuarioFk")
                        .HasColumnName("ID_Usuario_FK")
                        .HasColumnType("int(10)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Tipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(30);

                    b.HasKey("IdTelefono")
                        .HasName("PRIMARY");

                    b.HasIndex("IdUsuarioFk")
                        .HasName("ID_Usuario_FK");

                    b.ToTable("telefono");
                });

            modelBuilder.Entity("Muebles_JJ.Web.TipoProducto", b =>
                {
                    b.Property<int>("IdTipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Tipo")
                        .HasColumnType("int(2)");

                    b.Property<string>("Nombre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(30);

                    b.HasKey("IdTipo")
                        .HasName("PRIMARY");

                    b.ToTable("tipo_producto");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Usuario")
                        .HasColumnType("int(2)");

                    b.Property<string>("ContraseñaUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Contraseña_Usuario")
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(30);

                    b.Property<int?>("IdPersonaFk")
                        .HasColumnName("ID_Persona_FK")
                        .HasColumnType("int(10)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("IdRolFk")
                        .HasColumnName("ID_Rol_FK")
                        .HasColumnType("int(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("NombreUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Nombre_Usuario")
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(30);

                    b.HasKey("IdUsuario")
                        .HasName("PRIMARY");

                    b.HasIndex("IdPersonaFk")
                        .HasName("ID_Persona_FK");

                    b.HasIndex("IdRolFk")
                        .HasName("ID_Rol_FK");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Venta", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_Venta")
                        .HasColumnType("int(2)");

                    b.Property<int?>("CantidadProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Cantidad_Producto")
                        .HasColumnType("int(10)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdProductoFk")
                        .HasColumnName("ID_Producto_FK")
                        .HasColumnType("int(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("SubTotal")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Sub_Total")
                        .HasColumnType("int(10)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("Total")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("IdVenta")
                        .HasName("PRIMARY");

                    b.HasIndex("IdProductoFk")
                        .HasName("ID_Producto_FK");

                    b.ToTable("venta");
                });

            modelBuilder.Entity("Muebles_JJ.Web.ComprobantePago", b =>
                {
                    b.HasOne("Muebles_JJ.Web.Venta", "IdVentaFkNavigation")
                        .WithMany("ComprobantePago")
                        .HasForeignKey("IdVentaFk")
                        .HasConstraintName("comprobante_pago_ibfk_1");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Insumo", b =>
                {
                    b.HasOne("Muebles_JJ.Web.CantidadInsumo", "IdCantidadFkNavigation")
                        .WithMany("Insumo")
                        .HasForeignKey("IdCantidadFk")
                        .HasConstraintName("insumo_ibfk_1");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Inventario", b =>
                {
                    b.HasOne("Muebles_JJ.Web.Insumo", "IdInsumoFkNavigation")
                        .WithMany("Inventario")
                        .HasForeignKey("IdInsumoFk")
                        .HasConstraintName("inventario_ibfk_1");

                    b.HasOne("Muebles_JJ.Web.Producto", "IdProductoFkNavigation")
                        .WithMany("Inventario")
                        .HasForeignKey("IdProductoFk")
                        .HasConstraintName("inventario_ibfk_2");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Pedido", b =>
                {
                    b.HasOne("Muebles_JJ.Web.Venta", "IdVentaFkNavigation")
                        .WithMany("Pedido")
                        .HasForeignKey("IdVentaFk")
                        .HasConstraintName("pedido_ibfk_1");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Persona", b =>
                {
                    b.HasOne("Muebles_JJ.Web.Documento", "IdDocumentoFkNavigation")
                        .WithMany("Persona")
                        .HasForeignKey("IdDocumentoFk")
                        .HasConstraintName("persona_ibfk_1");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Producto", b =>
                {
                    b.HasOne("Muebles_JJ.Web.ColorProducto", "IdColorFkNavigation")
                        .WithMany("Producto")
                        .HasForeignKey("IdColorFk")
                        .HasConstraintName("producto_ibfk_3");

                    b.HasOne("Muebles_JJ.Web.MaterialProducto", "IdMaterialFkNavigation")
                        .WithMany("Producto")
                        .HasForeignKey("IdMaterialFk")
                        .HasConstraintName("producto_ibfk_2");

                    b.HasOne("Muebles_JJ.Web.MedidaProducto", "IdMedidaFkNavigation")
                        .WithMany("Producto")
                        .HasForeignKey("IdMedidaFk")
                        .HasConstraintName("producto_ibfk_4");

                    b.HasOne("Muebles_JJ.Web.TipoProducto", "IdTipoFkNavigation")
                        .WithMany("Producto")
                        .HasForeignKey("IdTipoFk")
                        .HasConstraintName("producto_ibfk_1");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Telefono", b =>
                {
                    b.HasOne("Muebles_JJ.Web.Usuario", "IdUsuarioFkNavigation")
                        .WithMany("Telefono")
                        .HasForeignKey("IdUsuarioFk")
                        .HasConstraintName("telefono_ibfk_1");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Usuario", b =>
                {
                    b.HasOne("Muebles_JJ.Web.Persona", "IdPersonaFkNavigation")
                        .WithMany("Usuario")
                        .HasForeignKey("IdPersonaFk")
                        .HasConstraintName("usuario_ibfk_1");

                    b.HasOne("Muebles_JJ.Web.Rol", "IdRolFkNavigation")
                        .WithMany("Usuario")
                        .HasForeignKey("IdRolFk")
                        .HasConstraintName("usuario_ibfk_2");
                });

            modelBuilder.Entity("Muebles_JJ.Web.Venta", b =>
                {
                    b.HasOne("Muebles_JJ.Web.Producto", "IdProductoFkNavigation")
                        .WithMany("Venta")
                        .HasForeignKey("IdProductoFk")
                        .HasConstraintName("venta_ibfk_1");
                });
#pragma warning restore 612, 618
        }
    }
}
