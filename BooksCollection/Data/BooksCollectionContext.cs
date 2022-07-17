using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksCollection.Model;

namespace BooksCollection.Data
{
    public class BooksCollectionContext : DbContext
    {
        public BooksCollectionContext (DbContextOptions<BooksCollectionContext> options)
            : base(options)
        {
        }

        public DbSet<BooksCollection.Model.BookCollections> BookCollections { get; set; } = default!;
    }
}
