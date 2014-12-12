using System;

namespace SomeInsuranceCo.Contracts.AccountService
{
    public class PolicyBillingBalancedEvent
    {
        public int CorrilationId { get; set; }
        public Guid TransactionId { get; set; }
        public DateTime TransactionTimestam { get; set; }
        public string PolicyState { get; set; }
        public int COLLPremiumOnSet { get; set; }
        public int COLLPremiumOffSet { get; set; }
        public int COMPPremiumOnSet { get; set; }
        public int COMPPremiumOffSet { get; set; }
    }
}
