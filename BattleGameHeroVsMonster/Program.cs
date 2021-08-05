using System;

namespace BattleGameHeroVsMonster
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroHP = 10;
            int monsterHP = 10;

            Random hit = new Random();

            do
            {
                int damage = hit.Next(1, 11);
                monsterHP -= damage;
                Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHP} health.");

                if (monsterHP <= 0) continue;

                damage = hit.Next(1, 11);
                heroHP -= damage;
                Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHP} health.");

            } while (heroHP > 0 && monsterHP > 0);

Console.WriteLine(heroHP > monsterHP ? "Hero wins!" : "Monster wins!");
        }
    }
}
