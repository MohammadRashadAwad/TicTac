class Program
{
    static char[] arr = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int[] choiceIndex = new int[arr.Length];
    static void Main(string[] args)
    {
        
        


        while (true)
        {
            execute(arr);
        }
    }
    static void execute(char[] arr)
    {
        Console.WriteLine("Player1:X and Computer:O");
        Console.Clear();
        display(arr);
        Console.WriteLine("Enter choice");
        var choice = int.Parse(Console.ReadLine());
        --choice;
        arr[choice] = 'X';


        Console.Clear();
        display(arr);

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
}






