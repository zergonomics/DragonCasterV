using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Combat.Entities.Stats
{
    public class Agility : Stat<AgilitySecondaryStats>
    {
        public Agility(int value) : base(value) { }
        protected override AgilitySecondaryStats InitializeSecondaryStats() { return new AgilitySecondaryStats(); }
        
        public static float CalculateDodgeChance(int agility) { throw new NotImplementedException(); }
        public static float CalculateCritChance(int agility) { throw new NotImplementedException(); }
        public static int CalculateMovespeed(int agility) { throw new NotImplementedException(); }
    }

    public class AgilitySecondaryStats : ISecondaryStats
    {
        private float dodgeChance;
        private float critChance;
        private int movespeed;

        public float GetDodgeChance() { return dodgeChance; }
        public float GetCritChance() { return critChance; }
        public int GetMovespeed() { return movespeed; }

        public void Recalculate(int value)
        {
            dodgeChance = Agility.CalculateDodgeChance(value);
            critChance = Agility.CalculateCritChance(value);
            movespeed = Agility.CalculateMovespeed(value);
        }
    }
}