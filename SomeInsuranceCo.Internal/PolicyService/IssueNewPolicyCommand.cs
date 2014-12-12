using System;

namespace SomeInsuranceCo.Internal.Commands.PolicyService
{
    public class IssueNewPolicyCommand
    {
        public string PolicyState { get; set; }
        public int COLLPremium { get; set; }
        public int COMPPremium { get; set; }
    }
}
