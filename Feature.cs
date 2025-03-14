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
        BetaAlgorithm
        CloudSync
        CloudSync2
        CloudSync3
        CloudSync4
        CloudSync5
        CloudSync5
        CloudSync6
        CloudSync7
        CloudSync8
        CloudSync9
        AdvancedFiltering  // New feature added by TeamB
        AdvancedFiltering2  // New feature added by TeamB
        AdvancedFiltering3  // New feature added by TeamB
        AdvancedFiltering4 // New feature added by TeamB
        AdvancedFiltering5  // New feature added by TeamB
        AdvancedFiltering6  // New feature added by TeamB
        AdvancedFiltering7  // New feature added by TeamB
        AdvancedFiltering8  // New feature added by TeamB
        AdvancedFiltering9  // New feature added by TeamB
        ExportToExcel // New feature added by TeamB
        ExportToExcel2 // New feature added by TeamB
        ExportToExcel3 // New feature added by TeamB
        ExportToExcel4 // New feature added by TeamB
        ExportToExcel5 // New feature added by TeamB
        ExportToExcel6 // New feature added by TeamB
        ExportToExcel7 // New feature added by TeamB
        ExportToExcel8 // New feature added by TeamB
        ExportToExcel9 // New feature added by TeamB
        #endregion

        #region TeamC Features
        // TeamC owns this region
        NewPaymentProcessor,
        EnhancedSecurity,
        #endregion
	}
}