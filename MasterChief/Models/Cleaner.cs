using System;
using System.Collections.Generic;
using MasterChief.Models;
using MasterChief.Tools;

namespace MasterChief.Models
{
    public class Cleaner : Entity
    {
        private const int TimeToWashTools = 15;
        private int TimeRemainingWashTools { get; set; }
        private bool WashingTools { get; set; }

        public Cleaner()
        {
            TimeRemainingWashTools = TimeToWashTools;
        }

        public override void Tick()
        {
            if (this.WashingTools)
            {
                TimeRemainingWashTools--;

                if (TimeRemainingWashTools <= 0)
                {
                    TimeRemainingWashTools = TimeToWashTools;
                    Console.WriteLine("Washing tools terminated");
                }
            }
        }

        public void WashTools(List<Tool> tools)
        {
            this.WashingTools = true;
            Console.WriteLine("Washing tools");
            Console.WriteLine("-------------");
            foreach (Tool tool in tools)
            {
                Console.WriteLine("Tool : {0}", tool.GetType().Name);
            }
            Console.WriteLine();
        }
    }
}