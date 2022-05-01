using System;

namespace MyTestLyb
{
    /// <summary>
    /// Вычисление площади треугольника по 3-м сторонам
    /// </summary>
    public class Triangle : Figure
    {
        public double Edge1 { get; set; }
        public double Edge2 { get; set; }
        public double Edge3 { get; set; }

        public Triangle(string name, double edge1, double edge2, double edge3) : base(name)
        {
            if (CheckInputArgs(edge1, edge2, edge3))
            {
                Edge1 = edge1;
                Edge2 = edge2;
                Edge3 = edge3;
            }
        }
        public override double CalculateSquare()
        {
            double perimeter = (Edge1 + Edge2 + Edge3) / 2;
            return Math.Sqrt(perimeter * (perimeter - Edge1) * (perimeter - Edge2) * (perimeter - Edge3));
        }

        protected override bool CheckInputArgs()
        {
            throw new NotImplementedException();
        }
        protected bool CheckInputArgs(double edge1, double edge2, double edge3)
        {
            if (edge1 < 0 || edge2 < 0 || edge3 < 0)
                throw new Exception("Невозможный треугольник. Стороны не могут быть меньше или равны 0");

            if (edge1 > (edge2 + edge3) || edge2 > (edge1 + edge3) || edge3 > (edge1 + edge2))
                throw new Exception("Невозможный треугольник. Одна из сторон больше суммы двух других");

            return true;
        }

        public bool CheckStraightness()
        {
            return (Edge1 == Math.Sqrt(Math.Pow(Edge2, 2) + Math.Pow(Edge3, 2))
                || Edge2 == Math.Sqrt(Math.Pow(Edge1, 2) + Math.Pow(Edge3, 2))
                || Edge3 == Math.Sqrt(Math.Pow(Edge1, 2) + Math.Pow(Edge2, 2)));
        }
    }
}
