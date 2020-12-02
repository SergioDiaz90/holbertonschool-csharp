using System;
class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int num = rndm.Next(-10, 10);
        if (num > 0)
            Console.WriteLine("{0} is positive", num);
        else if (num == 0)
            Console.WriteLine("{0} is zero", num);
        else
            Console.WriteLine("{0} is negative", num);
    }
}
