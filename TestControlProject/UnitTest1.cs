using Xunit;

namespace TestControlProject
{
    public class LibraryShelfReraderSolution
    {
        [Fact]
        public void AddBookOnShelfLibrary()
        {
            var library = new Library();
            var book = new Book();
            library.AddBook(book, 1);
            var reader = new Reader();

            bool success = Reader.AddBook(library, Book, 1);

            Assert.True(success);
            Assert.Equal(1, Library.AddBook(book, 1));
        }

        [Fact]
        public void RemoveBookFromShelfLibrary()
        {
            var library = new Library();
            var book = new Book();
            library.RemoveBook(book, 1);
            var reader = new Reader();

            bool falling = Reader.RemoveBook(library, Book, 1);

            Assert.True(falling);
            Assert.Equal(0, Library.RemoveBook);
        }
    }
    
    
}