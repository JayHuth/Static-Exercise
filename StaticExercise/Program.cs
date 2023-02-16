namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Enter Fahrenheit Temp:");
                double fahrenheit = Convert.ToDouble(Console.ReadLine()); ;
                double convertToCel = TempConverter.FahrenheitToCelsius(fahrenheit);
                Console.WriteLine("The converted Temp is:" + convertToCel);
                Console.ReadLine();

                Console.WriteLine("Enter Celsius Temp:");
                double celsius = Convert.ToDouble(Console.ReadLine()); ;
                double convertToFahr = TempConverter.CelsiusToFahrenheit(celsius);
                Console.WriteLine("the converted temp is:" + convertToFahr);
                Console.ReadLine();

        }

    }
}
