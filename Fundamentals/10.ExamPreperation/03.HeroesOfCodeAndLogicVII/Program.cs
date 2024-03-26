namespace _03.HeroesOfCodeAndLogicVII
{
    internal class Hero
    {
        public string Name { get; set; }
        public double HP { get; set; }
        public double MP { get; set; }

        public Hero(string name, double hP, double mP)
        {
            this.Name = name;
            this.HP = hP;
            this.MP = mP;
        }
    }
    internal class Program
    {
        private static double maxHP = 100;
        private static double maxMP = 200;
        private static List<Hero> heroes = new();

        static void Main(string[] args)
        {
            var heroesCount = int.Parse(Console.ReadLine());
            InitializeHeroes(heroesCount);

            var command = string.Empty;
            while((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split(" - ");
                var action = tokens[0];
                var heroName = tokens[1];
                var amount = double.Parse(tokens[2]);
                var currHeroData = heroes.First(x => x.Name == heroName);

                switch (action)
                {
                    case "CastSpell":
                        if (currHeroData.MP - amount >= 0)
                        {
                            currHeroData.MP -= amount;
                            Console.WriteLine($"{heroName} has successfully cast {tokens[3]} and now has {currHeroData.MP} MP!");
                        }
                        else
                            Console.WriteLine($"{heroName} does not have enough MP to cast {tokens[3]}!");
                        break;
                    case "TakeDamage":
                        currHeroData.HP -= amount;
                        if (currHeroData.HP <= 0)
                        {
                            Console.WriteLine($"{heroName} has been killed by {tokens[3]}!");
                            heroes.Remove(currHeroData);
                        }
                        else
                            Console.WriteLine($"{heroName} was hit for {amount} HP by {tokens[3]} and now has {currHeroData.HP} HP left!");
                        break;
                    case "Recharge":
                        if (currHeroData.MP + amount > maxMP)
                            amount = maxMP - currHeroData.MP;

                        currHeroData.MP += amount;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        break;
                    case "Heal":
                        if (currHeroData.HP + amount > maxHP)
                            amount = maxHP - currHeroData.HP;
                        currHeroData.HP += amount;

                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                        break;
                }
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(@$"{hero.Name}
  HP: {hero.HP}
  MP: {hero.MP}");
            }
        }

        private static void InitializeHeroes(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var hp = double.Parse(tokens[1]);
                var mp = double.Parse(tokens[2]);

                if (hp > maxHP) hp = maxHP;
                if (mp > maxMP) mp = maxMP;

                heroes.Add(new Hero(tokens[0], hp, mp));
            }
        }
    }
}
