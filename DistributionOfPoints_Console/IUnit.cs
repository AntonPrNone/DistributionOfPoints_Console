using System;
using System.Collections.Generic;
using System.Text;

namespace DistributionOfPoints_Console
{
    interface IUnit
    {
        void ManagementStrengthWarrior();
        void ManagementDexterityWarrior();
        void ManagementConstitutionWarrior();
        void ManagementIntelligenceWarrior();

        void ManagementStrengthRogue();
        void ManagementDexterityRogue();
        void ManagementConstitutionRogue();
        void ManagementIntelligenceRogue();

        void ManagementStrengthWizard();
        void ManagementDexterityWizard();
        void ManagementConstitutionWizard();
        void ManagementIntelligenceWizard();
    }
}
