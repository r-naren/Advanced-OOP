using System;
namespace CarModel;
class Program{
    public static void Main(string[] args)
    {
        ShiftDezire shiftDezire1 = new ShiftDezire(FuelType.Diesel, 6, Color.Black, 52, 851, "Maruthi", "X6", "GDS456789","HSGEFD98765");
        shiftDezire1.CalculateMilage();
        shiftDezire1.ShowDetails();
        ShiftDezire shiftDezire2 = new ShiftDezire(FuelType.Petrol,5, Color.Blue, 45, 731, "Maruthi", "Dzire", "HN6785678","QWER983246");
        shiftDezire2.CalculateMilage();
        shiftDezire2.ShowDetails();
        Eco eco1 = new Eco(FuelType.Electric, 5, Color.White, 452, 4597, "Evo", "smart1", "QGKI345678","QAJI9876");
        eco1.ShowDetails();
        Eco eco2 = new Eco(FuelType.Diesel, 5, Color.Orange, 38, 642, "Tata", "Nexon", "LPOIHY9836","FVBNI5678");
        eco2.CalculateMilage();
        eco2.ShowDetails();
    }
}