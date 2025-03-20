using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Module.BookSearchDataSetTableAdapters;
namespace Module
{
    public class SearchDAO
    {
        public List<Book> Search(string BookName, string AuthorName, string CategoryName)

        {
            ViewBookTableAdapter viewBookTableAdapter = new ViewBookTableAdapter();
            BookSearchDataSet.ViewBookDataTable viewBookDataTable = viewBookTableAdapter.Search( BookName,  AuthorName,  CategoryName);

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
                    book.CategoryName = row["CategoryName"].ToString().Trim();

                    book.Publisher = row["Publisher"].ToString().Trim();
                    book.PublishYear = Convert.ToInt32(row["PublishYear"]);
                    book.Pages = Convert.ToInt32(row["Pages"]);
                    book.LanguageName = row["LanguageName"].ToString().Trim();


                    book.PublishYear = Convert.ToInt32(row["PublishYear"]);




                    //Add the book object to list.
                    books.Add(book);
                }

                return books;


            }
        }
    }    }
