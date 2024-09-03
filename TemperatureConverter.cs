class Test
{
    public static string TempConvert(String unit, double tempValue)
    {
        if (unit == "C" || unit == "c")
        {
            double fahrenheit = (1.8 * tempValue) + 32;
            return $"{fahrenheit:F2} F";
        }

        else if (unit == "F" || unit == "f")
        {
            double celsius = (tempValue - 32) / 1.8;
            return $"{celsius:F2} C";
        }
        else
        {
            return "Invalid Unit";
        }
    }

    public static void Main(string[] args)
    {
        Console.Write($"Enter temperature unit (C OR F) : ");
        string unit = Console.ReadLine();

        Console.Write($"Enter temperature value : ");
        double tempValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{TempConvert(unit, tempValue)}");


    }
}