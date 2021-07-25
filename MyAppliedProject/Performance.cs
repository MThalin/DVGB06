using System;
using System.Diagnostics;

namespace MyAppliedProject
{
    class Performance
    {
        Controller co;

        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;

        public Performance(Controller coIn)
        {
            co = coIn;

            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use", null);
        }

        public void GetPerformance()
        {
            int cpu = (int)cpuCounter.NextValue();
            int ram = (int)ramCounter.NextValue();

            co.PerformanceReAction(cpu, ram);
        }
    }
}
