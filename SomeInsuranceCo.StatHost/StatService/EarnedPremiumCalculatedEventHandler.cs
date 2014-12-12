using System;
using NServiceBus;
using SomeInsuranceCo.Contracts.AccountService;


namespace SomeInsuranceCo.StatService
{
    public partial class EarnedPremiumCalculatedEventHandler
    {
		
        partial void HandleImplementation(EarnedPremiumCalculatedEvent message)
        {
            // TODO: EarnedPremiumCalculatedEventHandler: Add code to handle the EarnedPremiumCalculatedEvent message.
            Console.WriteLine("StatService received " + message.GetType().Name);
        }

    }
}
