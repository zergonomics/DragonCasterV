using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Combat.Entities.Stats
{
    public interface ISecondaryStats
    {
        void Recalculate(int value);
    }

    public abstract class Stat<T> where T : ISecondaryStats
    {
        private int value;
        private bool needsRecalculation;
        private T secondaryStats;

        public Stat(int value)
        {
            this.value = value;
            this.needsRecalculation = true;
            this.secondaryStats = InitializeSecondaryStats();
        }

        protected abstract T InitializeSecondaryStats();

        public void Set(int value)
        {
            this.value = value;
            this.needsRecalculation = true;
        }

        public int Get()
        {
            return value;
        }

        public T GetSecondaryStats()
        {
            if (this.needsRecalculation)
            {
                secondaryStats.Recalculate(value);
                this.needsRecalculation = false;
            }
            return secondaryStats;
        }
    }

}