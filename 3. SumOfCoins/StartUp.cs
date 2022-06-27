namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var coinsRange = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int sum = int.Parse(Console.ReadLine());

            Dictionary<int, int> coins = ChooseCoins(coinsRange, sum);

            Console.WriteLine($"Number of coins to take: { coins.Sum(x => x.Value)}");

            foreach (var item in coins)
            {
                Console.WriteLine($"{ item.Value} coin(s) with value { item.Key}");
            }

        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            Dictionary<int, int> coinsMap = new Dictionary<int, int>();
            while (targetSum != 0)
            {
                var coinList = coins.Where(x => x <= targetSum);

                if (coinList.Any())
                {
                    int maxCoinValue = coinList.Max();
                    if (maxCoinValue <= targetSum)
                    {
                        targetSum -= maxCoinValue;
                        if (!coinsMap.ContainsKey(maxCoinValue))
                        {
                            coinsMap.Add(maxCoinValue, 1);
                        }
                        else
                        {
                            coinsMap[maxCoinValue]++;
                        }
                    }
                }
                else
                {
                    throw new InvalidOperationException("Error");
                }
            }

            return coinsMap;
           
        }
    }
}