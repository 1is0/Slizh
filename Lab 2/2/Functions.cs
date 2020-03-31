using System;
    class Functions
    {
    public static void Calculating(string str)
    {
        int[] counters = new int[10];
        //char tmp = '0';
        foreach (char j in str)
        {
            if (j >= '0' && j <= '9')
            {
                counters[j - '0']++;
            }

        }
        for (int i = 0; i < 10; i++)
        {
            if (counters[i] != 0)
            {
                Console.WriteLine("There are\t" + counters[i] + "\t" + i);
            }
        }
    }
}

