using GreatBattles.Interfaces;
using GreatBattles.Models;
using System;

namespace GreatBattles;

public class Program
{
    static void Main(string[] args)
    {        
        var skill = new Skill();

        var user = new User(GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom(), "BlackKnight", GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom(), skill);
        var mob = new Mob(GetNewValueRandom(), GetNewValueRandom(), GetNewValueRandom());

        Battle(user, mob, skill);
    }

    static int GetNewValueRandom()
    {
        var random = new Random();
        var newValue = random.Next(1, 100);
        return newValue;
    }

    static void Battle(User user, Mob mob, Skill skill)
    {
        var userLife = user.Life;
        var mobLife = mob.Life;

        userLife = user.Life - mob.Force;
        mobLife = mob.Life - user.Force;

        if (userLife > mobLife)
        {
            skill.Witchcraft += 1;
            skill.Alchemy += 1;
            skill.Stealth += 1;
            skill.Shooting += 1;
            skill.Breaking += 1;
            skill.Destruction += 1;
            skill.Eloquence += 1;
            skill.Recovery += 1;
            
            Console.WriteLine("Победа! Увеличен уровень скиллов");
        }
        else
        {
            Console.WriteLine("Потрачено. Начните битву заново");
            Environment.Exit(0);
        }
    }
}