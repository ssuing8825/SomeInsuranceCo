using System;
using NServiceBus;
using SomeInsuranceCo.Contracts.PolicyService;
using NServiceBus.Saga;
using SomeInsuranceCo.Contracts.BillingService;


namespace SomeInsuranceCo.AccountService
{
    public partial class NewPolicyIssuedEventHandler
    {
		
        partial void HandleImplementation(NewPolicyIssuedEvent message)
        {
            // TODO: NewPolicyIssuedEventHandler: Add code to handle the NewPolicyIssuedEvent message.
            Console.WriteLine("AccountService received " + message.GetType().Name);

        }
        partial void HandleImplementation(PremiumDataCommittedToBilling message)
        {
            // TODO: NewPolicyIssuedEventHandler: Add code to handle the NewPolicyIssuedEvent message.
            Console.WriteLine("AccountService received " + message.GetType().Name);
        }
        partial void AllMessagesReceived()
        {
            Console.WriteLine("All Messages Recieved Sending BalancedEvent" );
            var policyBillingBalancedEvent = new SomeInsuranceCo.Contracts.AccountService.PolicyBillingBalancedEvent();
            policyBillingBalancedEvent.COLLPremiumOnSet = this.Data.NewPolicyIssuedEvent.COLLPremiumOffSet;

            Bus.Publish(policyBillingBalancedEvent);
        }
    }
}
