using Module.MasterMaintenanceDatasetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class MasterMaintenanceLogic
    {
        public int AddAuthor(string AuthorName)
        { 

        MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();

           int istsatuscode  = masterMaintenanceDAO.AddAuthor(AuthorName);
            return  istsatuscode;
        }

        public int DeleteAuthor(int Original_AID, string Original_AuthorName)
        {
            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();

            int istsatusDA = masterMaintenanceDAO.DeleteAuthor(Original_AID, Original_AuthorName);
            return istsatusDA;
        }

        public int UpdateAuthor(string AuthorName, int AID, string Original_AuthorName)
        {

            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();

            int istatusMA = masterMaintenanceDAO.UpdateAuthor( AuthorName,  AID,  Original_AuthorName);

            return istatusMA;
        }
        public int AddBook(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher)
        {
            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();
            int istsatusAB = masterMaintenanceDAO.AddBook(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);






            return istsatusAB;

        }

        public int DeleteBook(string Original_ISBN)
        {


            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();
            int istatusDB = masterMaintenanceDAO.DeleteBook(Original_ISBN);



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
            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();

            int istatusUB = masterMaintenanceDAO.UpdateBook(
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

        public int AddLanguage(string LanguageName)
        {
            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();

            int istsatuscodeAl = masterMaintenanceDAO.AddLanguage( LanguageName);

            return istsatuscodeAl;

        }

        public int DeleteLanguage(int Original_LID, string Original_LanguageName)
        {
            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();

            int istsatuscodeDl = masterMaintenanceDAO.DeleteLanguage(Original_LID, Original_LanguageName);

            return istsatuscodeDl;

        }

        public virtual int ModifyLanguage(string LanguageName, int LID, string Original_LanguageName)
        {
            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();
            int istatusML = masterMaintenanceDAO.ModifyLanguage(LanguageName, LID, Original_LanguageName);
            return istatusML;
        }

        public virtual int ModifyCategory(string CategoryName, int CID, string Original_CategoryName)
        {
            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();

            int istatusMC = masterMaintenanceDAO.ModifyCategory(CategoryName, CID, Original_CategoryName);

            return istatusMC;
        }



        public int AddCategory(string CategoryName)
        {
            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();

            int istsatuscodeAC = masterMaintenanceDAO.AddCategory( CategoryName);



            return istsatuscodeAC;

        }

        public int DeleteCategory(int Original_CID, string Original_CategoryName)
        {
            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();

            int istsatuscodeDC = masterMaintenanceDAO.DeleteCategory(Original_CID, Original_CategoryName);



            return istsatuscodeDC;

        }


        public List<Author> Authorfind()
        {

            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();

            List<Author> authors = masterMaintenanceDAO.Authorfind();



            return authors; ;

        }

        public List<Language> LanguageFind()
        {
            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();
            List<Language> languages = masterMaintenanceDAO.LanguageFind();



                return languages;
            
        }

        public List<Category> CategoryFind()
        {
            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();
            List<Category> categories = masterMaintenanceDAO.CategoryFind();
            


            return categories;
        }


        public List<Borrow> ShowBorrow()
        {
            MasterMaintenanceDAO masterMaintenanceDAO = new MasterMaintenanceDAO();
            List<Borrow> borrows = masterMaintenanceDAO.ShowBorrow();



            return borrows;
        }


    }

    }



/**
    * 
    * 
  
 public int DeleteAuthor(int Original_AID, string Original_AuthorName)
       {
           TabAuthorTableAdapter tabAuthorTableAdapter = new TabAuthorTableAdapter();

           int istsatusDA = tabAuthorTableAdapter.DeleteAuthor(Original_AID, Original_AuthorName);



           return istsatusDA;

       }


    */
/*
         public int DeleteLanguage(int Original_LID, string Original_LanguageName)
       {
           TabLanguageTableAdapter tabLanguageTableAdapter = new TabLanguageTableAdapter();

           int istsatuscodeDl = tabLanguageTableAdapter.DeleteLanguage(Original_LID, Original_LanguageName);

           return istsatuscodeDl;

       }
        */

/*  public int DeleteCategory(int Original_CID, string Original_CategoryName)
       {
           TabCategoryTableAdapter tabCategoryTableAdapter = new TabCategoryTableAdapter();
           int istsatuscodeDC = tabCategoryTableAdapter.DeleteCategory(Original_CID, Original_CategoryName);



           return istsatuscodeDC;

       }
     */