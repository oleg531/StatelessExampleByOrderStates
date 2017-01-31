namespace StatelessExampleByOrderStates.Stateless
{
    using System.Collections.Generic;
    using Models;

    public static class StateMachineHelpers
    {
        public static IEnumerable<OrderTriggers> GetAvailableTriggers(Order order)
        {
            var stateMachine = StateMachineFactory.Create(order);
            return stateMachine.PermittedTriggers;
        }
    }
}
