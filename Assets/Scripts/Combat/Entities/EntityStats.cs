namespace Assets.Scripts.Combat.Entities.Stats
{
    public class EntityStats
    {
        private Might might;
        private Agility agility;
        private Fortitude fortitude;
        private Intellect intellect;
        private Resolve resolve;

        public EntityStats(int might, int agility, int fortitude, int intellect, int resolve)
        {
            this.might = new Might(might);
            this.agility = new Agility(agility);
            this.fortitude = new Fortitude(fortitude);
            this.intellect = new Intellect(intellect);
            this.resolve = new Resolve(resolve);
        }

        // Primary stats objects

        public Might GetMight() { return might; }
        public Agility GetAgility() { return agility; }
        public Fortitude GetFortitude() { return fortitude; }
        public Intellect GetIntellect() { return intellect; }
        public Resolve GetResolve() { return resolve; }

        // Conveience setting functions

        public void SetMight(int might) { this.might.Set(might); }
        public void SetAgility(int agility) { this.agility.Set(agility); }
        public void SetFortitude(int fortitude) { this.fortitude.Set(fortitude); }
        public void SetIntellect(int intellect) { this.intellect.Set(intellect); }
        public void SetResolve(int resolve) { this.resolve.Set(resolve); }

        public void SetStats(int might, int agility, int fortitude, int intellect, int resolve)
        {
            SetMight(might);
            SetAgility(agility);
            SetFortitude(fortitude);
            SetIntellect(intellect);
            SetResolve(resolve);
        }

        // Conenience function for primary stats

        public int GetMightValue() { return might.Get(); }
        public int GetAgilityValue() { return agility.Get(); }
        public int GetFortitudeValue() { return fortitude.Get(); }
        public int GetIntellectValue() { return intellect.Get(); }
        public int GetResolveValue() { return resolve.Get(); }

        // Convenience functions for secondary stats

        public int GetPhysicalDamageModifier() { return might.GetSecondaryStats().GetPhysicalDamageModifier(); }
        public float GetCarryWeight() { return might.GetSecondaryStats().GetCarryWeight(); }

        public float GetDodgeChance() { return agility.GetSecondaryStats().GetDodgeChance(); }
        public float GetCritChance() { return agility.GetSecondaryStats().GetCritChance(); }
        public int GetMovespeed() { return agility.GetSecondaryStats().GetMovespeed(); }

        public int GetArmor() { return fortitude.GetSecondaryStats().GetArmor(); }
        public int GetHpModifier() { return fortitude.GetSecondaryStats().GetHpModifier(); }

        public int GetMagicDamageModifier() { return intellect.GetSecondaryStats().GetMagicDamageModifier(); }

        public int GetHealingModifier() { return resolve.GetSecondaryStats().GetHealingModifier(); }
        public int GetHpRegen() { return resolve.GetSecondaryStats().GetHpRegen(); }
        public int GetWill() { return resolve.GetSecondaryStats().GetWill(); }
    }
}