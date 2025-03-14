using System;
using System.ComponentModel;
using Payroll.Utility.Attributes;
using Reinforced.Typings.Attributes;

namespace Payroll.Models.DomainModels.CommonDb.FeatureFlags
{
	public enum Feature
	{
		 #region TeamA Features
        // TeamA owns this region
        NewUIDesign,
        ImprovedReporting,
        #endregion

        #region TeamB Features
        // TeamB owns this region
        BetaAlgorithm,
        CloudSync,
        #endregion

        #region TeamC Features
        // TeamC owns this region
        NewPaymentProcessor,
        EnhancedSecurity,
        EnhancedSecurity1,
        EnhancedSecurity2,
        EnhancedSecurity3,
        EnhancedSecurity4,
        EnhancedSecurity5,
        EnhancedSecurity6,
        EnhancedSecurity7,
        EnhancedSecurity8,
        EnhancedSecurity9,
        EnhancedSecurity0,
        EnhancedSecurity01,
        EnhancedSecurity02,
        EnhancedSecurity03,
        EnhancedSecurity04,
        EnhancedSecurity05,
        EnhancedSecurity06,
        EnhancedSecurity07,
        EnhancedSecurity08,
        EnhancedSecurity09,
        EnhancedSecurity00,
        #endregion
	}
}