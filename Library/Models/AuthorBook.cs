using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class AuthorBook
    {
        public int Id { get; set; }

        public int Author { get; set; }

        public List<Book> Books { get; set; }
    }
}
