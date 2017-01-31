namespace StatelessExampleByOrderStates.Stateless
{
    using global::Stateless;
    using Models;

    public static class StateMachineFactory
    {
        public static StateMachine<OrderState, OrderTrigger> Create(Order order)
        {
            var stateMachine = new StateMachine<OrderState, OrderTrigger>(() => order.OrderState, s => order.OrderState = s);
            return Configure(stateMachine);
        }

        private static StateMachine<OrderState, OrderTrigger> Configure(StateMachine<OrderState, OrderTrigger> stateMachine)
        {
            stateMachine.Configure(OrderState.OnAir)
                .Permit(OrderTrigger.ApproveByLocalUser, OrderState.PartiallyApproved)
                .Permit(OrderTrigger.Reject, OrderState.Rejected);

            stateMachine.Configure(OrderState.PartiallyApproved)
                .Permit(OrderTrigger.ApproveByMainUser, OrderState.Approved);

            return stateMachine;
        }
    }
}
