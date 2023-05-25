
namespace BMICalculator.Console;

public class BmiCalculator 
{
   private double weightInKg;
   private double heightInCm;
   private double weightInLbs;
   private double heightInInches;
   private double Bmi { get; set; }

   public BmiCalculator(double weight, double height)
   {
      weightInKg = weight;
      heightInCm = height;
   }
   
   public void convertToImperial()
   {
      weightInLbs = weightInKg * 2.20462;
      heightInInches = heightInCm * 0.393701;
   }
   
   public void convertToMetric()
   {
      weightInKg = weightInLbs * 0.453592;
      heightInCm = heightInInches * 2.54;
   }
   
   public double calculateBmi()
   {
      Bmi = weightInKg / Math.Pow(heightInCm / 100, 2);
      return Bmi;
   }
   
   public void calculateBmiImperial()
   {
      Bmi = weightInLbs / Math.Pow(heightInInches, 2) * 703;
   }
   
   public string getBmiCategory()
   {
      if (Bmi < 18.5)
      {
         return "Underweight";
      }

      if (Bmi < 25 && Bmi >= 18.5)
      {
         return "Normal";
      }
      
      if (Bmi < 30 && Bmi >= 25)
      {
         return "Overweight";
      }

      return "Obese";
   }
}