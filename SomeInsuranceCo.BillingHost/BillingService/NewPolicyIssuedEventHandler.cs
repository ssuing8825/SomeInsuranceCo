using System;
using NServiceBus;
using SomeInsuranceCo.Contracts.PolicyService;


namespace SomeInsuranceCo.BillingService
{
    public partial class NewPolicyIssuedEventHandler
    {
		
        partial void HandleImplementation(NewPolicyIssuedEvent message)
        {
            // TODO: NewPolicyIssuedEventHandler: Add code to handle the NewPolicyIssuedEvent message.
            Console.WriteLine("BillingService received " + message.GetType().Name);
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Committing billing data");
            var premiumDataCommittedToBilling = new SomeInsuranceCo.Contracts.BillingService.PremiumDataCommittedToBilling();
            Bus.Publish(premiumDataCommittedToBilling);
            Console.WriteLine("Publishing Billing event");

        }

    }
}
