
namespace BMICalculator.Console;

public class BmiCalculator
{
   private double weight;
   private double height;
   private double weightInLbs;
   private double heightInInches;
   private double Bmi { get; set; }

   public BmiCalculator(double weight, double height)
   {
      this.weight = weight;
      this.height = height;
   }
   
   public void ConvertToImperial()
   {
      weightInLbs = weight * 2.20462;
      heightInInches = height * 0.393701;
   }
   
   public void ConvertToMetric()
   {
      weight = weightInLbs * 0.453592;
      height = heightInInches * 2.54;
   }
   
   public double CalculateBmi()
   {
      Bmi = weight / Math.Pow(height / 100, 2);
      return Bmi;
   }
   
   public void CalculateBmiImperial()
   {
      Bmi = weightInLbs / Math.Pow(heightInInches, 2) * 703;
   }
   
   public string GetBmiCategory()
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