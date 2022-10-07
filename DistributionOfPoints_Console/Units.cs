using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;


namespace DistributionOfPoints_Console
{
    [BsonIgnoreExtraElements]
    public class Unit : IUnit
    {
        // indicators
        public string Name { get; internal set; }

        public int skillPoints { get; private set; }
        public int skillPointsMax { get; private set; }
        public double maxHP { get; private set; }
        public double maxMP { get; private set; }
        public double PAttack { get; private set; }
        public double MAttack { get; private set; }
        public double PDef { get; private set; }

        // specifications
        public int[] strength { get; private set; }  // minimum level; actual level; maximum level
        public int[] dexterity { get; private set; }
        public int[] constitution { get; private set; }
        public int[] intelligence { get; private set; }

        public Unit(string Name, int skillPoints, int skillPointsMax, double maxHP, double maxMP, double PAttack, double MAttack,
                    double PDef, int[] strength, int[] dexterity, int[] constitution, int[] intelligence) // Manual creation
        {
            this.Name = Name;
            this.skillPoints = skillPoints;
            this.skillPointsMax = skillPointsMax;
            this.maxHP = maxHP;
            this.maxMP = maxMP;
            this.PAttack = PAttack;
            this.MAttack = MAttack;
            this.PDef = PDef;

            this.strength = strength;
            this.dexterity = dexterity;
            this.constitution = constitution;
            this.intelligence = intelligence;
        }

        // ---------------------------------------------------- WARRIOR ----------------------------------------------------

        public void ManagementStrengthWarrior(char sign)
        {
            if (sign == '+' && (strength[1] < strength[2] && skillPoints > 0))
            {
                skillPoints--;
                strength[1]++;

                PAttack += 5;
                maxHP += 2;
            }

            else if (sign == '-' && (strength[0] < strength[1] && skillPoints < skillPointsMax))
            {
                skillPoints++;
                strength[1]--;

                PAttack -= 5;
                maxHP -= 2;
            }
        }

        public void ManagementDexterityWarrior(char sign)
        {
            if (sign == '+' && (dexterity[1] < dexterity[2] && skillPoints > 0))
            {
                skillPoints--;
                dexterity[1]++;

                PAttack++;
                PDef++;
            }

            else if (sign == '-' && (dexterity[0] < dexterity[1] && skillPoints < skillPointsMax))
            {
                skillPoints++;
                dexterity[1]--;

                PAttack--;
                PDef--;
            }
        }

        public void ManagementConstitutionWarrior(char sign)
        {
            if (sign == '+' && (constitution[1] < constitution[2] && skillPoints > 0))
            {
                skillPoints--;
                constitution[1]++;

                maxHP += 10;
                PDef += 2;
            }

            else if (sign == '-' && (constitution[0] < constitution[1] && skillPoints < skillPointsMax))
            {
                skillPoints++;
                constitution[1]--;

                maxHP -= 10;
                PDef -= 2;
            }
        }

        public void ManagementIntelligenceWarrior(char sign)
        {
            if (sign == '+' && (intelligence[1] < intelligence[2] && skillPoints > 0))
            {
                skillPoints--;
                intelligence[1]++;

                maxMP++;
                MAttack++;
            }

            else if (sign == '-' && (intelligence[0] < intelligence[1] && skillPoints < skillPointsMax))
            {
                skillPoints++;
                intelligence[1]--;

                maxMP--;
                MAttack--;
            }
        }

        // ---------------------------------------------------- ROGUE ----------------------------------------------------

        public void ManagementStrengthRogue(char sign)
        {
            if (sign == '+' && (strength[1] < strength[2] && skillPoints > 0))
            {
                skillPoints--;
                strength[1]++;

                PAttack += 2;
                maxHP++;
            }

            else if (sign == '-' && (strength[0] < strength[1] && skillPoints < skillPointsMax))
            {
                skillPoints++;
                strength[1]--;

                PAttack -= 2;
                maxHP--;
            }
        }

        public void ManagementDexterityRogue(char sign)
        {
            if (sign == '+' && (dexterity[1] < dexterity[2] && skillPoints > 0))
            {
                skillPoints--;
                dexterity[1]++;

                PAttack += 4;
                PDef += 1.5;
            }

            else if (sign == '-' && (dexterity[0] < dexterity[1] && skillPoints < skillPointsMax))
            {
                skillPoints++;
                dexterity[1]--;

                PAttack -= 4;
                PDef -= 1.5;
            }
        }

        public void ManagementConstitutionRogue(char sign)
        {
            if (sign == '+' && (constitution[1] < constitution[2] && skillPoints > 0))
            {
                skillPoints--;
                constitution[1]++;

                maxHP += 6;
            }

            else if (sign == '-' && (constitution[0] < constitution[1] && skillPoints < skillPointsMax))
            {
                skillPoints++;
                constitution[1]--;

                maxHP -= 6;
            }
        }

        public void ManagementIntelligenceRogue(char sign)
        {
            if (sign == '+' && (intelligence[1] < intelligence[2] && skillPoints > 0))
            {
                skillPoints--;
                intelligence[1]++;

                maxMP += 1.5;
                MAttack += 2;
            }

            else if (sign == '-' && (intelligence[0] < intelligence[1] && skillPoints < skillPointsMax))
            {
                skillPoints++;
                intelligence[1]--;

                maxMP -= 1.5;
                MAttack -= 2;
            }
        }

        // ---------------------------------------------------- WIZARD ----------------------------------------------------

        public void ManagementStrengthWizard(char sign)
        {
            if (sign == '+' && (strength[1] < strength[2] && skillPoints > 0))
            {
                skillPoints--;
                strength[1]++;

                PAttack += 3;
                maxHP++;
            }

            else if (sign == '-' && (strength[0] < strength[1] && skillPoints < skillPointsMax))
            {
                skillPoints++;
                strength[1]--;

                PAttack -= 3;
                maxHP--;
            }
        }

        public void ManagementDexterityWizard(char sign)
        {
            if (sign == '+' && (dexterity[1] < dexterity[2] && skillPoints > 0))
            {
                skillPoints--;
                dexterity[1]++;

                PDef += 0.5;
            }

            else if (sign == '-' && (dexterity[0] < dexterity[1] && skillPoints < skillPointsMax))
            {
                skillPoints++;
                dexterity[1]--;

                PDef -= 0.5;
            }
        }

        public void ManagementConstitutionWizard(char sign)
        {
            if (sign == '+' && (constitution[1] < constitution[2] && skillPoints > 0))
            {
                skillPoints--;
                constitution[1]++;

                maxHP += 3;
                PDef++;
            }

            else if (sign == '-' && (constitution[0] < constitution[1] && skillPoints < skillPointsMax))
            {
                skillPoints++;
                constitution[1]--;

                maxHP -= 3;
                PDef--;
            }
        }

        public void ManagementIntelligenceWizard(char sign)
        {
            if (sign == '+' && (intelligence[1] < intelligence[2] && skillPoints > 0))
            {
                skillPoints--;
                intelligence[1]++;

                maxMP += 2;
                MAttack += 5;
            }

            else if (sign == '-' && (intelligence[0] < intelligence[1] && skillPoints < skillPointsMax))
            {
                skillPoints++;
                intelligence[1]--;

                maxMP -= 2;
                MAttack -= 5;
            }
        }
    }
}
