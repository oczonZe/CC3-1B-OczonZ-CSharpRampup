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
        
        }
    }
}
