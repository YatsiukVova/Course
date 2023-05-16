using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Book : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string CoverType { get; set; }
        public bool AgeLimit { get; set; }
        public bool CoAuthor { get; set; }
        public double Rating { get; set; }
        public BooksSortOrder SortOrder { get; set; }


        public Book() { }

        public Book(int id, string name, string author, int year,
            string gener, string coverType, bool ageLimit, bool coAuthor, double rating)
        {
            Id = id;
            Name = name;
            Author = author;
            Year = year;
            Genre = gener;
            CoverType = coverType;
            AgeLimit = ageLimit;
            CoAuthor = coAuthor;
            Rating = rating;
        }

        public string Info()
        {
            return Name + ", " + Author + ", " + Year;
        }
        public double Ratings()
        {
            return Rating;
        }
        public int CompareTo(object obj)
        {
            Book book = obj as Book;
            switch (this.SortOrder)
            {
                case BooksSortOrder.SortById:
                    return(this.Id > book.Id ? 1 :
                    (this.Id < book.Id ? -1 : 0));
                case BooksSortOrder.SortByName:
                    return string.Compare(this.Name, book.Name);
                case BooksSortOrder.SortByAuthor:
                    return string.Compare(this.Author, book.Author);
                case BooksSortOrder.SortByYear:
                    return (this.Year > book.Year ? 1 :
                    (this.Year < book.Year ? -1 : 0));
                case BooksSortOrder.SortByGenre:
                    return string.Compare(this.Genre, book.Genre);
                case BooksSortOrder.SortByRating:
                    return(this.Rating > book.Rating ? 1 :
                        (this.Rating < book.Rating ? -1 : 0));
                default:
                    return (this.Id > book.Id ? 1 :
                    (this.Id < book.Id ? -1 : 0));
            }
        }
    }
}
public enum BooksSortOrder
{
    SortById = 1, SortByName = 2, SortByAuthor = 3,
    SortByYear = 4, SortByGenre = 5,
    SortByRating = 6
}
