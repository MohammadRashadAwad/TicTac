using System;

class Program
{

   static char[] baseArray = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static List<int> PlayerOneChoices = new List<int>();
    static List<int> PlayerTwoChoices = new List<int>();


    static void Main(string[] args)
    {
        //int[] userIndexes = new int[5];
        //int[] computerIndexes = new int[5];
        //char userPlayer = 'X';

        while (true)
        {
            execute();
        }
    }


    static void execute()
    {
       // Console.WriteLine("Player1:X and Computer:O");
        Console.Clear();
        display(baseArray);
        Console.WriteLine("Enter choice");
        var choice = int.Parse(Console.ReadLine());

        var index = --choice;
        PlayerOneChoices.Add(index);

        baseArray[choice] = 'X';
        Console.Clear();
      //  display(arr);
        for (int i = 0; i < baseArray.Length; i++)
        {
            if (i == index)
            {
                baseArray[GenerateNumber(index)] = 'O';
                Console.Clear();
                display(baseArray);
            }
        }
        AvailableChoices();




    }
    static void display(char[] arr)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{arr[0]}\t{arr[1]}\t{arr[2]}");
        Console.WriteLine("");
        Console.WriteLine($"{arr[3]}\t{arr[4]}\t{arr[5]}");
        Console.WriteLine("");
        Console.WriteLine($"{arr[6]}\t{arr[7]}\t{arr[8]}");
        Console.WriteLine("------------------------------");

    }

    static int GenerateNumber(int start)
    {
        return new Random().Next(start, 9);
    }


    static int PlayerTwo()
    {

        return 0;
    }

    static List<int> AvailableChoices()
    {
        var arr = baseArray
            .Where((w, index) => !PlayerOneChoices.Contains(index) && !PlayerTwoChoices.Contains(index)).ToList();
        //  if (PlayerOneChoices)

        return new List<int>();
    }
    
}








