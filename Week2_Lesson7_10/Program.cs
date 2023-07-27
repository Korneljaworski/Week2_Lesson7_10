public class Program
{
    private static void Main(string[] args)
    {
        /*
            Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt
            Dane testowe : 40 55 65
            Rezultat w terminalu :
            Można zbudować trójkąt
        */

        Console.WriteLine("Podaj bok a:");
        double a = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Podaj bok b:");
        double b = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Podaj bok c:");
        double c = Int32.Parse(Console.ReadLine());

        if (a <= c && b <= c && a + b > c)
        {
            Console.WriteLine("Można zbudować trójkąt.");
        }
        else if (a <= b && c <= b && a + c > b)
        {
            Console.WriteLine("Można zbudować trójkąt.");
        }
        else if (b <= a && c <= a && b + c > a)
        {
            Console.WriteLine("Można zbudować trójkąt.");
        }
        else
        {
            Console.WriteLine("Nie można zbudować trójkąta.");
        }

    }

}
