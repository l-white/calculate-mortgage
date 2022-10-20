namespace CalculateMortgage.Models
{
    public class CalculateMortgageModel
    {
        public int LoanAmount { get; set; }
        public double Rate { get; set; }
        public int Months { get; set; }
        public double PropertyTaxRate { get; set; }


        public double CalculateMortgage()
        {
            double rate = Rate / 1000;
            double mortgage = LoanAmount * ((rate * Math.Pow((1 + rate), Months)) / (Math.Pow((1 + rate), Months) - 1));
            double propertyTaxes = (LoanAmount * PropertyTaxRate/100) / 12;
            return mortgage + propertyTaxes;
        }
    }
}