namespace StatelessExampleByOrderStates.Models
{
    using Stateless;

    public class Order : BaseEntity
    {
        public string Name { get; set; }
        public string Market { get; set; }
        public OrderStates OrderState { get; set; }
    }
}
