namespace StatelessExampleByOrderStates.Stateless
{
    using System.Collections.Generic;
    using Models;
    using Models.Base;

    public static class StateMachineHelpers
    {
        public static IEnumerable<OrderTrigger> GetAvailableTriggers(Order order, UserRole role)
        {
            var stateMachine = StateMachineFactory.Create(order, role);
            return stateMachine.PermittedTriggers;
        }
    }
}
