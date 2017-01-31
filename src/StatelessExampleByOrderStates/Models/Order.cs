namespace StatelessExampleByOrderStates.Models
{
    using Base;
    using Stateless;

    public class Order : BaseEntity
    {
        public string Name { get; set; }
        public string Market { get; set; }
        public OrderState OrderState { get; set; }
    }
}
