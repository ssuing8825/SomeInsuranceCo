using System;
using NServiceBus;
using SomeInsuranceCo.Contracts.PolicyService;
using NServiceBus.Saga;
using SomeInsuranceCo.Contracts.BillingService;


namespace SomeInsuranceCo.AccountService
{
    public partial class NewPolicyIssuedEventHandler
    {
        protected override void ConfigureHowToFindSaga(SagaPropertyMapper<NewPolicyIssuedEventHandlerSagaData> mapper)
        {

            mapper.ConfigureMapping<PremiumDataCommittedToBilling>(s => s.CorrilationId)
       .ToSaga(m => m.CorrilationId);
            
            // If you add new messages to be handled by your saga, you will need to manually add a call to ConfigureMapping for them.
        }
    }
}
