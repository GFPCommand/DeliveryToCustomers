namespace DeliveryToCustomers
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Value can't be equal or less than zero");
            _radius = radius;
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }

    public class Triangle : Shape
    {
        private readonly double _sideA, _sideB, _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA > sideB + sideC || sideB > sideA + sideC || sideC > sideA + sideB) throw new ArgumentException("Wrong arguments! Triangle with these parameters doesn't exist!");

            if (sideA <= 0 || sideB <= 0 || sideC <= 0) throw new ArgumentException("Values can't be less than zero");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double Square()
        {
            double partPerimeter = (_sideA + _sideB + _sideC) / 2;

            return Math.Sqrt(partPerimeter * (partPerimeter - _sideA) * (partPerimeter - _sideB) * (partPerimeter - _sideC));
        }

        public string TriangleType()
        {
            double squareA = Math.Pow(_sideA, 2);
            double squareB = Math.Pow(_sideB, 2);
            double squareC = Math.Pow(_sideC, 2);

            double calc;

            if (_sideA > _sideB && _sideA > _sideC)
            {
                calc = (squareB + squareC);

                if (squareA < calc) return $"Acute-angled triangle";
                else if (squareA == calc) return "Right triangle";
                else if (squareA > calc) return "Obtuse triangle";
            } else if (_sideB > _sideA && _sideB > _sideC)
            {
                calc = squareA + squareC;

                if (squareB < calc) return $"Acute-angled triangle";
                else if (squareB == calc) return "Right triangle";
                else if (squareB > calc) return "Obtuse triangle";
            } else if (_sideC > _sideA && _sideC > _sideB)
            {
                calc = squareA + squareB;

                if (squareC < calc) return $"Acute-angled triangle";
                else if (squareC == calc) return "Right triangle";
                else if (squareC > calc) return "Obtuse triangle";
            }

            return "Unknown triangle type";
        }
    }
}
// Не совсем понял по заданию, что именно имеется в виду в "Вычисление площади фигуры без знания типа фигуры в compile-time".
// Могу предположить, что надо добавить интерфейс и сделать класс более универсальным при проверке на реализацию классом данного интерфейса.
// class <ClassName> <T> where T : <InterfaceName>