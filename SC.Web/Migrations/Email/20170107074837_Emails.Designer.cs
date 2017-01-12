using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SC.Web;

namespace SC.Web.Migrations.Email
{
    [DbContext(typeof(EmailContext))]
    [Migration("20170107074837_Emails")]
    partial class Emails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SC.Web.Email", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("emailDate");

                    b.Property<string>("from");

                    b.Property<string>("message");

                    b.Property<string>("subject");

                    b.Property<string>("to");

                    b.HasKey("id");

                    b.ToTable("Emails");
                });
        }
    }
}
