using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Controller.ServiceReferenceLibrary;

namespace Controller
{
    public class Book_Controller
    {
        int USer_ID = LibraryGlobal.uSER_Id;

        public List<BookDTO> BrowseBooks()
        {
            // Book_Logic book_Logic = new Book_Logic();
            // List<Book> books = book_Logic.BrowseBooks();

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();

            Controller.ServiceReferenceLibrary.Book[] books = webServiceLibrarySoapClient.BrowseBooks();

            List<BookDTO> bookDTOs = new List<BookDTO>();



            foreach (Controller.ServiceReferenceLibrary.Book book in books)
            {
                BookDTO bookDTO = new BookDTO();

                bookDTO.ISBN1 = book.ISBN1;
                bookDTO.BookName = book.BookName;
                bookDTO.AuthorName = book.AuthorName;
                bookDTO.CategoryName = book.CategoryName;
                bookDTO.PublishYear = book.PublishYear;
                bookDTO.CategoryName = book.CategoryName;
                bookDTO.PublishYear = book.PublishYear;
                bookDTO.Category = book.Category;
                bookDTO.Publisher = book.Publisher;
                bookDTO.Language = book.Language;
                bookDTO.LanguageName = book.LanguageName;
                bookDTO.Pages = book.Pages;
                bookDTO.Author1 = book.Author;
                bookDTOs.Add(bookDTO);

            }

            return bookDTOs;


        }
        public List<BookDTO> Search(string BookName, string AuthorName, string CategoryName )
        {
            // Book_Logic book_Logic = new Book_Logic();
            // List<Book> books = book_Logic.Search(BookName , AuthorName, CategoryName    );

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();

            Controller.ServiceReferenceLibrary.Book[] books = webServiceLibrarySoapClient.Search(BookName, AuthorName, CategoryName);

            if (books == null || books.Length == 0)
            {
                throw new ApplicationException("No such book exists."); 
            }

            {

                List<BookDTO> bookDTOs = new List<BookDTO>();



                foreach (Controller.ServiceReferenceLibrary.Book book in books)
                {
                    BookDTO bookDTO = new BookDTO();

                    bookDTO.ISBN1 = book.ISBN1;
                    bookDTO.BookName = book.BookName;
                    bookDTO.AuthorName = book.AuthorName;
                    bookDTO.CategoryName = book.CategoryName;
                    bookDTO.PublishYear  = book.PublishYear;
                    bookDTO.CategoryName = book.CategoryName;
                    bookDTO.PublishYear = book.PublishYear;
                    bookDTO.Category = book.Category;
                    bookDTO.Publisher = book.Publisher;
                    bookDTO.Language = book.Language;
                    bookDTO.LanguageName = book.LanguageName;
                    bookDTO.Pages = book.Pages;

                    bookDTOs.Add(bookDTO);

                }

                return bookDTOs;
            }


        }

     /*   public List<BookDTO> ReportBorrowedBook()
        {
            Book_Logic book_Logic = new Book_Logic();




            List<Book> books = book_Logic.ReportBorrowedBook();
            List<BookDTO> bookDTOs = new List<BookDTO>();


            foreach (Book book in books)
            {
                BookDTO bookDTO = new BookDTO();

                bookDTO.ISBN1 = book.ISBN1;
                bookDTO.BookName = book.BookName;
                bookDTO.AuthorName = book.AuthorName;
                bookDTO.CategoryName = book.CategoryName;
                bookDTO.PublishYear = book.PublishYear;
                bookDTO.Category = book.Category;
                bookDTO.Publisher = book.Publisher;
                bookDTO.Language = book.Language;
                bookDTO.LanguageName = book.LanguageName;
                bookDTO.Pages = book.Pages;
                bookDTO.Author1 = book.Author;

                bookDTOs.Add(bookDTO);

            }

            return bookDTOs;
        }
     */
        public List<BookDTO> AvailableBookReport()
        {
            // Book_Logic book_Logic = new Book_Logic();
            //  List<Book> books = book_Logic.AvailableBookReport();

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();

            Controller.ServiceReferenceLibrary.Book[] books = webServiceLibrarySoapClient.AvailableBookReport();



            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Controller.ServiceReferenceLibrary.Book book in books)
            {
                BookDTO bookDTO = new BookDTO();

                bookDTO.ISBN1 = book.ISBN1;
                bookDTO.BookName = book.BookName;
                bookDTO.AuthorName = book.AuthorName;
                bookDTO.CategoryName = book.CategoryName;
                bookDTO.PublishYear = book.PublishYear;
                bookDTO.Category = book.Category;
                bookDTO.Publisher = book.Publisher;
                bookDTO.Language = book.Language;
                bookDTO.LanguageName = book.LanguageName;
                bookDTO.Pages = book.Pages;


                bookDTOs.Add(bookDTO);

            }

            return bookDTOs;
        }

        public int ReserveBook(int UID, string ISBN)
        {

            //  Book_Logic book_Logic = new Book_Logic();


            //   int istatusRB = book_Logic.ReserveBook(USer_ID, ISBN);

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();

         int istatusRB =   webServiceLibrarySoapClient.ReserveBook(USer_ID, ISBN);





            return istatusRB;

        }
        
        public int InsertBorrow(int USer_ID, string ISBN)
        {

            //  Book_Logic book_Logic = new Book_Logic();
            // int istatusBB = book_Logic.InsertBorrow(USer_ID, ISBN);

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
           int istatusBB = webServiceLibrarySoapClient.InsertBorrow(USer_ID, ISBN);

            return istatusBB;
        }
        /*
        public int InsertReturn(int USer_ID, string ISBN, string BorrowDate, string ReturnDate)
        {


            Book_Logic book_Logic = new Book_Logic();

            int istatusRB = book_Logic.InsertReturn(USer_ID, ISBN, BorrowDate, ReturnDate);


            return istatusRB;
        }

        public virtual int DeleteReturn(int Original_BID, int USer_ID, string Original_ISBN, string Original_BorrowDate, string Original_ReturnDate)
        {






            Book_Logic book_Logic = new Book_Logic();
            int istatusBR = book_Logic.DeleteReturn(Original_BID, USer_ID, Original_ISBN, Original_BorrowDate, Original_ReturnDate);


            return istatusBR;
        }

        */

        public int BookReturn(string ActualReturnDate, int BID)

        {
            // Book_Logic book_Logic = new Book_Logic();

            // int istatuscodeBR = book_Logic.BookReturn(ActualReturnDate, BID);

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
           int istatuscodeBR = webServiceLibrarySoapClient.BookReturn(ActualReturnDate, BID);

            return istatuscodeBR;


        }

    }

}

