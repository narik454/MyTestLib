using System;

namespace MyTestLyb
{
    /// <summary>
    /// Вычисление площади круга по радиусу
    /// </summary>
    public class Circle: Figure
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            if (CheckInputArgs(radius))
            {
                Radius = radius;
            }
        }
        public override double CalculateSquare()
        {
            return Math.Round(Math.Pow(Radius, 2) * Math.PI, 1);
        }

        protected override bool CheckInputArgs()
        {
            throw new NotImplementedException();
        }
        protected bool CheckInputArgs(double radius)
        {
            if (radius < 0)
                throw new Exception("Can`t create Circle. Bad arguments");

            return true;
        }
    }
}
