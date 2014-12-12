using System;
using NServiceBus;
using SomeInsuranceCo.Internal.Commands.PolicyService;


namespace SomeInsuranceCo.PolicyService
{
    public partial class IssueNewPolicyCommandHandler
    {

        partial void HandleImplementation(IssueNewPolicyCommand message)
        {
            // TODO: IssueNewPolicyCommandHandler: Add code to handle the IssueNewPolicyCommand message.
            Console.WriteLine("PolicyService received " + message.GetType().Name);


            var newPolicyIssuedEvent = new SomeInsuranceCo.Contracts.PolicyService.NewPolicyIssuedEvent();

            var r = new Random();
            var mid = r.Next(message.COLLPremium);

            newPolicyIssuedEvent.COLLPremiumOffSet = message.COLLPremium - mid;
            newPolicyIssuedEvent.COLLPremiumOnSet = mid;

            mid = r.Next(message.COMPPremium);

            newPolicyIssuedEvent.COMPPremiumOffSet = message.COMPPremium - mid;
            newPolicyIssuedEvent.COMPPremiumOnSet = mid;

            newPolicyIssuedEvent.CorrilationId = r.Next();
            newPolicyIssuedEvent.TransactionId = Guid.NewGuid();
            newPolicyIssuedEvent.TransactionTimestam = DateTime.Now;

            Bus.Publish(newPolicyIssuedEvent);
        }


    }
}
