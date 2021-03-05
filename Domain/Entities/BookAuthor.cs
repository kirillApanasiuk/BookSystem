using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class BookAuthor
    {
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public int Order { get; set; }

        #region Relationships
        public Author Author { get; set; }
        public Book Book { get; set; }
        #endregion
    }
}
