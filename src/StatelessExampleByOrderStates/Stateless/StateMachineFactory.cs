namespace StatelessExampleByOrderStates.Stateless
{
    using global::Stateless;
    using Models;
    using Models.Base;

    public static class StateMachineFactory
    {
        public static StateMachine<OrderState, OrderTrigger> Create(Order order, UserRole role)
        {
            var stateMachine = new StateMachine<OrderState, OrderTrigger>(() => order.OrderState, s => order.OrderState = s);
            return Configure(stateMachine, role);
        }

        private static StateMachine<OrderState, OrderTrigger> Configure(StateMachine<OrderState, OrderTrigger> stateMachine, UserRole role)
        {
            stateMachine.Configure(OrderState.OnAir)
                .PermitIf(OrderTrigger.Approve, OrderState.PartiallyApproved, () => role == UserRole.RegionalUser)
                .PermitIf(OrderTrigger.Approve, OrderState.Approved, () => role == UserRole.MainUser)
                .Permit(OrderTrigger.Reject, OrderState.Rejected);

            stateMachine.Configure(OrderState.PartiallyApproved)
                .PermitIf(OrderTrigger.Approve, OrderState.Approved, () => role == UserRole.MainUser);

            return stateMachine;
        }
    }
}
