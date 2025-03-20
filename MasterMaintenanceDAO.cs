using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module.MasterMaintenanceDatasetTableAdapters;
using static Module.MasterMaintenanceDataset;

namespace Module
{
    public class MasterMaintenanceDAO
    {
        public int AddAuthor(string AuthorName)
        {
            TabAuthorTableAdapter tabAuthorTableAdapter = new TabAuthorTableAdapter();

            int istsatuscode = tabAuthorTableAdapter.AddAuthor(AuthorName);



            return istsatuscode;

        }

        public int DeleteAuthor(int Original_AID, string Original_AuthorName)
        {
            TabAuthorTableAdapter tabAuthorTableAdapter = new TabAuthorTableAdapter();

            int istsatusDA = tabAuthorTableAdapter.DeleteAuthor(Original_AID, Original_AuthorName);



            return istsatusDA;

        }

        public int UpdateAuthor(string AuthorName, int AID, string Original_AuthorName)
        {

            TabAuthorTableAdapter tabAuthorTableAdapter = new TabAuthorTableAdapter();

            int istatusMA = tabAuthorTableAdapter.UpdateAuthor(AuthorName, AID, Original_AuthorName);

            return istatusMA;
        }

        public int AddLanguage(string LanguageName)
        {
            TabLanguageTableAdapter tabLanguageTableAdapter = new TabLanguageTableAdapter();

            int istsatuscodeAl = tabLanguageTableAdapter.AddLanguage(LanguageName);

            return istsatuscodeAl;

        }

        public int DeleteLanguage(int Original_LID, string Original_LanguageName)
        {
            TabLanguageTableAdapter tabLanguageTableAdapter = new TabLanguageTableAdapter();

            int istsatuscodeDl = tabLanguageTableAdapter.DeleteLanguage(Original_LID, Original_LanguageName);

            return istsatuscodeDl;

        }
        public virtual int ModifyLanguage(string LanguageName, int LID, string Original_LanguageName)
        {
            TabLanguageTableAdapter tabLanguageTableAdapter = new TabLanguageTableAdapter();
            int istatusML = tabLanguageTableAdapter.ModifyLanguage(LanguageName, LID, Original_LanguageName);
            return istatusML;
        }

        public virtual int ModifyCategory(string CategoryName, int CID, string Original_CategoryName)
        {
            TabCategoryTableAdapter tabCategoryTableAdapter = new TabCategoryTableAdapter();

            int istatusMC = tabCategoryTableAdapter.ModifyCategory(CategoryName, CID, Original_CategoryName);

            return istatusMC;
        }

        public int AddCategory(string CategoryName)
        {
            TabCategoryTableAdapter tabCategoryTableAdapter = new TabCategoryTableAdapter();
            int istsatuscodeAC = tabCategoryTableAdapter.AddCategory(CategoryName);



            return istsatuscodeAC;

        }
        public int DeleteCategory(int Original_CID, string Original_CategoryName)
        {
            TabCategoryTableAdapter tabCategoryTableAdapter = new TabCategoryTableAdapter();
            int istsatuscodeDC = tabCategoryTableAdapter.DeleteCategory(Original_CID, Original_CategoryName);



            return istsatuscodeDC;

        }

        public List<Author> Authorfind()
        {
            TabAuthorTableAdapter tabAuthorTableAdapter = new TabAuthorTableAdapter();
            MasterMaintenanceDataset.TabAuthorDataTable tabAuthorDataTable = tabAuthorTableAdapter.Authorfind();

            int datacount = tabAuthorDataTable.Count;

            if (datacount == 0)
            {
                return null;
            }
            else
            {
                // Creation of list to store fetched authors
                List<Author> authors = new List<Author>();

                foreach (DataRow row in tabAuthorDataTable.Rows)
                {
                    Author author = new Author();
                    author.Author1 = Convert.ToInt32(row["AID"]);
                    author.AuthorName = row["AuthorName"].ToString().Trim();

                    // Add the author object to the list.
                    authors.Add(author);
                }

                return authors;
            }
        }




        public List<Language> LanguageFind()
        {
            TabLanguageTableAdapter tabLanguageTableAdapter = new TabLanguageTableAdapter();
            MasterMaintenanceDataset.TabLanguageDataTable tabLanguageDataTable = tabLanguageTableAdapter.LanguageFind();

            if (tabLanguageDataTable.Count == 0)
            {
                return null;
            }
            else
            {
                // Creation of list to store fetched languages
                List<Language> languages = new List<Language>();

                foreach (DataRow row in tabLanguageDataTable.Rows)
                {
                    Language language = new Language();
                    language.Language1 = Convert.ToInt32(row["LID"]);
                    language.LanguageName = row["LanguageName"].ToString().Trim();

                    // Add the language object to the list.
                    languages.Add(language);
                }

                return languages;
            }
        }






        /* public List<Language> LanguageFind()
         {

             TabLanguageTableAdapter tabLanguageTableAdapter = new TabLanguageTableAdapter();

             MasterMaintenanceDataset.TabLanguageDataTable tabLanguageDataTable = tabLanguageTableAdapter.LanguageFind();

             int datacount = tabLanguageDataTable.Count;

             if (datacount == 0)
             {
                 return null;
             }
             else
             {
                 // Creation of list to store fetched authors
                 List<Language> languages = new List<Language>();

                 foreach (DataRow row in tabLanguageDataTable.Rows)
                 {
                     Language language = new Language();
                     language.LanguageName = row["LanguageName"].ToString().Trim(); 
                     language.Language1 = Convert.ToInt32(row["LID"]);


                     // Add the author object to the list.
                     languages.Add(language);
                 }

                 return languages;
             }
         }*/



        public List<Category> CategoryFind()
        {
            TabCategoryTableAdapter tabCategoryTableAdapter = new TabCategoryTableAdapter();
            MasterMaintenanceDataset.TabCategoryDataTable tabCategoryDataTable = tabCategoryTableAdapter.CategoryFind();

            if (tabCategoryDataTable.Count == 0)
            {
                return null;
            }
            else
            {
                // Creation of list to store fetched categories
                List<Category> categories = new List<Category>();

                foreach (DataRow row in tabCategoryDataTable.Rows)
                {
                    Category category = new Category();
                    category.Category1 = Convert.ToInt32(row["CID"]);
                    category.CategoryName = row["CategoryName"].ToString().Trim();

                    // Add the category object to the list.
                    categories.Add(category);
                }

                return categories;
            }







        }

        public int AddBook(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher)
        {


            TabBookTableAdapter tabBookTableAdapter = new TabBookTableAdapter();
            int istsatusAB = tabBookTableAdapter.AddBook(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);
            return istsatusAB;
        }

        public int DeleteBook(string Original_ISBN)
        {


            TabBookTableAdapter tabBookTableAdapter = new TabBookTableAdapter();
            int istatusDB = tabBookTableAdapter.DeleteBook(Original_ISBN);



            return istatusDB;
        }

        public int UpdateBook(
             string ISBN,
             string BookName,
             int Author,
             int Category,
             int Language,
             int PublishYear,
             int Pages,
             string Publisher,
             string Original_ISBN,
             string Original_BookName,
             int Original_Author,
             int Original_Category,
             int Original_Language,
             int Original_PublishYear,
             int Original_Pages,
             string Original_Publisher)
        {
            TabBookTableAdapter tabBookTableAdapter = new TabBookTableAdapter();

            int istatusUB = tabBookTableAdapter.UpdateBook(
                ISBN,
                BookName,
                Author,
                Category,
                Language,
                PublishYear,
                Pages,
                Publisher,
                Original_ISBN,
                Original_BookName,
                Original_Author,
                Original_Category,
                Original_Language,
                Original_PublishYear,
                Original_Pages,
                Original_Publisher);

            return istatusUB;
        }

        /* public int AddBook(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher)
         {
             TabBookTableAdapter tabBookTableAdapter = new TabBookTableAdapter();
            int istsatusAB = tabBookTableAdapter.AddBook(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);






                 return istsatusAB;

         }*/


        public List<Borrow> ShowBorrow()
        {
            TabBorrowTableAdapter tabBorrowTableAdapter = new TabBorrowTableAdapter();
            MasterMaintenanceDataset.TabBorrowDataTable tabBorrowDataTable = tabBorrowTableAdapter.ShowBorrow();

            int datacount = tabBorrowDataTable.Count;

            if (datacount == 0)
            {
                return null;
            }
            else
            {
                // Creation of list to store fetched borrow records
                List<Borrow> borrows = new List<Borrow>();

                foreach (DataRow row in tabBorrowDataTable.Rows)
                {
                    Borrow borrow = new Borrow
                    {
                        Borrow1 = Convert.ToInt32(row["BID"]),
                        Uid = Convert.ToInt32(row["UID"]),
                        Isbn = row["ISBN"].ToString().Trim(),
                        BorrowDate = Convert.ToDateTime(row["BorrowDate"]),
                        ReturnDate = row["ReturnDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ReturnDate"]),
                        ActualReturnDate = row["ActualReturnDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ActualReturnDate"]),
                        LateFee = row["LateFee"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(row["LateFee"])
                    };

                    // Add the borrow object to the list.
                    borrows.Add(borrow);
                }

                return borrows;
            }
        }
    }
}
