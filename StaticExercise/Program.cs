namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConveter.FahrenheitToCelsious(20);
            var fahrenheit = TempConveter.CelsiusToFahrenheit(40);
            Console.WriteLine($"Celcius {celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
