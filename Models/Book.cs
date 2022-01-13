using System.Collections.Generic;

namespace Library_Leo_Effert.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
        public ICollection<BookCustomer> BookCustomers { get; set; }
    }
}
