using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CodeFirstDemo.Entities;

namespace CodeFirstDemo.DataContexts
{
    public class BooksDb : DbContext
    {
        public BooksDb()
            : base("DefaultConnection")
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}