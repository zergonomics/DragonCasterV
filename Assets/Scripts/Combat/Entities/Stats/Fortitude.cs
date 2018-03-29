using System;

namespace Assets.Scripts.Combat.Entities.Stats
{
    public class Fortitude : Stat<FortitudeSecondaryStats>
    {
        public Fortitude(int value) : base(value) { }
        protected override FortitudeSecondaryStats InitializeSecondaryStats() { return new FortitudeSecondaryStats(); }

        public static int CalculateArmor(int fortitude) { throw new NotImplementedException(); }
        public static int CalculateHpModifier(int fortitude) { throw new NotImplementedException(); }
    }

    public class FortitudeSecondaryStats : ISecondaryStats
    {
        private int armor;
        private int hpModifier;

        public int GetArmor() { return armor; }
        public int GetHpModifier() { return hpModifier; }

        public void Recalculate(int value)
        {
            armor = Fortitude.CalculateArmor(value);
            hpModifier = Fortitude.CalculateHpModifier(value);
        }
    }
}