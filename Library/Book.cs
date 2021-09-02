using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string title;
        private string author;
        private int isbn;
        private int placeOnShelf;
        

        #region GettersAndSetters
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public int Isbn
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }
        public int PlaceOnShelf
        {
            get
            {
                return placeOnShelf;
            }
            set
            {
                placeOnShelf = value;
            }
        }
        #endregion

        public Book(string title, string author, int isbn, int placeOnShelf)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.placeOnShelf = placeOnShelf;
            
            
        }
    }
}
