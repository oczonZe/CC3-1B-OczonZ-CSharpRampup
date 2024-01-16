namespace CSharpRampup
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Weight in Pounds (lbs):");
        double pounds = Convert.ToDouble(Console.ReadLine());
        double weightKg = pounds * 0.453592;
        Console.WriteLine("Weight converted to Kilograms (kg):" + weightKg);
        Console.WriteLine("==================================================");
        
        Console.WriteLine("Length in Miles (mi):");
        double lengthMi = Convert.ToDouble(Console.ReadLine());
        double lengthKm = lengthMi * 1.60934;
        Console.WriteLine("Length in Kilometers (km):" + lengthKm);
        Console.WriteLine("==================================================");
        
        Console.WriteLine("Temperature in Fahrenheit (F):");
        double temperatureFah = Convert.ToDouble(Console.ReadLine());
        double temperatureCel = (temperatureFah - 32) * 5.0 / 9.0;
        Console.WriteLine("Temperature in Celsius (C):" + temperatureCel);
        Console.WriteLine("==================================================");

        int[] studentAges = new int[10];
        int totalAge = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter age of student " + (i + 1) + ": ");
            studentAges[i] = Convert.ToInt32(Console.ReadLine());
            totalAge += studentAges[i];
        }

        double averageAge = totalAge / 10.0;

        // Outputting ages and average age
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Age of Student " + (i + 1) + ": " + studentAges[i]);
        }

        Console.WriteLine("The average age of the students is: " + averageAge.ToString("F2"));
        
        }
    }
}
