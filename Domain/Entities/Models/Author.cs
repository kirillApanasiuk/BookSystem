using System;
using System.Collections.Generic;

namespace Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; } 

        #region NavigationProperties
        ICollection<BookAuthor> BooksLink { get; set; }
        #endregion

    }
}
