﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using Module.BookDataSetTableAdapters;
using System.Security.Cryptography.X509Certificates;// Importing namespacefrom (Autogenerated code) to access data table adapter

namespace Module
{
    public class BookDAO
    {
        public List<Book> BrowseBooks()
        {
            ViewBookTableAdapter viewBookTableAdapter = new ViewBookTableAdapter();
            BookDataSet.ViewBookDataTable viewBookDataTable = viewBookTableAdapter.BrowseBooks();

            //Checking if the query returned any rows.
            int datacount = viewBookDataTable.Count;
            if (datacount == 0)
            {
                return null;
            }
            else
            {
                //Creation of list to store Fetched book
                List<Book> books = new List<Book>();

                foreach (DataRow row in viewBookDataTable.Rows)
                {
                    Book book = new Book();
                    book.ISBN1 = row["ISBN"].ToString().Trim();
                    book.BookName = row["BookName"].ToString().Trim();
                    book.AuthorName = row["AuthorName"].ToString().Trim();

                    book.Publisher = row["Publisher"].ToString().Trim();
                    book.PublishYear = Convert.ToInt32(row["PublishYear"]);
                    book.Pages = Convert.ToInt32(row["Pages"]);
                    book.CategoryName = row["CategoryName"].ToString().Trim();
                    book.LanguageName = row["LanguageName"].ToString().Trim();
                    book.Category = Convert.ToInt32(row["Category"]);
                    book.Language = Convert.ToInt32(row["Language"]);


                    //Add the book object to list.
                    books.Add(book);
                }

                return books;
            }
        }






        public int ReserveBook(int USer_ID, string ISBN)

        {

            TabReservedTableAdapter tabReservedTableAdapter = new TabReservedTableAdapter();

            String sCurrentDateTime = DateTime.Now.ToString();

            int istatusRB = tabReservedTableAdapter.ReserveBook(USer_ID, ISBN, sCurrentDateTime);




            if (istatusRB == -1)
            {

            }
            else if (istatusRB == 1)
            {

            }
            return istatusRB;

        }


        public int InsertBorrow(int USer_ID, string ISBN)
        {

            TabBorrowTableAdapter tabBorrowTableAdapter = new TabBorrowTableAdapter();

            DateTime Actualdate = new DateTime(2000, 1, 1);
            string ActualdateString = Actualdate.ToString("yyyy-MM-dd");


            string latefee = "0.00";
            decimal Latefeedeciaml = Convert.ToDecimal(latefee);

            String sCurrentborrowDateTime = DateTime.Now.ToString();
            String sreturnborrowDateTime = DateTime.Now.ToString();

            string sReturnBorrowDateTime = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd");


            int istatusBB = tabBorrowTableAdapter.InsertBorrow(USer_ID, ISBN, sCurrentborrowDateTime, sReturnBorrowDateTime, ActualdateString, Latefeedeciaml);


            return istatusBB;
        }


        /*
        public int InsertReturn(int USer_ID, string ISBN, string BorrowDate, string ReturnDate)
        {

            TabBorrowTableAdapter tabBorrowTableAdapter = new TabBorrowTableAdapter();

            DateTime Actualdate = new DateTime(2000, 1, 1);
            string ActualdateString = Actualdate.ToString("yyyy-MM-dd");


            string latefee = "0.00";
            decimal Latefeedeciaml = Convert.ToDecimal(latefee);

            String sActualreturnDateTime = DateTime.Now.ToString();



            int istatusRB = tabBorrowTableAdapter.InsertReturn(USer_ID, ISBN, BorrowDate, ReturnDate, sActualreturnDateTime, Latefeedeciaml);


            return istatusRB;
        }



        public virtual int DeleteReturn(int Original_BID, int USer_ID, string Original_ISBN, string Original_BorrowDate, string Original_ReturnDate)
        {


            string latefee = "0.00";
            decimal Latefeedeciaml = Convert.ToDecimal(latefee);

            DateTime Actualdate = new DateTime(2000, 1, 1);
            string ActualdateString = Actualdate.ToString("yyyy-MM-dd");


            TabBorrowTableAdapter tabBorrowTableAdapter = new TabBorrowTableAdapter();
            int istatusBR = tabBorrowTableAdapter.DeleteReturn(Original_BID, USer_ID, Original_ISBN, Original_BorrowDate, Original_ReturnDate, ActualdateString, Latefeedeciaml);


            return istatusBR;
        }
        */

       /* public List<Book> ReportBorrowedBook()
        {
            ViewBookBorrowedTableAdapter viewBookBorrowedTableAdapter = new ViewBookBorrowedTableAdapter();
            BookDataSet.ViewBookBorrowedDataTable viewBookBorrowedDataTable = viewBookBorrowedTableAdapter.ReportBorrowedBook();

            int datacount = viewBookBorrowedDataTable.Count;

            if (datacount == 0)
            {
                return null;
            }
            else
            {
                // Creation of list to store fetched available books
                List<Book> books = new List<Book>();

                foreach (DataRow row in viewBookBorrowedDataTable.Rows)
                {
                    Book book = new Book
                    {
                        ISBN1 = row["ISBN"].ToString().Trim(),
                        BookName = row["BookName"].ToString().Trim(),
                        AuthorName = row["AuthorName"].ToString().Trim(),
                        Publisher = row["Publisher"].ToString().Trim(),
                        PublishYear = Convert.ToInt32(row["PublishYear"]),
                        CategoryName = row["CategoryName"].ToString().Trim(),
                        LanguageName = row["LanguageName"].ToString().Trim(),
                        Category = Convert.ToInt32(row["Category"]),
                        Language = Convert.ToInt32(row["Language"]),
                        Pages = Convert.ToInt32(row["Pages"]),
                        Author = Convert.ToInt32(row["Author"]),
                    };

                    // Add the book object to the list.
                    books.Add(book);
                }

                return books;
            }
        }*/

        public List<Book> AvailableBookReport()
        {
            ViewBookAvailableTableAdapter viewBookAvailableTableAdapter = new ViewBookAvailableTableAdapter();
            BookDataSet.ViewBookAvailableDataTable viewBookAvailableDataTable = viewBookAvailableTableAdapter.AvailableBookReport();

            int datacount = viewBookAvailableDataTable.Count;

            if (datacount == 0)
            {
                return null;
            }
            else
            {
                // Creation of list to store fetched available books
                List<Book> books = new List<Book>();

                foreach (DataRow row in viewBookAvailableDataTable.Rows)
                {
                    Book book = new Book
                    {
                        ISBN1 = row["ISBN"].ToString().Trim(),
                        BookName = row["BookName"].ToString().Trim(),
                        CategoryName = row["CategoryName"].ToString().Trim(),
                        Publisher = row["Publisher"].ToString().Trim(),
                        PublishYear = Convert.ToInt32(row["PublishYear"]),
                        Pages = Convert.ToInt32(row["Pages"]),
                        AuthorName = row["AuthorName"].ToString().Trim(),
                        LanguageName = row["LanguageName"].ToString().Trim(),
                        Author = Convert.ToInt32(row["Author"]),
                        Category = Convert.ToInt32(row["Category"]),
                        Language = Convert.ToInt32(row["Language"])
                    };

                    // Add the book object to the list.
                    books.Add(book);
                }

                return books;
            }

           

        }



        public int BookReturn(string ActualReturnDate, int BID)
        {
            TabBorrowTableAdapter tabBorrowTableAdapter = new TabBorrowTableAdapter();
            int istatuscodeBR = tabBorrowTableAdapter.BookReturn( ActualReturnDate,  BID);

            return istatuscodeBR;


        }
    }
}



     
 
       
