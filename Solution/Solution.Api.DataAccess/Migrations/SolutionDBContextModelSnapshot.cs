﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Solution.Api.DataAccess;

namespace Solution.Api.DataAccess.Migrations
{
    [DbContext(typeof(SolutionDBContext))]
    partial class SolutionDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Solution.Api.DataAccess.Contracts.Entities.EMPRESA", b =>
                {
                    b.Property<int>("EmpresaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmpresaEstado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpresaNombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpresaID");

                    b.ToTable("EMPRESAS");
                });

            modelBuilder.Entity("Solution.Api.DataAccess.Contracts.Entities.PERSONA", b =>
                {
                    b.Property<int>("PersonaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaID")
                        .HasColumnType("int");

                    b.Property<string>("PersonaApelliso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonaNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonaNroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoDocumentoID")
                        .HasColumnType("int");

                    b.HasKey("PersonaID");

                    b.HasIndex("EmpresaID");

                    b.HasIndex("TipoDocumentoID");

                    b.ToTable("PERSONA");
                });

            modelBuilder.Entity("Solution.Api.DataAccess.Contracts.Entities.TIPODOCUMENTO", b =>
                {
                    b.Property<int>("TipoDocumentoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaID")
                        .HasColumnType("int");

                    b.Property<string>("TipoDocumentoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoDocumentoID");

                    b.HasIndex("EmpresaID");

                    b.ToTable("TIPODOCUMENTO");
                });

            modelBuilder.Entity("Solution.Api.DataAccess.Contracts.Entities.UBICACION", b =>
                {
                    b.Property<int>("UbicacionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaID")
                        .HasColumnType("int");

                    b.Property<int>("PersonaID")
                        .HasColumnType("int");

                    b.Property<string>("UbicacionLatitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UbicacionLongitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UbicacionObservaciones")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UbicacionID");

                    b.HasIndex("EmpresaID");

                    b.HasIndex("PersonaID");

                    b.ToTable("UBICACION");
                });

            modelBuilder.Entity("Solution.Api.DataAccess.Contracts.Entities.PERSONA", b =>
                {
                    b.HasOne("Solution.Api.DataAccess.Contracts.Entities.EMPRESA", "EMPRESA")
                        .WithMany("PERSONA")
                        .HasForeignKey("EmpresaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Solution.Api.DataAccess.Contracts.Entities.TIPODOCUMENTO", "TIPODOCUMENTO")
                        .WithMany("PERSONA")
                        .HasForeignKey("TipoDocumentoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Solution.Api.DataAccess.Contracts.Entities.TIPODOCUMENTO", b =>
                {
                    b.HasOne("Solution.Api.DataAccess.Contracts.Entities.EMPRESA", "EMPRESA")
                        .WithMany("TIPO_DOCUMENTO")
                        .HasForeignKey("EmpresaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Solution.Api.DataAccess.Contracts.Entities.UBICACION", b =>
                {
                    b.HasOne("Solution.Api.DataAccess.Contracts.Entities.EMPRESA", "EMPRESA")
                        .WithMany("UBICACION")
                        .HasForeignKey("EmpresaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Solution.Api.DataAccess.Contracts.Entities.PERSONA", "PERSONA")
                        .WithMany("UBICACION")
                        .HasForeignKey("PersonaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
