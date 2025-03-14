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
        ExportToExcel91 // New feature added by TeamB
        ExportToExcel92 // New feature added by TeamB
        ExportToExcel93 // New feature added by TeamB
        ExportToExcel94 // New feature added by TeamB
        ExportToExcel95 // New feature added by TeamB
        ExportToExcel96 // New feature added by TeamB
        ExportToExcel97 // New feature added by TeamB
        ExportToExcel98 // New feature added by TeamB
        ExportToExcel99 // New feature added by TeamB
        ExportToExcel19 // New feature added by TeamB
        ExportToExcel29 // New feature added by TeamB
        ExportToExcel39 // New feature added by TeamB
        ExportToExcel49 // New feature added by TeamB
        ExportToExcel59 // New feature added by TeamB
        ExportToExcel69 // New feature added by TeamB
        ExportToExcel79 // New feature added by TeamB
        ExportToExcel89 // New feature added by TeamB
        ExportToExcel99 // New feature added by TeamB
        ExportToExcel00 // New feature added by TeamB
        ExportToExcel01 // New feature added by TeamB
        ExportToExcel02 // New feature added by TeamB
        ExportToExcel03 // New feature added by TeamB
        ExportToExcel04 // New feature added by TeamB
        ExportToExcel05 // New feature added by TeamB
        #endregion

        #region TeamC Features
        // TeamC owns this region
        NewPaymentProcessor,
        EnhancedSecurity,
        #endregion
	}
}