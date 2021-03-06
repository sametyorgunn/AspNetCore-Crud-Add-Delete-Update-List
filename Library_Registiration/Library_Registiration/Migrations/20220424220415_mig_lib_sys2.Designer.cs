// <auto-generated />
using Library_Registiration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library_Registiration.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220424220415_mig_lib_sys2")]
    partial class mig_lib_sys2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Library_Registiration.Models.Author", b =>
                {
                    b.Property<int>("Author_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author_about")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Author_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_id");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("Library_Registiration.Models.Book", b =>
                {
                    b.Property<int>("Book_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Book_author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Book_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Book_publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Book_subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Book_id");

                    b.ToTable("books");
                });

            modelBuilder.Entity("Library_Registiration.Models.Publisher", b =>
                {
                    b.Property<int>("Publisher_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Publisher_About")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_id");

                    b.ToTable("publishers");
                });
#pragma warning restore 612, 618
        }
    }
}
