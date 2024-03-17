public class Program{

    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Modification1");
        Console.WriteLine("Modification2");
        Console.WriteLine("Modification3");

        int[] tab = { 1, 6, 7, 4, 3, 2, 5, 6 };
        Console.WriteLine(Avg(tab));
        Console.WriteLine((Max(tab)));
    }

    
    public static double Avg(int[] tab)
    {
        double suma=0;
        for (int j = 0; j < tab.Length; j++)
        {
            
            suma += tab[j];
        }
        
        return suma/tab.Length;   
    }

    public static int Max(int[] tab)
    {
        int max = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i]>max)
            {
                max = tab[i];
            }
        }

        return max;
    }

}