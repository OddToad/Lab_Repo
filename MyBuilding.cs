namespace MyBuilding
{
    class MyEnterprise
    {
        static void Main()
        {
            try
            {
                Enterprise enterprise = new Enterprise();
                enterprise.Read();
                enterprise.Display();
                double totalCost = enterprise.CalculateTotalCost();
                Console.WriteLine($"Общая стоимость предприятия: {totalCost}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(1);
            }
        }
    }
}
