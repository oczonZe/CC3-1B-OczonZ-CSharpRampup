using System;

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
            Console.WriteLine("==================================================");

            string champion1 = "Garen ";
            string champion2 = "Ahri";
            string champion3 = "Yasuo";
            string champion4 = "Ashe";
            string champion5 = "Darius";

            string weapon1 = "Decisive Strike";
            string weapon2 = "Orb of Deception";
            string weapon3 = "Wind Blade";
            string weapon4 = "Enchanted Crystal Arrow";
            string weapon5 = "Noxian Guillotine";

            string item1 = "Sunfire Cape";
            string item2 = "Luden's Tempest";
            string item3 = "Stormrazor";
            string item4 = "Infinity Edge";
            string item5 = "Black Cleaver";

            string ability1 = "Courage";
            string ability2 = "Charm";
            string ability3 = "Last Breath";
            string ability4 = "Enchanted Crystal Arrow";
            string ability5 = "Apprehend";

            string story = "In the world of Runeterra, five legendary champions from different regions set out on a grand adventure:" +
                           champion1 + ", known as the Might of Demacia, brandished the " + weapon1 + ", striking fear into everyone of his enemies." +
                           champion2 + ", the Nine-Tailed Fox, possessed the mysterious " + weapon2 + ", manipulating magic with every flick of her tails." +
                           champion3 + ", the Unforgiven, wielded the swift " + weapon3 + ", slicing through enemies with the swift of the wind." +
                           champion4 + ", the Frost Archer, unleashing the powerful " + weapon4 + ", sending icy arrows to pierce the bodies of her foes." +
                           champion5 + ", the Hand of Noxus, executed enemies with the mighty " + weapon5 + ", leaping through the enemy and striking a lethal blow." +
                           "Each champion equipped themselves with legendary items:" +
                           champion1 + " wearing the mighty " + item1 + ", a cape with the flames of Demacia." +
                           champion2 + " carrying " + item2 + ", a mystical relic that enhanced her ability to cast spells." +
                           champion3 + " wielded with the ancient " + item3 + ", enhancing his swift and deadly strikes." +
                           champion4 + " wielded the mighty " + item4 + ", transforming her arrows into deadly projectiles." +
                           champion5 + " equipped with a fearsome " + item5 + ", to crush the armor of his foes." +
                           "Their abilities were renowned across Runeterra:" +
                           champion1 + " displayed unyielding " + ability1 + ", shrugging off damage with indomitable courage." +
                           champion2 + " stunned opponents with her captivating " + ability2 + ", manipulating their emotions." +
                           champion3 + " unleashed the power of " + ability3 + ", Last Breath, dashing through enemies with his wind-infused strikes." +
                           champion4 + " unleashed the mighty " + ability4 + ", firing a crystal arrow across the map, freezing enemies in their tracks." +
                           champion5 + " apprehended foes with the powerful " + ability5 + ", dragging them closer for a swift execution." +
                           "Together, these legendary champions embarked on a quest to restore balance to Runeterra, facing formidable foes, uncovering ancient artifacts, and shaping the fate of the Great League of Legends.";

            Console.WriteLine(story);
            Console.WriteLine("=====================================");

            Console.WriteLine("Part 2");

            Console.Write("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                Console.Write(i);
                if (i < n)
                {
                    Console.Write(" + ");
                }
            }
            
            Console.WriteLine(" = " + sum);
            
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num) && num > 0)
            {
                for (int i = num; i > 0; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
