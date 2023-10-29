class Program
{
    
    static void Main(string[] args)
    {
        char[] arr = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //  int[] choiceIndex = new int[arr.Length];

        int n = 1;

        while (n<9)
        {
            execute(arr);
             n++;
        }
    }
    static void execute(char[] arr)
    {
        int count = 0;
        Console.WriteLine("Player1:X and Computer:O");
        Console.Clear();
        display(arr);
        Console.WriteLine("Enter choice");
        var choice = int.Parse(Console.ReadLine());
        var index = --choice;
       
        arr[choice] = 'X';
        Console.Clear();
        display(arr);
        for (int i=0; i<arr.Length; i++)
        {
            if(i == index)
            {
                arr[GenerateNumber(index)] = 'O';
                Console.Clear();
                display(arr);
            }
        }
        


        

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
       return new Random().Next(start,9);
    }
}






