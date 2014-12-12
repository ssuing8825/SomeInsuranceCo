﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by ServiceMatrix.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using NServiceBus;
using SomeInsuranceCo.Contracts.PolicyService;
using SomeInsuranceCo.Contracts.BillingService;
using NServiceBus.Saga;


namespace SomeInsuranceCo.AccountService
{
    public partial class NewPolicyIssuedEventHandler : Saga<NewPolicyIssuedEventHandlerSagaData>, IAmStartedByMessages<NewPolicyIssuedEvent>, IAmStartedByMessages<PremiumDataCommittedToBilling>
    {
		
		public void Handle(NewPolicyIssuedEvent message)
		{
			// Store message in Saga Data for later use
			this.Data.NewPolicyIssuedEvent = message;
			// Handle message on partial class
			this.HandleImplementation(message);

			// Check if Saga is Completed 
			CheckIfAllMessagesReceived();
		}

		public void Handle(PremiumDataCommittedToBilling message)
		{
			// Store message in Saga Data for later use
			this.Data.PremiumDataCommittedToBilling = message;
			// Handle message on partial class
			this.HandleImplementation(message);

			// Check if Saga is Completed 
			CheckIfAllMessagesReceived();
		}

		partial void HandleImplementation(NewPolicyIssuedEvent message);

		partial void HandleImplementation(PremiumDataCommittedToBilling message);

        public void CheckIfAllMessagesReceived()
        {
            if (this.Data.NewPolicyIssuedEvent != null && this.Data.PremiumDataCommittedToBilling != null)
            {
                AllMessagesReceived();
            }
        }

        partial void AllMessagesReceived();
     }

     public partial class NewPolicyIssuedEventHandlerSagaData : IContainSagaData
     {
           public virtual Guid Id { get; set; }
           public virtual string Originator { get; set; }
           public virtual string OriginalMessageId { get; set; }

           public virtual NewPolicyIssuedEvent NewPolicyIssuedEvent { get; set; }
           public virtual PremiumDataCommittedToBilling PremiumDataCommittedToBilling { get; set; }

    }

	
}