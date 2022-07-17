using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BooksCollection.Data;
using BooksCollection.Model;

namespace BooksCollection.Pages.Book
{
    public class CreateModel : PageModel
    {
        private readonly BooksCollection.Data.BooksCollectionContext _context;

        public CreateModel(BooksCollection.Data.BooksCollectionContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BookCollections BookCollections { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.BookCollections == null || BookCollections == null)
            {
                return Page();
            }

            _context.BookCollections.Add(BookCollections);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
