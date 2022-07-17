using System.ComponentModel.DataAnnotations;

namespace BooksCollection.Model
{
    public class BookCollections
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required./ Насловот е задолжителен.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Title length must be in range between 2 and 50 characters./ Насловот мора да биде во опсег помеѓу 2 и 50 карактери.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Authors name is required./ Името на авторот е задолжително.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Author name must be in range between 2 and 50 characters./ Името на авторот мора да биде во опсег помеѓу 2 и 50 карактери.")]
        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Book rating is required./ Рејтингот на книгата е задолжителен.")]
        [RegularExpression(@"[1-5]+$", ErrorMessage = "Rating must be in range between 1 and 5./ Рејтингот мора да биде во опсег помеѓу 1 и 5.")]
        public string Rating { get; set; }

    }
}
