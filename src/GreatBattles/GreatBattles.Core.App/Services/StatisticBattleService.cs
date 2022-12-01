using GreatBattles.Core.App.Interfaces;
using GreatBattles.Core.Domain.Models;

namespace GreatBattles.Core.App.Services
{
    public class StatisticBattle : IStatisticBattleService
    {
        public Statistic GetStatistic()
        {
            var skills = new Skill();

            var user = new List<User>();
            var battle = new List<Battle>();
            user.Add(new User());
            var statistic = new Statistic("Fedor", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, skills, 12, 13, 14, user, );

            return statistic;
        }

        public Statistic GetStatisticBattles()
        {
            var statisticBattle = new Statistic();
            return new Statistic();
        }
    }
}
