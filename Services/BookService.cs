using BookApp.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Services
{
    public class Book
    {
        public string Name;
        public string Summary;
        public string Author;
        public string PageQuantity;
    }

    public class BookService: BaseService
    {
        public IQueryable<Book> GetAll()
        {
            return
                this.db.C27_02_Book_
                    .Select(b => new Book()
                    {
                        Name = b.BookName,
                        Summary = b.BookSummary,
                        Author = b.BookAuthor,
                        PageQuantity = b.BookQualitiStranica
                    });
        }

        public bool AddNewBook(C27_02_Book_ newBook)
        {
            try
            {
                this.db.C27_02_Book_.Add(newBook);
                this.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteBookById(C27_02_Book_ bookToDelete)
        {
            try
            {
                this.db.C27_02_Book_.Remove(bookToDelete);
                this.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
