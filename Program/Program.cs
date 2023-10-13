namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CityHierarchy cityHierarchy = new CityHierarchy();

            // Add entries to the dictionary.
            cityHierarchy.Add("South Africa", "-1");
            cityHierarchy.Add("Gauteng", "South Africa");
            cityHierarchy.Add("Pretoria", "Gauteng");
            cityHierarchy.Add("Cape Town", "Western Cape");
            cityHierarchy.Add("Johannesburg", "Gauteng");
            cityHierarchy.Add("Western Cape", "South Africa");
            cityHierarchy.Add("Durban", "KwaZulu-Natal");
            cityHierarchy.Add("KwaZulu-Natal", "South Africa");

            // Sample input and expected output.
            string inputCity = "Gauteng";
            Console.WriteLine("Input: " + inputCity);
            cityHierarchy.FindParent(inputCity);
        }
    }
}