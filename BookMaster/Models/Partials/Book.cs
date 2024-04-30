using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMaster.Models
{
    public partial class Book
    {
        public string Authors
        {
            get
            {
                string authors = "";
                var bookAuthors = App.DB.Bookauthor.Where(x => x.BookId == Id).ToList();

                foreach(var item in bookAuthors)
                {
                    if (authors.Length > 0)
                    {
                        authors += ", ";
                    }
                    authors += item.Author.Name;
                }

                return authors;
            }
        }
        public string Subjects
        {
            get
            {
                string subjects = "";
                var bookAuthors = App.DB.BookSubject.Where(x => x.BookId == Id).ToList();

                foreach (var item in bookAuthors)
                {
                    if (subjects.Length > 0)
                    {
                        subjects += ", ";
                    }
                    subjects += item.Subject;
                }

                return subjects;
            }
        }
    }
}
