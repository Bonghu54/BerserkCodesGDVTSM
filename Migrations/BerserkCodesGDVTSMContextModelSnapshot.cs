﻿// <auto-generated />
using System;
using BerserkCodesGDVTSM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BerserkCodesGDVTSM.Migrations
{
    [DbContext(typeof(BerserkCodesGDVTSMContext))]
    partial class BerserkCodesGDVTSMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Cliente", b =>
                {
                    b.Property<int>("Id_Persona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Persona"));

                    b.Property<DateTime>("FechaHora_de_registro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tipo_Cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Persona");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Detalle_Producto", b =>
                {
                    b.Property<int>("Id_Detalle_Producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Detalle_Producto"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Durabilidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estampado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Producto")
                        .HasColumnType("int");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_De_Uso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Detalle_Producto");

                    b.HasIndex("Id_Producto");

                    b.ToTable("Detalle_Producto");
                });

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Detalle_de_venta", b =>
                {
                    b.Property<int>("Id_Detalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Detalle"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Id_Producto")
                        .HasColumnType("int");

                    b.Property<int>("Id_Venta")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio_Producto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_Detalle");

                    b.HasIndex("Id_Producto");

                    b.HasIndex("Id_Venta");

                    b.ToTable("Detalle_de_venta");
                });

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Empleado", b =>
                {
                    b.Property<int>("pk_fk_Id_Persona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pk_fk_Id_Persona"));

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora_de_Registro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Contratacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Puesto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fk_Id_Usuario")
                        .HasColumnType("int");

                    b.HasKey("pk_fk_Id_Persona");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Persona", b =>
                {
                    b.Property<int>("Id_Persona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Persona"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ci")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Persona");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Producto", b =>
                {
                    b.Property<int>("Id_Producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Producto"));

                    b.Property<int>("Cantidad_En_Stock")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Producto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio_Unitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tipo_Producto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unidad_De_Venta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Producto");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Rol", b =>
                {
                    b.Property<int>("Id_Rol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Rol"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora_de_registro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre_Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Rol");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Usuario", b =>
                {
                    b.Property<int>("Id_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Usuario"));

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo_Electronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora_de_registro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fk_Id_Rol")
                        .HasColumnType("int");

                    b.HasKey("Id_Usuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Venta", b =>
                {
                    b.Property<int>("Id_Venta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Venta"));

                    b.Property<string>("Estado_Seguimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora_Entrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaHora_Venta")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total_Venta")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_Venta");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Detalle_Producto", b =>
                {
                    b.HasOne("BerserkCodesGDVTSM.Models.Producto", "Producto")
                        .WithMany("Detalles_Producto")
                        .HasForeignKey("Id_Producto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Detalle_de_venta", b =>
                {
                    b.HasOne("BerserkCodesGDVTSM.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("Id_Producto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BerserkCodesGDVTSM.Models.Venta", "Venta")
                        .WithMany("Detalles_de_venta")
                        .HasForeignKey("Id_Venta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Producto", b =>
                {
                    b.Navigation("Detalles_Producto");
                });

            modelBuilder.Entity("BerserkCodesGDVTSM.Models.Venta", b =>
                {
                    b.Navigation("Detalles_de_venta");
                });
#pragma warning restore 612, 618
        }
    }
}
