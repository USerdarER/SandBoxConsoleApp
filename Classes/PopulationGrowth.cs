using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBoxConsoleApp.Classes
{
    public static class PopulationGrowth
    {
        public static int CalculateYearsSum(int population, double percent, int aug, int desiredPopulation)
        {
            int yearSum = 0;

            while (population < desiredPopulation)
            {
                population = population + Convert.ToInt32(Math.Floor((population * percent / 100))) + aug;
                yearSum++;
            }
            return yearSum;
        }
    }
}
