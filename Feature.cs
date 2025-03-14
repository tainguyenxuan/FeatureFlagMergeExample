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
        #endregion
	}
}