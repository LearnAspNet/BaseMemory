using GreatBattles.Core.App.Interfaces;
using GreatBattles.Core.Domain.Models;

namespace GreatBattles.Core.App.Services
{
    public class StatisticBattleService : IStatisticBattleService
    {
        public Statistic GetStatistic()
        {
            
            var statistic = new Statistic(5, 10, 300);

            Console.WriteLine($"Раненых: {statistic.Wounded} \nУбитых: {statistic.Killed} \nОбщий урон: {statistic.Damage}");

            return statistic;
        }

        public Statistic GetStatisticBattles()
        {
            var statisticBattle = new Statistic(1000);

            Console.WriteLine($"Общий урон: {statisticBattle.Damage}");

            return statisticBattle;
        }
    }
}
