using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilding
{
    public class Enterprise
    {
        private string name;
        private DerivedBuilding1 building1 = new DerivedBuilding1();
        private DerivedBuilding2 building2 = new DerivedBuilding2();
        private DerivedBuilding3 building3 = new DerivedBuilding3();
        private double additionalCost;

        public void Init(string name, int a1, int b1, int a2, int b2, int a3, int b3, double additionalCost)
        {
            this.name = name;
            building1.Init(a1, b1);
            building2.Init(a2, b2);
            building3.Init(a3, b3);
            this.additionalCost = additionalCost;
        }

        public void Read()
        {
            Console.Write("Введите название предприятия: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите параметры здания 1:");
            building1.Read();
            Console.WriteLine("Введите параметры здания 2:");
            building2.Read();
            Console.WriteLine("Введите параметры здания 3:");
            building3.Read();

            Console.Write("Введите стоимость дополнительных помещений: ");
            additionalCost = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            building1.Display();
            building2.Display();
            building3.Display();
            Console.WriteLine($"Стоимость дополнительных помещений: {additionalCost}");
        }

        public double CalculateTotalCost()
        {
            return building1.CalculateTotalCost() + building2.CalculateTotalCost() + building3.CalculateTotalCost() + additionalCost;
        }
    }
}
