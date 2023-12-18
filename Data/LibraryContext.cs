using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using Microsoft.EntityFrameworkCore;

public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<DataModels.User> User { get; set; } = default!;

        public DbSet<DataModels.Book> Book { get; set; } = default!;
    }
