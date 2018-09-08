using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ProjectInvoice.DAL;

namespace ProjectInvoice.Migrations
{
    [DbContext(typeof(DataConnect))]
    partial class DataConnectModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectInvoice.Models.CustomerDetails", b =>
                {
                    b.Property<int>("CustomerDetailsID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address");

                    b.Property<int>("cardnumber");

                    b.Property<string>("city");

                    b.Property<int>("expirationdate");

                    b.Property<string>("firstname");

                    b.Property<string>("lastname");

                    b.Property<int>("phone");

                    b.Property<string>("state");

                    b.Property<int>("zipcode");

                    b.HasKey("CustomerDetailsID");

                    b.ToTable("CustomerDetailss");
                });
        }
    }
}
