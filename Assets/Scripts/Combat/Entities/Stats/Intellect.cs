using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Assets.Scripts.Combat.Entities.Stats
{
    public class Intellect : Stat<IntellectSecondaryStats>
    {
        public Intellect(int value) : base(value) { }
        protected override IntellectSecondaryStats InitializeSecondaryStats() { return new IntellectSecondaryStats(); }

        public static int CalculateMagicDamageModifier(int intellect) { throw new NotImplementedException();}
    }

    public class IntellectSecondaryStats : ISecondaryStats
    {
        private int magicDamageModifier;

        public int GetMagicDamageModifier() { return magicDamageModifier; }

        public void Recalculate(int value)
        {
            magicDamageModifier = Intellect.CalculateMagicDamageModifier(value);
        }
    }
}