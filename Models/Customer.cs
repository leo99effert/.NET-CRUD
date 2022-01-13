using System.Collections.Generic;

namespace Library_Leo_Effert.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookCustomer> BookCustomers { get; set; }
    }
}
