using System;
using NServiceBus;
using SomeInsuranceCo.Contracts.AccountService;


namespace SomeInsuranceCo.AccountService
{
    public partial class PolicyBillingBalancedEventHandler
    {

        partial void HandleImplementation(PolicyBillingBalancedEvent message)
        {
            // TODO: PolicyBillingBalancedEventHandler: Add code to handle the PolicyBillingBalancedEvent message.
            Console.WriteLine("AccountService received " + message.GetType().Name);

            var earnedPremiumCalculatedEvent = new SomeInsuranceCo.Contracts.AccountService.EarnedPremiumCalculatedEvent();
            earnedPremiumCalculatedEvent.EarnedPremium = message.COLLPremiumOnSet * .1m;

            Bus.Publish(earnedPremiumCalculatedEvent);
        }

    }
}
