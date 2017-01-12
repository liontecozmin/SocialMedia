﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SC.Web;

namespace SC.Web.Migrations.Post
{
    [DbContext(typeof(PostContext))]
    [Migration("20161223104015_Posts")]
    partial class Posts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SC.Web.Post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("group");

                    b.Property<string>("message");

                    b.Property<DateTime>("postDate");

                    b.HasKey("id");

                    b.ToTable("Posts");
                });
        }
    }
}
