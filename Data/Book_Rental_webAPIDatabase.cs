using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Book_Rental_webAPI.Model;

namespace Book_Rental_webAPI.Data
{
    public class Book_Rental_webAPIDatabase : DbContext
    {
        public Book_Rental_webAPIDatabase (DbContextOptions<Book_Rental_webAPIDatabase> options)
            : base(options)
        {
        }

        public DbSet<Book_Rental_webAPI.Model.Book> Book { get; set; }
    }
}
