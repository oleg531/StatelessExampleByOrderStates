﻿namespace StatelessExampleByOrderStates.Stateless
{
    using global::Stateless;
    using Models;

    public static class StateMachineFactory
    {
        public static StateMachine<OrderStates, OrderTriggers> Create(Order order)
        {
            var stateMachine = new StateMachine<OrderStates, OrderTriggers>(() => order.OrderState, s => order.OrderState = s);
            return Configure(stateMachine);
        }

        private static StateMachine<OrderStates, OrderTriggers> Configure(StateMachine<OrderStates, OrderTriggers> stateMachine)
        {
            stateMachine.Configure(OrderStates.OnAir)
                .Permit(OrderTriggers.ApproveByLocalUser, OrderStates.PartiallyApproved)
                .Permit(OrderTriggers.Reject, OrderStates.Rejected);

            stateMachine.Configure(OrderStates.PartiallyApproved)
                .Permit(OrderTriggers.ApproveByMainUser, OrderStates.Approved);

            return stateMachine;
        }
    }
}