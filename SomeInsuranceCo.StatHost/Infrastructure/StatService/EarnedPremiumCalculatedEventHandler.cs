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
using SomeInsuranceCo.Contracts.AccountService;


namespace SomeInsuranceCo.StatService
{
    public partial class EarnedPremiumCalculatedEventHandler : IHandleMessages<EarnedPremiumCalculatedEvent>
    {
		
		public void Handle(EarnedPremiumCalculatedEvent message)
		{
			// Handle message on partial class
			this.HandleImplementation(message);
		}

		partial void HandleImplementation(EarnedPremiumCalculatedEvent message);

        public IBus Bus { get; set; }

    }

	
}