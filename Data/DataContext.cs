using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Data
{
    public class DataContext : DbContext
    {
        //ctor
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        //prop
        public DbSet<Personagem> TB_PERSONAGENS { get; set; }
        public DbSet<Arma> TB_ARMAS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>().ToTable("TB_PERSONAGENS");


            modelBuilder.Entity<Personagem>().HasData
            (
                //Inserir as linhas "new Personagem() {Id = 2,..." da lista de Personagens}
                new Personagem() { Id = 1, Nome = "Frodo", PontosVida = 100, Forca = 17, Defesa = 23, Inteligencia = 33, Classe = ClasseEnum.Cavaleiro },
                new Personagem() { Id = 2, Nome = "Sam", PontosVida = 100, Forca = 15, Defesa = 25, Inteligencia = 30, Classe = ClasseEnum.Cavaleiro },
                new Personagem() { Id = 3, Nome = "Galadriel", PontosVida = 100, Forca = 18, Defesa = 21, Inteligencia = 35, Classe = ClasseEnum.Clerigo },
                new Personagem() { Id = 4, Nome = "Gandalf", PontosVida = 100, Forca = 18, Defesa = 18, Inteligencia = 37, Classe = ClasseEnum.Mago },
                new Personagem() { Id = 5, Nome = "Hobbit", PontosVida = 100, Forca = 20, Defesa = 17, Inteligencia = 31, Classe = ClasseEnum.Cavaleiro },
                new Personagem() { Id = 6, Nome = "Celeborn", PontosVida = 100, Forca = 21, Defesa = 13, Inteligencia = 34, Classe = ClasseEnum.Clerigo },
                new Personagem() { Id = 7, Nome = "Radagast", PontosVida = 100, Forca = 25, Defesa = 11, Inteligencia = 35, Classe = ClasseEnum.Mago }
            );

            modelBuilder.Entity<Arma>().ToTable("TB_ARMA");
            modelBuilder.Entity<Arma>().HasData
            (
                new Arma() { Id = 1, Nome = "Anel de Sauron", Dano = 7 },
                new Arma() { Id = 2, Nome = "Chicotinho", Dano = 2 },
                new Arma() { Id = 3, Nome = "Cajado do Inferno", Dano = 4 } ,
                new Arma() { Id = 4, Nome = "Poção de Veneno de serpente", Dano = 3 },
                new Arma() { Id = 5, Nome = "Machado de Thor", Dano = 6 },
                new Arma() { Id = 6, Nome = "Escudo de Escama de Dragão", Dano = 1},
                new Arma() { Id = 7, Nome = "Espada Forphal", Dano = 4 },
                new Arma() { Id = 8, Nome = "Excalibur", Dano = 7 }
            );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(200);
        }
    }
}