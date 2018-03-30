using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Combat.DiceRolling
{
    public class DiceTower
    {
        private Random random;  
        private List<RollInfo> loggedRolls;

        public DiceTower()
        {
            this.random = new Random();
            this.loggedRolls = new List<RollInfo>();
        }

        public int Roll(int diceType)
        {
            return random.Next(diceType);
        }

        public int Roll(int diceType, string description)
        {
            int result = Roll(diceType);
            Log(diceType, description, new[]{ result });
            return result;
        }

        public int[] Roll(int diceType, int times)
        {
            int[] results = new int[times];
            foreach (int i in Enumerable.Range(0, times))
            {
                results[i] = Roll(diceType);
            }
            return results;
        }

        public int[] Roll(int diceType, int times, string description)
        {
            int[] results = Roll(diceType, times);
            Log(diceType, description, results);
            return results;
        }

        public void Log(int diceType, string description, params int[] results)
        {
            loggedRolls.Add(new RollInfo(diceType, description, results));
        }

        // Convenience functions

        public int d2() => Roll(2);
        public int d2(string description) => Roll(2, description);
        public int[] d2(int times) => Roll(2, times);
        public int[] d2(int times, string description) => Roll(2, times, description);

        public int d4() => Roll(4);
        public int d4(string description) => Roll(4, description);
        public int[] d4(int times) => Roll(4, times);
        public int[] d4(int times, string description) => Roll(4, times, description);

        public int d6() => Roll(6);
        public int d6(string description) => Roll(6, description);
        public int[] d6(int times) => Roll(6, times);
        public int[] d6(int times, string description) => Roll(6, times, description);

        public int d8() => Roll(8);
        public int d8(string description) => Roll(8, description);
        public int[] d8(int times) => Roll(8, times);
        public int[] d8(int times, string description) => Roll(8, times, description);

        public int d10() => Roll(10);
        public int d10(string description) => Roll(10, description);
        public int[] d10(int times) => Roll(10, times);
        public int[] d10(int times, string description) => Roll(10, times, description);

        public int d12() => Roll(12);
        public int d12(string description) => Roll(12, description);
        public int[] d12(int times) => Roll(12, times);
        public int[] d12(int times, string description) => Roll(12, times, description);

        public int d20() => Roll(20);
        public int d20(string description) => Roll(20, description);
        public int[] d20(int times) => Roll(20, times);
        public int[] d20(int times, string description) => Roll(20, times, description);

        public int d100() => Roll(100);
        public int d100(string description) => Roll(100, description);
        public int[] d100(int times) => Roll(100, times);
        public int[] d100(int times, string description) => Roll(100, times, description);
    }

    public class RollInfo
    {
        public readonly int diceType;
        public readonly string description;
        public readonly int[] results;

        public RollInfo(int diceType, string description, params int[] results)
        {
            this.diceType = diceType;
            this.description = description;
            this.results = results;
        }
    }
}
