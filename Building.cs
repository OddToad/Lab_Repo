using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilding
{
    public abstract class Building
    {
        protected int area;
        protected double pricePerSqm;

        public abstract void Init(int area, double pricePerSqm);

        public abstract void Read();

        public abstract void Display();

        public abstract double CalculateTotalCost();
    }

    public class BaseHelper1 : Building
    {
        public override void Init(int area, double pricePerSqm)
        {
            this.area = area;
            this.pricePerSqm = pricePerSqm;
        }

        public override void Read()
        {
            Console.Write("Введите цену за квадратный метр и площадь (через пробел) BaseHelper1: ");
            string[] input = Console.ReadLine().Split();
            area = int.Parse(input[0]);
            pricePerSqm = double.Parse(input[1]);
        }

        public override void Display()
        {
            Console.WriteLine($"Площадь: {area}, Цена за квадратный метр: {pricePerSqm}");
        }

        public override double CalculateTotalCost()
        {
            return area * pricePerSqm;
        }
    }

    public class BaseHelper2 : Building
    {
        public override void Init(int area, double pricePerSqm)
        {
            this.area = area;
            this.pricePerSqm = pricePerSqm;
        }

        public override void Read()
        {
            Console.Write("Введите цену за квадратный метр и площадь (через пробел) BaseHelper2: ");
            string[] input = Console.ReadLine().Split();
            area = int.Parse(input[0]);
            pricePerSqm = double.Parse(input[1]);
        }

        public override void Display()
        {
            Console.WriteLine($"Площадь: {area}, Цена за квадратный метр: {pricePerSqm}");
        }

        public override double CalculateTotalCost()
        {
            return area * pricePerSqm;
        }
    }

    public class DerivedHelper1 : BaseHelper1
    {
        private int derivedField1;

        public void Init(int area, double pricePerSqm, int derivedField1)
        {
            base.Init(area, pricePerSqm);
            this.derivedField1 = derivedField1;
        }

        public override void Read()
        {
            base.Read();
            Console.Write("Введите значение для производного поля 1: ");
            derivedField1 = int.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Производное поле 1: {derivedField1}");
        }

        public override double CalculateTotalCost()
        {
            return area * pricePerSqm;
        }
    }

    public class DerivedHelper2 : BaseHelper2
    {
        private int derivedField2;

        public void Init(int area, double pricePerSqm, int derivedField2)
        {
            base.Init(area, pricePerSqm);
            this.derivedField2 = derivedField2;
        }

        public override void Read()
        {
            base.Read();
            Console.Write("Введите значение для производного поля 2: ");
            derivedField2 = int.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Производное поле 2: {derivedField2}");
        }

        public override double CalculateTotalCost()
        {
            return area * pricePerSqm;
        }
    }

    public class DerivedBuilding1 : Building
    {
        private BaseHelper1 helper1 = new BaseHelper1();
        private BaseHelper2 helper2 = new BaseHelper2();

        public override void Init(int area, double pricePerSqm)
        {
            helper1.Init(area, pricePerSqm);
            helper2.Init(area, pricePerSqm);
        }

        public override void Read()
        {
            helper1.Read();
            helper2.Read();
        }

        public override void Display()
        {
            helper1.Display();
            helper2.Display();
        }

        public override double CalculateTotalCost()
        {
            return area * pricePerSqm;
        }
    }

    public class DerivedBuilding2 : Building
    {
        private DerivedHelper1 helper1 = new DerivedHelper1();
        private DerivedHelper2 helper2 = new DerivedHelper2();

        public override void Init(int area, double pricePerSqm)
        {
            helper1.Init(area, pricePerSqm, 2);
            helper2.Init(area, pricePerSqm, 2);
        }

        public override void Read()
        {
            helper1.Read();
            helper2.Read();
        }

        public override void Display()
        {
            helper1.Display();
            helper2.Display();
        }

        public override double CalculateTotalCost()
        {
            return area * pricePerSqm;
        }
    }

    public class DerivedBuilding3 : Building
    {
        private BaseHelper1 helper1 = new BaseHelper1();
        private DerivedHelper2 helper2 = new DerivedHelper2();

        public override void Init(int area, double pricePerSqm)
        {
            helper1.Init(area, pricePerSqm);
            helper2.Init(area, pricePerSqm, 3);
        }

        public override void Read()
        {
            helper1.Read();
            helper2.Read();
        }

        public override void Display()
        {
            helper1.Display();
            helper2.Display();
        }

        public override double CalculateTotalCost()
        {
            return area * pricePerSqm;
        }
    }
}