using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class BookDTO
    {
        private String ISBN;
        private String bookName;
        private String authorName;
        private int category;
        private string categoryName;
        private int language;
        private string languageName;
        private int publishYear;
        private int pages;
        private String publisher;
        private int author;

        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public int Category { get => category; set => category = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public int Language { get => language; set => language = value; }
        public string LanguageName { get => languageName; set => languageName = value; }

        public int PublishYear { get => publishYear; set => publishYear = value; }
        public int Pages { get => pages; set => pages = value; }
        public String Publisher { get => publisher; set => publisher = value; }

        public int Author1 { get => author; set => author = value; }
    }

    public class AuthorDTO
    {
        private String authorName;
        private int author;

        public string AuthorName { get => authorName; set => authorName = value; }
        public int Author1 { get => author; set => author = value; }
    }

    public class CategoryDTO
    {
        private int category;
        private string categoryName;
        public int Category1 { get => category; set => category = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

    }
    public class LanguageDTO
    {
        private string languageName;
        private int language;


        public int Language1 { get => language; set => language = value; }
        public string LanguageName { get => languageName; set => languageName = value; }
    }


    public class BorrowDTO
    {

        private int borrow;
        private int uid;
        private string isbn;
        private DateTime borrowDate;
        private DateTime? returnDate;
        private DateTime? actualReturnDate;
        private decimal? lateFee;

        public int Borrow1 { get => borrow; set => borrow = value; }
        public int Uid { get => uid; set => uid = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public DateTime BorrowDate { get => borrowDate; set => borrowDate = value; }
        public DateTime? ReturnDate { get => returnDate; set => returnDate = value; }
        public DateTime? ActualReturnDate { get => actualReturnDate; set => actualReturnDate = value; }
        public decimal? LateFee { get => lateFee; set => lateFee = value; }
    }
}


