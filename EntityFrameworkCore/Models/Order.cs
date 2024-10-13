namespace EntityFrameworkCore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime OrderFulfilled { get; set; }
        public int CustomerId { get; set; }     // represents the foreign key relationship to customer table
        // if we ommit this CustomerId property, it will still be fine, because EF core will still generate it
        // which we will call (Shadow Property)
        public Customer Customer { get; set; } = null!;     // this is navigational property specifiying one customer for
                                                            // Order entity
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}