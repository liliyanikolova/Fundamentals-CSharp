namespace _1.CollectResources
{
    using System;
    using System.Collections.Generic;

    public class CollectResourcesMain
    {
        public static void Main(string[] args)
        {
            string[] inputResource = Console.ReadLine().Split();

            List<string> validResourses =new List<string> { "stone", "gold", "wood", "food" };
            string[,] resources = new string[inputResource.Length, 2];
            for (int i = 0; i < inputResource.Length; i++)
            {
                if (inputResource[i].Contains("_"))
                {
                    string[] resourceSplit = inputResource[i].Split('_');
                    resources[i, 0] = resourceSplit[0];
                    resources[i, 1] = resourceSplit[1];
                }
                else
                {
                    resources[i, 0] = inputResource[i];
                    resources[i, 1] = "1";
                }
            }


            int maxQuantity = 0;
            int collPaths = int.Parse(Console.ReadLine());
            for (int i = 0; i < collPaths; i++)
            {
                string[] path = Console.ReadLine().Split();
                int start = int.Parse(path[0]);
                int step = int.Parse(path[1]);

                List<int> alreadyCollectedElements = new List<int>();
                int quantity = 0;

                while (!alreadyCollectedElements.Contains(start))
                {
                    alreadyCollectedElements.Add(start);
                    if (validResourses.Contains(resources[start, 0]))
                    {
                        quantity += int.Parse(resources[start, 1]);
                    }

                    start = (start + step) % resources.GetLength(0);
                }

                if (maxQuantity < quantity)
                {
                    maxQuantity = quantity;
                }
            }

            Console.WriteLine(maxQuantity);
        }
    }
}
