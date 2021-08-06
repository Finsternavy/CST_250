using System;
using System.Collections.Generic;
using System.Text;

namespace HeroMaker
{
    public class SuperHero
    {
        public string name;
        private bool hasSuperStrength {get; set;}
        private bool hasFly { get; set; }
        private bool hasXRayVision { get; set; }
        private bool hasInvisibility { get; set; }
        private bool hasTelepathy { get; set; }
        private bool hasShields { get; set; }
        private bool hasLazerVision { get; set; }
        private bool hasSelfHeal { get; set; }
        private bool hasShootFireballs { get; set; }
        private bool hasUnlimitedStamina { get; set; }
        private bool hasFreezeTime { get; set; }
        private bool hasCharm { get; set; }

        private string location { get; set; }

        private string preferredTransport { get; set; }
        private string title { get; set; }
        private string capeColor { get; set; }
        private int corruptionLevel { get; set; }
        private DateTime birthdate { get; set; }
        private DateTime powerDiscoveryDate { get; set; }
        private DateTime dateJoinedAvengers { get; set; }
        private int strength { get; set; }
        private int mana { get; set; }
        private int stamina { get; set; }

        List<string> abilites = new List<string>();

        public SuperHero(string name, bool hasSuperStrength, bool hasFly, bool hasXRayVision, bool hasInvisibility, bool hasTelepathy, bool hasShields, bool hasLazerVision,
            bool hasSelfHeal, bool hasShootFireballs, bool hasUnlimitedStamin, bool hasFreezeTime, bool hasCharm, string location, string preferredTransport, string title,
            string capeColor, int corruptionLevel, DateTime birthdate, DateTime powerdiscoverDate, DateTime dateJoinedAvengers, int strength, int mana, int stamina)
        {
            this.name = name;
            this.hasSuperStrength = hasSuperStrength;
            this.hasFly = hasFly;
            this.hasXRayVision = hasXRayVision;
            this.hasInvisibility = hasInvisibility;
            this.hasTelepathy = hasTelepathy;
            this.hasShields = hasShields;
            this.hasLazerVision = hasLazerVision;
            this.hasSelfHeal = hasSelfHeal;
            this.hasShootFireballs = hasShootFireballs;
            this.hasUnlimitedStamina = hasUnlimitedStamin;
            this.hasFreezeTime = hasFreezeTime;
            this.hasCharm = hasCharm;
            this.location = location;
            this.preferredTransport = preferredTransport;
            this.title = title;
            this.capeColor = capeColor;
            this.corruptionLevel = corruptionLevel;
            this.birthdate = birthdate;
            this.powerDiscoveryDate = powerDiscoveryDate;
            this.dateJoinedAvengers = dateJoinedAvengers;
            this.strength = strength;
            this.mana = mana;
            this.stamina = stamina;
        }

        public int abilitiesCount()
        {
            int count = 0;

            if (hasSuperStrength == true)
            {
                abilites.Add("Super Strength");
                count++;
            }
            if (hasFly == true)
            {
                abilites.Add("Flying");
                count++;
            }

            if (hasXRayVision == true)
            {
                abilites.Add("X-Ray Vision");
                count++;
            }
            if (hasInvisibility == true)
            {
                abilites.Add("Invisibility");
                count++;
            }

            if (hasTelepathy == true)
            {
                abilites.Add("Telepathy");
                count++;
            }

            if (hasShields == true)
            {
                abilites.Add("Shields");
                count++;
            }
            if (hasLazerVision == true)
            {
                abilites.Add("Lazer Vision");
                count++;
            }

            if (hasSelfHeal == true)
            {
                abilites.Add("Self-Heal");
                count++;
            }
            if (hasShootFireballs == true)
            {
                abilites.Add("Shoot Fireballs");
                count++;
            }
            if (hasUnlimitedStamina == true)
            {
                abilites.Add("Unlimited Stamina");
                count++;
            }
            if (hasFreezeTime == true)
            {
                abilites.Add("Freeze Time");
                count++;
            }
            if (hasCharm == true)
            {
                abilites.Add("Charm");
                count++;
            }

            return count;
        }

        public string toString()
        {
            StringBuilder SB = new StringBuilder();

            SB.Append(this.name);
            SB.Append(" has ");
            SB.Append(abilitiesCount());
            SB.Append(" abilites: ");

            foreach(string s in abilites)
            {
                SB.Append(s + " ");
            }


            SB.Append(".  " + this.name + " Lives in " + this.location);

            SB.Append(".  Preferred mode of travel is: " + this.preferredTransport);

            SB.Append("  Corruption Meter: " + corruptionLevel + " Cape Color: " + this.capeColor);

            SB.Append("  Strength: " + this.strength + "  Mana: " + this.mana + "  Stamina: " + this.stamina);

            return SB.ToString();

            
        }
    }
}
