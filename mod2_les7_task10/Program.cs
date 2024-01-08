namespace mod2_les7_task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sideLenghts = [];

            Console.WriteLine("Enter side A: ");
            int sideA = int.Parse(Console.ReadLine());
            sideLenghts.Add(sideA);

            Console.WriteLine("Enter side B: ");
            int sideB = int.Parse(Console.ReadLine());
            sideLenghts.Add(sideB);

            Console.WriteLine("Enter side C: ");
            int sideC = int.Parse(Console.ReadLine());
            sideLenghts.Add(sideC);

            sideLenghts.Sort();

            int longestSide = (sideLenghts.Max());
            int sumOfShorterSides = sideLenghts[0] + sideLenghts[1];

            if (sumOfShorterSides > longestSide)
            {
                Console.WriteLine("A triangle can be build");
            }
            else
            {
                Console.WriteLine("A triangle can't be build");
            }
        }
    }
}
