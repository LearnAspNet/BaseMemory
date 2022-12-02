using GreatBattles.Core.Domain.Models;
using GreatBattles.Core.App.Services;

namespace GreatBattles;

public class Program
{
    static void Main(string[] args)
    {        
        var skill = new Skill();

        var user = new User(GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom(), "BlackKnight", GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom(), skill);
        var mob = new Mob(GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom());

        var battleService = new BattleService();
        var staticticBattleService = new StatisticBattleService();

        //battleService.Battle(user, mob, skill);

        staticticBattleService.GetStatistic(); 

        staticticBattleService.GetStatisticBattles();
    }

    static int GetNewValueRandom()
    {
        var random = new Random();
        var newValue = random.Next(1, 100);
        return newValue;
    }
}