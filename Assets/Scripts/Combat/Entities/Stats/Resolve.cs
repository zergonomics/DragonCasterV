using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Combat.Entities.Stats
{
    public class Resolve : Stat<ResolveSecondaryStats>
    {
        public Resolve(int value) : base(value) { }
        protected override ResolveSecondaryStats InitializeSecondaryStats() { return new ResolveSecondaryStats(); }

        public static int CalculateHealingModifier(int resolve) { throw new NotImplementedException(); }
        public static int CalculateHpRegen(int resolve) { throw new NotImplementedException(); }
        public static int CalculateWill(int resolve) { throw new NotImplementedException(); }
    }

    public class ResolveSecondaryStats : ISecondaryStats
    {
        private int healingModifier;
        private int hpRegen;
        private int will;

        public int GetHealingModifier() { return healingModifier; }
        public int GetHpRegen() { return hpRegen; }
        public int GetWill() { return will; }

        public void Recalculate(int value)
        {
            healingModifier = Resolve.CalculateHealingModifier(value);
            hpRegen = Resolve.CalculateHpRegen(value);
            will = Resolve.CalculateWill(value);
        }
    }
}