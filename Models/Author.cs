using System.Collections.Generic;

namespace Library_Leo_Effert.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
