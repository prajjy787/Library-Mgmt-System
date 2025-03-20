
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.ServiceReferenceLibrary;
using System.Security.Cryptography;


namespace Controller
{
    public class MasterMaintenanceController
    {
        public int AddAuthor(string AuthorName)
        {

            //  MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();
            // int istsatuscode = masterMaintenanceLogic.AddAuthor(AuthorName);

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
          int istsatuscode =  webServiceLibrarySoapClient.AddAuthor(AuthorName);
            return istsatuscode;
        }

        public int DeleteAuthor(int Original_AID, string Original_AuthorName)
        {

            //   MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();
            //  int istsatusDA = masterMaintenanceLogic.DeleteAuthor(Original_AID, Original_AuthorName);


            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
          int istsatusDA =  webServiceLibrarySoapClient.DeleteAuthor(Original_AID, Original_AuthorName);


            return istsatusDA;
        }

        public int UpdateAuthor(string AuthorName, int AID, string Original_AuthorName)
        {

            // MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();

            //  int istatusMA = masterMaintenanceLogic.UpdateAuthor( AuthorName,  AID,  Original_AuthorName);

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();

            int istatusMA = webServiceLibrarySoapClient.UpdateAuthor(AuthorName, AID, Original_AuthorName);

            return istatusMA;
        }


        public int AddLanguage(string LanguageName)
        {
            // MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();
            // int istsatuscodeAl = masterMaintenanceLogic.AddLanguage(LanguageName);

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
           int istsatuscodeAl = webServiceLibrarySoapClient.AddLanguage(LanguageName);

            return istsatuscodeAl;

        }
        public int DeleteLanguage(int Original_LID, string Original_LanguageName)
        {
            // MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();
            // int istsatuscodeDl = masterMaintenanceLogic.DeleteLanguage(Original_LID, Original_LanguageName);

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
            int istsatuscodeDl = webServiceLibrarySoapClient.DeleteLanguage(Original_LID, Original_LanguageName);

            return istsatuscodeDl;

        }

        public virtual int ModifyLanguage(string LanguageName, int LID, string Original_LanguageName)
        {
            //  MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();
            //  int istatusML = masterMaintenanceLogic.ModifyLanguage(LanguageName, LID, Original_LanguageName);

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
          int istatusML =  webServiceLibrarySoapClient.ModifyLanguage(LanguageName, LID, Original_LanguageName);

            return istatusML;
        }

        public int AddCategory(string CategoryName)
        {
            //  MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();

            //  int istsatuscodeAC = masterMaintenanceLogic.AddCategory(CategoryName);

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
          int istsatuscodeAC =   webServiceLibrarySoapClient.AddCategory(CategoryName);




            return istsatuscodeAC;
        }

        public int DeleteCategory(int Original_CID, string Original_CategoryName)
        {
            //  MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();

            // int istsatuscodeDC = masterMaintenanceLogic.DeleteCategory(Original_CID, Original_CategoryName);

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
           int istsatuscodeDC = webServiceLibrarySoapClient.DeleteCategory(Original_CID, Original_CategoryName);


            return istsatuscodeDC;

        }


        public virtual int ModifyCategory(string CategoryName, int CID, string Original_CategoryName)
        {
            //  MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();

            // int istatusMC = masterMaintenanceLogic.ModifyCategory(CategoryName, CID, Original_CategoryName);

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
           int istatusMC = webServiceLibrarySoapClient.ModifyCategory(CategoryName, CID, Original_CategoryName);

            return istatusMC;
        }

        public int AddBook(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher)
        {
            //  MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();
            // int istsatusAB = masterMaintenanceLogic.AddBook(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
          int istsatusAB =  webServiceLibrarySoapClient.AddBook(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);

            return istsatusAB;

        }

        public int DeleteBook(string Original_ISBN)
        {


            //  MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();
            //  int istatusDB = masterMaintenanceLogic.DeleteBook(Original_ISBN);


            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
           int istatusDB = webServiceLibrarySoapClient.DeleteBook(Original_ISBN);


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
            //  MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();

            /*   int istatusUB = masterMaintenanceLogic.UpdateBook(
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
                Original_Publisher);   */


            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
             int istatusUB =   webServiceLibrarySoapClient.UpdateBook( ISBN,BookName,
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
      
        public List<AuthorDTO> Authorfind()
        {
            //  MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();

            //  List<Author> authors = masterMaintenanceLogic.Authorfind();


            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
            Controller.ServiceReferenceLibrary.Author[] authors = webServiceLibrarySoapClient.Authorfind();

            List<AuthorDTO> authorDTOs = new List<AuthorDTO>();
            foreach (Controller.ServiceReferenceLibrary.Author author in authors)
            {

                AuthorDTO authorDTO = new AuthorDTO();

                authorDTO.AuthorName = author.AuthorName;
                authorDTO.Author1 = author.Author1;


                authorDTOs.Add(authorDTO);
            }

            return authorDTOs; ;

        }
        public List<LanguageDTO> LanguageFind()
        {
            //  MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();
            //  List<Language> languages = masterMaintenanceLogic.LanguageFind();


            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
            Controller.ServiceReferenceLibrary.Language[] languages =  webServiceLibrarySoapClient.LanguageFind();

            List<LanguageDTO> languageDTOs = new List<LanguageDTO>();
            foreach (Controller.ServiceReferenceLibrary.Language language in languages)
            {
                LanguageDTO languageDTO = new LanguageDTO();
                languageDTO.Language1 = language.Language1; 
                languageDTO.LanguageName = language.LanguageName;



                languageDTOs.Add(languageDTO);
            }

            return languageDTOs; 

        }

        public List<CategoryDTO> CategoryFind()
        {
            //  MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();
            //  List<Category> categories = masterMaintenanceLogic.CategoryFind();

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
            Controller.ServiceReferenceLibrary.Category[] categories = webServiceLibrarySoapClient.CategoryFind();


            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();

            foreach (Controller.ServiceReferenceLibrary.Category category in categories)
            {
                CategoryDTO categoryDTO = new CategoryDTO();


                categoryDTO.CategoryName = category.CategoryName;
                categoryDTO.Category1 = category.Category1;


                categoryDTOs.Add(categoryDTO);
            }

            return categoryDTOs;
        }



        public List<BorrowDTO> ShowBorrow()
        {
            // MasterMaintenanceLogic masterMaintenanceLogic = new MasterMaintenanceLogic();
            // List<Borrow> borrows = masterMaintenanceLogic.ShowBorrow();

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
            Controller.ServiceReferenceLibrary.Borrow[] borrows = webServiceLibrarySoapClient.ShowBorrow();

          //  Controller.ServiceReferenceLibrary.User user = webServiceLibrarySoapClient.UserLogin(UserName, Password);


            List<BorrowDTO> borrowDTOs = new List<BorrowDTO>();

            foreach (Controller.ServiceReferenceLibrary.Borrow borrow in borrows)
            {
                BorrowDTO borrowDTO = new BorrowDTO();
                borrowDTO.Borrow1 = borrow.Borrow1;
                borrowDTO.Isbn = borrow.Isbn;

                borrowDTO.BorrowDate = borrow.BorrowDate;
                borrowDTO.LateFee = borrow.LateFee;
                borrowDTO.ReturnDate = borrow.ReturnDate;
                borrowDTO.ActualReturnDate = borrow.ActualReturnDate;




                borrowDTOs.Add(borrowDTO);
            }



            return borrowDTOs;
        }




       
        }


    }
