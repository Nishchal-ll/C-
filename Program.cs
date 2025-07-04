using System.Configuration.Assemblies;

class Add
{
    public int sum;
    public Add(int x, int y)
    {
        sum = x + y;
        Console.WriteLine("The sum is {0}", sum);
    }

    static void Main(string[] args)
    {
        int number1 = 2;
        int number2 = 3;

        Add addition = new Add(number1, number2);
    }
}







    




