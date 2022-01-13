namespace Library_Leo_Effert.Models
{
    public class BookCustomer
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public Book Book { get; set; }
        public Customer Customer { get; set; }
    }
}
