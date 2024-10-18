namespace Topic_8_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1 Raine DeVries
            Random random = new Random(6);
            //int number;
            //List<string> colors = new List<string>();
            //Console.WriteLine("How many colours do you want to pick from?");
            //int.TryParse(Console.ReadLine(), out number);
            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine("Give me a colour please");
            //    colors.Add(Console.ReadLine());
               
            //}

            //Console.WriteLine(string.Join(", " , colors));
            //Console.WriteLine("Random one: ");
            //Console.WriteLine(colors[random.Next(colors.Count)]);

            //Part 2
            
            int amount;
            int max;
            int min;
            List<int> numbers = new List<int>();


            Console.WriteLine("How many numbers do you need?");
            int.TryParse(Console.ReadLine(), out amount);
            Console.WriteLine("What's the max number?");
            int.TryParse(Console.ReadLine(), out max);
            Console.WriteLine("What's the min number");
            int.TryParse(Console.ReadLine(), out min);
            if (min > max )
            {
                Console.WriteLine("Not usable info, I will now make equal");
                min = amount; max = amount; (min, max) = (max, min);
            }
            for (int i = 0; i < amount; i++)
            { 
                 numbers.Add(random.Next(min, (max+1)));
            }


            Console.WriteLine(string.Join(", ", numbers));




        }
    }
}
