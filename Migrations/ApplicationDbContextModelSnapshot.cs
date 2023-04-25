﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using ef7_example.Infraestructure.Database;

#nullable disable

namespace ef7_example.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GenderMovie", b =>
                {
                    b.Property<int>("GendersId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("GendersId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenderMovie");

                    b.HasData(
                        new
                        {
                            GendersId = 1,
                            MoviesId = 1
                        },
                        new
                        {
                            GendersId = 4,
                            MoviesId = 1
                        },
                        new
                        {
                            GendersId = 2,
                            MoviesId = 2
                        },
                        new
                        {
                            GendersId = 4,
                            MoviesId = 3
                        },
                        new
                        {
                            GendersId = 1,
                            MoviesId = 3
                        },
                        new
                        {
                            GendersId = 3,
                            MoviesId = 3
                        },
                        new
                        {
                            GendersId = 4,
                            MoviesId = 4
                        },
                        new
                        {
                            GendersId = 1,
                            MoviesId = 4
                        },
                        new
                        {
                            GendersId = 3,
                            MoviesId = 4
                        },
                        new
                        {
                            GendersId = 4,
                            MoviesId = 5
                        },
                        new
                        {
                            GendersId = 1,
                            MoviesId = 5
                        },
                        new
                        {
                            GendersId = 5,
                            MoviesId = 5
                        });
                });

            modelBuilder.Entity("MovieMovieTheater", b =>
                {
                    b.Property<int>("MovieTheatersId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("MovieTheatersId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("MovieMovieTheater");

                    b.HasData(
                        new
                        {
                            MovieTheatersId = 3,
                            MoviesId = 5
                        },
                        new
                        {
                            MovieTheatersId = 4,
                            MoviesId = 5
                        },
                        new
                        {
                            MovieTheatersId = 1,
                            MoviesId = 5
                        },
                        new
                        {
                            MovieTheatersId = 2,
                            MoviesId = 5
                        },
                        new
                        {
                            MovieTheatersId = 5,
                            MoviesId = 5
                        },
                        new
                        {
                            MovieTheatersId = 6,
                            MoviesId = 5
                        },
                        new
                        {
                            MovieTheatersId = 7,
                            MoviesId = 5
                        });
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biography")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("Created")
                        .HasColumnType("date");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Fortune")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("date");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Actor", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biography = "Thomas Stanley Holland (Kingston upon Thames, Londres; 1 de junio de 1996), conocido simplemente como Tom Holland, es un actor, actor de voz y bailarín británico.",
                            BirthDate = new DateTime(1996, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortune = 1000000m,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tom Holland"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "Samuel Leroy Jackson (Washington D. C., 21 de diciembre de 1948), conocido como Samuel L. Jackson, es un actor y productor de cine, televisión y teatro estadounidense. Ha sido candidato al premio Óscar, a los Globos de Oro y al Premio del Sindicato de Actores, así como ganador de un BAFTA al mejor actor de reparto.",
                            BirthDate = new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortune = 2000000m,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Samuel L. Jackson"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "Robert John Downey Jr. (Nueva York, 4 de abril de 1965) es un actor, actor de voz, productor y cantante estadounidense. Inició su carrera como actor a temprana edad apareciendo en varios filmes dirigidos por su padre, Robert Downey Sr., y en su infancia estudió actuación en varias academias de Nueva York.",
                            BirthDate = new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortune = 420000000m,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Robert Downey Jr."
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1981, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortune = 39000000m,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Chris Evans"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1972, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortune = 49000000m,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dwayne Johnson"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(2000, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortune = 0m,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Auli'i Cravalho"
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortune = 0m,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Scarlett Johansson"
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortune = 0m,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Keanu Reeves"
                        });
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Point>("Location")
                        .HasColumnType("geography");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Cinema", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.939248 18.469649)"),
                            Name = "Acropolis"
                        },
                        new
                        {
                            Id = 2,
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.911582 18.482455)"),
                            Name = "Sambil"
                        },
                        new
                        {
                            Id = 3,
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.856309 18.506662)"),
                            Name = "Megacentro"
                        },
                        new
                        {
                            Id = 1,
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.9388777 18.4839233)"),
                            Name = "Agora Mall"
                        });
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.CinemaOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Discount")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId")
                        .IsUnique();

                    b.ToTable("CinemaOffer", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CinemaId = 4,
                            Discount = 15m,
                            EndDate = new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            InitialDate = new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 1,
                            CinemaId = 1,
                            Discount = 10m,
                            EndDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            InitialDate = new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("IsDeleted = 0");

                    b.ToTable("Gender", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Acción"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Animación"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Ciencia ficción"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Dramma"
                        });
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Message")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("date");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsPlaying")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("date");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PosterUrl")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("Premiere")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Movie", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPlaying = false,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Avengers_%282012_film%29_poster.jpg",
                            Premiere = new DateTime(2012, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Avengers"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPlaying = false,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "https://upload.wikimedia.org/wikipedia/en/9/98/Coco_%282017_film%29_poster.jpg",
                            Premiere = new DateTime(2017, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Coco"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPlaying = false,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg",
                            Premiere = new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spider-Man: No way home"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPlaying = false,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg",
                            Premiere = new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spider-Man: Far From Home"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPlaying = true,
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "https://upload.wikimedia.org/wikipedia/en/5/50/The_Matrix_Resurrections.jpg",
                            Premiere = new DateTime(2100, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Matrix Resurrections"
                        });
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.MovieActor", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MoviesActors");

                    b.HasData(
                        new
                        {
                            ActorId = 2,
                            MovieId = 4,
                            Character = "Samuel L. Jackson",
                            Order = 2
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 4,
                            Character = "Peter Parker",
                            Order = 1
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 3,
                            Character = "Peter Parker",
                            Order = 1
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 1,
                            Character = "Iron Man",
                            Order = 2
                        },
                        new
                        {
                            ActorId = 7,
                            MovieId = 1,
                            Character = "Black Widow",
                            Order = 3
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 1,
                            Character = "Capitán América",
                            Order = 1
                        },
                        new
                        {
                            ActorId = 8,
                            MovieId = 5,
                            Character = "Neo",
                            Order = 1
                        });
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.MovieTheater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("ThreeD");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.ToTable("MovieTheaters");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            CinemaId = 3,
                            Currency = "",
                            Price = 250m,
                            Type = "TwoD"
                        },
                        new
                        {
                            Id = 6,
                            CinemaId = 3,
                            Currency = "",
                            Price = 330m,
                            Type = "ThreeD"
                        },
                        new
                        {
                            Id = 7,
                            CinemaId = 3,
                            Currency = "",
                            Price = 450m,
                            Type = "FourD"
                        },
                        new
                        {
                            Id = 8,
                            CinemaId = 4,
                            Currency = "",
                            Price = 250m,
                            Type = "TwoD"
                        },
                        new
                        {
                            Id = 1,
                            CinemaId = 1,
                            Currency = "",
                            Price = 220m,
                            Type = "TwoD"
                        },
                        new
                        {
                            Id = 2,
                            CinemaId = 1,
                            Currency = "",
                            Price = 320m,
                            Type = "ThreeD"
                        },
                        new
                        {
                            Id = 3,
                            CinemaId = 2,
                            Currency = "",
                            Price = 200m,
                            Type = "TwoD"
                        },
                        new
                        {
                            Id = 4,
                            CinemaId = 2,
                            Currency = "",
                            Price = 290m,
                            Type = "ThreeD"
                        });
                });

            modelBuilder.Entity("GenderMovie", b =>
                {
                    b.HasOne("ef7_example.Domain.Entities.Gender", null)
                        .WithMany()
                        .HasForeignKey("GendersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ef7_example.Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieMovieTheater", b =>
                {
                    b.HasOne("ef7_example.Domain.Entities.MovieTheater", null)
                        .WithMany()
                        .HasForeignKey("MovieTheatersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ef7_example.Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.CinemaOffer", b =>
                {
                    b.HasOne("ef7_example.Domain.Entities.Cinema", null)
                        .WithOne("Offer")
                        .HasForeignKey("ef7_example.Domain.Entities.CinemaOffer", "CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.Movie", b =>
                {
                    b.OwnsMany("ef7_example.Domain.Entities.Comment", "Comments", b1 =>
                        {
                            b1.Property<int>("MovieId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            b1.Property<string>("Content")
                                .HasMaxLength(150)
                                .HasColumnType("nvarchar(150)");

                            b1.Property<bool>("Recommend")
                                .HasColumnType("bit");

                            b1.HasKey("MovieId", "Id");

                            b1.ToTable("Movie");

                            b1.ToJson("Comments");

                            b1.WithOwner()
                                .HasForeignKey("MovieId");
                        });

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.MovieActor", b =>
                {
                    b.HasOne("ef7_example.Domain.Entities.Actor", "Actor")
                        .WithMany("MoviesActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ef7_example.Domain.Entities.Movie", "Movie")
                        .WithMany("MoviesActors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.MovieTheater", b =>
                {
                    b.HasOne("ef7_example.Domain.Entities.Cinema", "Cinema")
                        .WithMany("MovieTheaters")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.Actor", b =>
                {
                    b.Navigation("MoviesActors");
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.Cinema", b =>
                {
                    b.Navigation("MovieTheaters");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("ef7_example.Domain.Entities.Movie", b =>
                {
                    b.Navigation("MoviesActors");
                });
#pragma warning restore 612, 618
        }
    }
}
