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
    }

    static int GetNewValueRandom()
    {
        var random = new Random();
        var newValue = random.Next(1, 100);
        return newValue;
    }

    static void Battle(User user, Mob mob)
    {
        if (user.Life > mob.Life && user.Force > mob.Force)
        {
            
        }
    }
}