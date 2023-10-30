class Program
{
    static void Main()
    {
        System.Console.WriteLine("Ievadiet garumu trijstūrim:");
        int rinduSkaitis = int.Parse(System.Console.ReadLine());

        int rinda = 1;
        while (rinda <= rinduSkaitis)
        {
            int kolonna = 1;
            while (kolonna <= rinda)
            {
                System.Console.Write("* ");
                kolonna++;
            }
            System.Console.WriteLine();
            rinda++;
        }

        System.Console.ReadLine();
    }
}
