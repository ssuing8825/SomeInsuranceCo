using System;
using NServiceBus;
using SomeInsuranceCo.Contracts.PolicyService;
using NServiceBus.Saga;


namespace SomeInsuranceCo.AccountService
{
    public partial class NewPolicyIssuedEventHandlerSagaData
    {
        public int CorrilationId { get; set; }
    }
}
