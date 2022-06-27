namespace SetCover
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var inputUniverse = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            for (int row = 0; row < n; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            }

            List<int[]> list = ChooseSets(jaggedArray, inputUniverse);

            Console.WriteLine($"Sets to take ({list.Count}):");

            foreach (var item in list)
            {
                Console.WriteLine("{ " + string.Join(", ", item) + " }");
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            List<int[]> result = new List<int[]>();


            while (universe.Count > 0)
            {
                int[] longestSet = sets.OrderByDescending(x => x.Count(x => universe.Contains(x))).FirstOrDefault();

                foreach (var item in longestSet)
                {
                    if (universe.Contains(item))
                    {
                        universe.Remove(item);
                    }
                }
                result.Add(longestSet);
            }

            return result;
        }
    }
}
