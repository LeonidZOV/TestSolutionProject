using Xunit;

namespace TestControlProject
{
    public class LibraryShelfReraderSolution
    {
        [Fact]
        public void AddBookOnShelfLibrary()
        {
            Library library = new Library();
            Book book = new Book("Harry Potter");
            
            bool success = library.AddBook(book);

            Assert.True(success);
            Assert.True(library.HasBook(book));
        }

        [Fact]
        public void RemoveBookFromShelfLibrary()
        {
            var library = new Library();
            var book = new Book("Harry Potter");
         

            bool fall = library.RemoveBook(book);
            
            Assert.True(fall);
            Assert.True(library.HasNotBook(book));
        }

        [Fact]
        public void TakeBookFromLiabrary()
        {
            var library = new Library();
            var book = new Book("Harry Potter");
            library.AddBook(book);
            var sut = new Reader();

            bool success = sut.GetBookFromLibrary(book, library);

            Assert.True(success);
            Assert.True(library.HasNotBook(book));

        }

        [Fact]
        public void ReturnBookToLiabrary()
        {
            var library = new Library();
            var book = new Book("Harry Potter");
            library.RemoveBook(book);
            var sut = new Reader();

            bool falling = sut.ReturnBookToLiabrary(book, library);

            Assert.True(falling);
            Assert.True(library.AddBook(book));
        }
    }
    
    
}