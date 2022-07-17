using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BooksCollection.Data;
using BooksCollection.Model;

namespace BooksCollection.Pages.Book
{
    public class IndexModel : PageModel
    {
        private readonly BooksCollection.Data.BooksCollectionContext _context;

        public IndexModel(BooksCollection.Data.BooksCollectionContext context)
        {
            _context = context;
        }

        public IList<BookCollections> BookCollections { get;set; } = default!;

        public async Task OnGetAsync(string SearchString)
        {
            var books = from b in _context.BookCollections
                        select b;

            if (!String.IsNullOrEmpty(SearchString))
            {
                books = _context.BookCollections.Where(s => s.Title!.Contains(SearchString));
            }

            BookCollections = await books.ToListAsync();

        }
    }
}
