using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Assets.Scripts.Combat.Entities.Stats
{
    public class Might : Stat<MightSecondaryStats>
    {
        public Might(int value) : base(value) { }
        protected override MightSecondaryStats InitializeSecondaryStats() { return new MightSecondaryStats(); }

        public static int CalculatePhysicalDamageModifier(int might) { throw new NotImplementedException(); }
        public static int CalculateCarryWeight(int might) { throw new NotImplementedException(); }
    }

    public class MightSecondaryStats : ISecondaryStats
    {
        private int physicalDamageModifier;
        private int carryWeight;
        
        public int GetPhysicalDamageModifier() { return physicalDamageModifier; }
        public int GetCarryWeight() { return carryWeight; }

        public void Recalculate(int value)
        {
            physicalDamageModifier = Might.CalculatePhysicalDamageModifier(value);
            carryWeight = Might.CalculateCarryWeight(value);
        }
    }
}