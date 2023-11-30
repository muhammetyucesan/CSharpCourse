namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Muhammet", "Kadriye", "Ali" }; 
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.ReadLine();

            string[,] regions = new string[5, 3]
            {
            {"İstanbul", "Balıkesir", "İzmit"},
            {"Ankara", "Konya", "Kırıkkale"},
            {"Antalya", "Adana", "Mersin"},
            {"Rize", "Trabzon ", "Samsun"},
            {"İzmir", "Manisa", "Muğla"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*****");
            }
        }
    }
}