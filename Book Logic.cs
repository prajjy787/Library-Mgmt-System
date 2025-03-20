using Module.BookDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class Book_Logic
    {
        public List<Book> BrowseBooks()
        {
            BookDAO bookDAO = new BookDAO();
            List<Book> books = bookDAO.BrowseBooks();



            return books;
        }

       /* public List<Book> ReportBorrowedBook()
        {
            BookDAO bookDAO = new BookDAO();

            
                List<Book> books = bookDAO.ReportBorrowedBook();

          

                return books;
            
        }*/
        public List<Book> AvailableBookReport()
        {
            BookDAO bookDAO = new BookDAO();


            List<Book> books = bookDAO.AvailableBookReport();

           

                return books;
            }



            public List<Book> Search(string BookName, string AuthorName, string CategoryName)
        {
            SearchDAO searchDAO = new SearchDAO();
            List<Book> books = searchDAO.Search(BookName, AuthorName, CategoryName     );
            return books;

        }
        public int ReserveBook(int USer_ID, string ISBN)

        {
            BookDAO bookDAO = new BookDAO();
            int istatusRB = bookDAO.ReserveBook(USer_ID, ISBN);






            return istatusRB;
             
        }

        
        public int InsertBorrow(int USer_ID, string ISBN )
        {

            BookDAO bookDAO = new BookDAO();
            int istatusBB = bookDAO.InsertBorrow(USer_ID, ISBN);

            return istatusBB;
        }

        /*

        public int InsertReturn(int USer_ID, string ISBN, string BorrowDate, string ReturnDate)
        {


            BookDAO bookDAO = new BookDAO();

            int istatusRB = bookDAO.InsertReturn(USer_ID, ISBN, BorrowDate, ReturnDate);


            return istatusRB;
        }

        public virtual int DeleteReturn(int Original_BID, int USer_ID, string Original_ISBN, string Original_BorrowDate, string Original_ReturnDate)
        {






            BookDAO bookDAO = new BookDAO();
            int istatusBR = bookDAO.DeleteReturn(Original_BID, USer_ID, Original_ISBN, Original_BorrowDate, Original_ReturnDate);


            return istatusBR;
        }

        */

        public int BookReturn(string ActualReturnDate, int BID) 
        
        { 


                        BookDAO bookDAO = new BookDAO();

        int istatuscodeBR = bookDAO.BookReturn(ActualReturnDate, BID);

            return istatuscodeBR;


        }



}
}
