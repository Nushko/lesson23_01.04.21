using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using lesson23_01._04._21.Models;

namespace lesson23_01._04._21.Db
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Quote>()
                .HasData(
                    new Quote() { Id = 1, Text = "Сижу в покрове ночи и код пишу, сна не видать, но я не грущу", Author = "Нушко", InsertDate = DateTime.Now},
                    new Quote() { Id = 2, Text = "Фантазия закончилась на первой цитате, но это и неважно", Author = "Нушко", InsertDate = DateTime.Now},
                    new Quote() { Id = 3, Text = "Я ем кашу, Даша видит Сашу", Author = "Нушко", InsertDate = DateTime.Now},
                    new Quote() { Id = 4, Text = "Вода течёт там, где вода протекает", Author = "Нушко", InsertDate = DateTime.Now},
                    new Quote() { Id = 5, Text = "картошка", Author = "Нушко", InsertDate = DateTime.Now}
                ) ;
        }

    }


    

}
