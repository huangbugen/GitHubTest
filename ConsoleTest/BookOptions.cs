using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleTest
{
    // public class BookOptions
    // {
    //     public const string Book = "Book";

    //     public string Name { get; set; }

    //     public BookmarkOptions Bookmark { get; set; }

    //     public List<string> Authors { get; set; }
    // }
    public class BookOptions
    {
        public const string Book = "Book";

        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }
    }

    public class BookmarkOptions
    {
        public string Remarks { get; set; }
    }
}