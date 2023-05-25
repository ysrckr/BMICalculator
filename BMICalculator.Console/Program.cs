

using BMICalculator.Console;


Console.WriteLine("Welcome to BMI Calculator!");
Console.WriteLine("Type 'exit' to quit the program");
Console.WriteLine("Press 'Enter' to continue");

while (Console.ReadLine() != "exit")
{
    Console.WriteLine("Enter your weight in kg:");

    string? weight = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(weight) || double.TryParse(weight, out double result) == false)
    {
        Console.WriteLine("Weight is not valid");
        Console.WriteLine("Press 'Enter' to continue or type 'exit' to quit the program");
        continue;
    }
    
    Console.WriteLine("Enter your height in cm:");
    string? height = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(height) || double.TryParse(height, out double result2) == false)
    {
        Console.WriteLine("Height is not valid");
        Console.WriteLine("Press 'Enter' to continue or type 'exit' to quit the program");
        continue;
    }
    
    BmiCalculator bmiCalculator = new BmiCalculator(double.Parse(weight), double.Parse(height));
    
    double bmi = bmiCalculator.calculateBmi();
    
    Console.WriteLine($"Your BMI is: {bmi}");
    
    Console.WriteLine($"Your BMI category is: {bmiCalculator.getBmiCategory()}");
    
    Console.WriteLine("Press 'Enter' to continue or type 'exit' to quit the program");
}
