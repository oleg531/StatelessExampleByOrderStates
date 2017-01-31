namespace StatelessExampleByOrderStates.Models.Stateless
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class StateMachineHelpers
    {
        public static IEnumerable<OrderTriggers> GetAvailableTriggers(Order order)
        {
            var stateMachine = StateMachineFactory.Create(order);
            return stateMachine.PermittedTriggers;
        }
    }
}
