using System;
using System.Globalization;

class Desafio {
    static void Main() {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0], CultureInfo.InvariantCulture);
            double Y = double.Parse(line[1], CultureInfo.InvariantCulture);

            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            } else {
                double z = X / Y;
                Console.WriteLine(z.ToString("0.0", CultureInfo.InvariantCulture));
            }
        }
    }
}
